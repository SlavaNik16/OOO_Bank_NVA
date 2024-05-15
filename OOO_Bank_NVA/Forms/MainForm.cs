using MaterialSkin.Controls;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.ChatConnect;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.Models.Enums;
using OOO_Bank_NVA.ModelsResponce;
using OOO_Bank_NVA.Nuget;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Threading;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace OOO_Bank_NVA.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly DbContextOptions<ApplicationContext> options;
        private readonly BaseWriteRepository<Basket> baseBasketWriteRepository;
        private readonly BaseWriteRepository<Tovar> baseTovarWriteRepository;
        private readonly BaseWriteRepository<Card> baseCardWriteRepository;
        private readonly BaseWriteRepository<Person> basePersonWriteRepository;
        private readonly BaseWriteRepository<DBBank> baseDBBankWriteRepository;
        private readonly Chat chat;
        private RoleType userRole;
        private ListViewItem listItem;
        public MainForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
            baseBasketWriteRepository = new BaseWriteRepository<Basket>();
            baseTovarWriteRepository = new BaseWriteRepository<Tovar>();
            baseCardWriteRepository = new BaseWriteRepository<Card>();
            basePersonWriteRepository = new BaseWriteRepository<Person>();
            baseDBBankWriteRepository = new BaseWriteRepository<DBBank>();
        }
        #region MainFormAndTabControl
        public MainForm(Chat chat, RoleType roleType = RoleType.User) : this()
        {
            this.chat = chat;

            chat.GetConnection().On<string, string>("Receive", (fromName, message) =>
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    listBoxChat.Items.Add($"От {fromName}: {message}");
                }));
            });

            chat.GetConnection().On<string, string>("Send", (fromName, message) =>
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    listBoxChat.Items.Add($"От {fromName}: {message}");
                }));
            });

            chat.GetConnection().On("SendClose", () =>
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show("Технические работы через 30 сек.\n\rПожалуйста закончите все свои дела! !", "Предупреждение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolStripProgressBarTime.Visible = true;
                    toolStripStatusTime.Visible = true;
                    timerClose.Start();
                }));
            });

            chat.GetConnection().On("SendBan", () =>
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show("Вы были забанены!\n\rОбратитесь в тех. поддержку, если есть вопросы!\n\r8(900)-635-73-15", "Предупреждение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    Environment.Exit(0);
                }));
            });
            userRole = roleType;
            switch (userRole)
            {
                case RoleType.User:
                    materialTabControlOOOBank.TabPages.RemoveByKey(nameof(tabUsers));
                    tableLayoutPanelAdd_Edit_RemoveTovars.Visible = false;
                    flowLayoutPanelAdmin.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            var butArray = new System.Windows.Forms.Button[]
            {
                butView,butFiltrAndSortUsers,
                butAdd,butEdit, butDelete, butSortWithFiltr,butTovarView,
                butCancelTovar, butBy,
                butChangeCard, butChangeCard, butClearChat, butSendChat,
                butEditPhone, butEditPassword, butEditCard,butInfo
            };
            foreach (var but in butArray)
            {
                ColorsHelp.ButtonSubmit(but);
            }
            ColorsHelp.ButtonRed(butDeleteAccaunt);
            ColorsHelp.ButtonNotofication(butSendTexnWork);
            NavigationTab(tabProfile);

        }
        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var material = (MaterialTabControl)sender;
            var tabPage = material.TabPages[e.TabPageIndex];
            NavigationTab(tabPage);
        }
        private void NavigationTab(TabPage tabPage)
        {
            var tabName = tabPage.Name;
            materialTabControlOOOBank.SelectedTab = tabPage;
            switch (tabName)
            {
                case nameof(tabUsers):
                    ResetDataGridUser();
                    break;
                case nameof(tabTovars):
                    if (AuthorizationForm.user.CardName == null)
                    {
                        var result = MessageBox.Show("Чтобы перейти к товарам, нужно создать карту или добавить существующую!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            materialTabControlOOOBank.SelectedTab = tabProfile;
                        }
                    }
                    ResetDataGridTovars();
                    break;
                case nameof(tabBasket):
                    ResetListView();
                    break;
                case nameof(tabSettings):
                    if (AuthorizationForm.user.CardName != null)
                    {
                        panelButEditCard.Visible = false;
                    }
                    break;
                case nameof(tabProfile):
                    ResetDataUserProfile();
                    break;
                case nameof(tabExit):
                    using (var db = new ApplicationContext(options))
                    {
                        var dbBank = db.DBBanks.FirstOrDefault(b => b.Login == AuthorizationForm.user.Phone);
                        if (dbBank == null) return;
                        dbBank.Status = Enums.StatusType.Offline;
                        baseDBBankWriteRepository.Update(dbBank);
                    }
                    this.Close();
                    break;
                default:
                    ResetDataGridUser();
                    ResetDataGridTovars();
                    ResetListView();
                    break;
            }
            Status();
        }
        #endregion

        #region Status
        private void Status()
        {
            toolStripStatusLabelRole.Text = $"Статус: {userRole.PerevodDescription()}";
            using (var db = new ApplicationContext(options))
            {
                var card = db.Cards.NotDeletedAt().FirstOrDefault(x => x.Nomer == AuthorizationForm.user.CardName);
                if (card == null) return;
                textBoxBalance.Text = $"Баланс карты: ₽ {card.Balance}";
            }
        }
        #endregion

        #region Users
        private void ResetDataGridUser()
        {
            using (var db = new ApplicationContext(options))
            {
                dataGridUsers.DataSource = db.Persons
                    .NotDeletedAt()
                    .OrderBy(x => x.Phone)
                    .Where(s => s.Phone != AuthorizationForm.user.Phone)
                    .Join(db.DBBanks.NotDeletedAt(), x => x.Phone, b => b.Login,
                    (x, b) => new UserResponce
                    {
                        Id = x.Id,
                        Phone = x.Phone.ToString(),
                        Surname = x.Surname.ToString(),
                        Name = x.Name.ToString(),
                        CardName = x.CardName ?? Constants.Not_Card_Nomer,
                        Gender = x.Gender.PerevodDescription(),
                        Status = b.Status.PerevodDescription(),
                        Role = b.Role.PerevodDescription()
                    }).ToList();
            }
        }
        private void dataGridUsers_SelectionChanged(object sender, System.EventArgs e)
        {

            butView.Enabled =
            butStripView.Enabled =
                    dataGridUsers.SelectedRows.Count == 1;
        }
        private void butView_Click(object sender, EventArgs e)
        {
            var id = (UserResponce)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;
            using (var db = new ApplicationContext(options))
            {
                var user = db.Persons.NotDeletedAt().FirstOrDefault(x => x.Phone == id.Phone);
                if (user == null) return;
                var personViewForm = new PersonViewForm(user, chat);
                this.Hide();
                if (personViewForm.ShowDialog() == DialogResult.OK)
                {
                    NavigationTab(tabUsers);
                }
                this.Show();
            }
        }

        private void butFiltrAndSortUsers_Click(object sender, EventArgs e)
        {
            var filtrAndSortUserForm = new FiltrAndSortUsersForm();
            this.Hide();
            if (filtrAndSortUserForm.ShowDialog() == DialogResult.OK)
            {
                dataGridUsers.DataSource = filtrAndSortUserForm.GetDataGridView().DataSource;
            }
            this.Show();
        }
        #endregion

        #region Tovars
        private void ResetDataGridTovars()
        {
            using (var db = new ApplicationContext(options))
            {
                dataGridTovar.DataSource = db.Tovars.NotDeletedAt().OrderBy(x => x.Title).Select(x => new TovarResponce
                {
                    Id = x.Id,
                    MaxCount = x.MaxCount,
                    Price = x.Price,
                    Title = x.Title,
                    Description = x.Description,
                    Photo = x.Photo,
                }).ToImmutableList();
            }
        }
        private void butAdd_Click(object sender, System.EventArgs e)
        {
            var addTovarForm = new AddTovarForm();
            this.Hide();
            if (addTovarForm.ShowDialog() == DialogResult.OK)
            {
                var tovar = addTovarForm.Tovar;
                baseTovarWriteRepository.Add(tovar, AuthorizationForm.UserName);
                NavigationTab(tabTovars);
            }
            this.Show();
        }

        private void butEdit_Click(object sender, System.EventArgs e)
        {
            var id = (TovarResponce)dataGridTovar.Rows[dataGridTovar.SelectedRows[0].Index].DataBoundItem;
            var addTovarForm = new AddTovarForm(id);
            this.Hide();
            if (addTovarForm.ShowDialog() == DialogResult.OK)
            {
                var tovar = addTovarForm.Tovar;
                baseTovarWriteRepository.Update(tovar, AuthorizationForm.UserName);
                NavigationTab(tabTovars);
            }
            this.Show();
        }

        private void butDelete_Click(object sender, System.EventArgs e)
        {
            var id = (TovarResponce)dataGridTovar.Rows[dataGridTovar.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить товар:\nНазвание: {id.Title}\nЦена: {id.Price}", "Предупреждение!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (var db = new ApplicationContext(options))
                {
                    var tovar = db.Tovars.NotDeletedAt().ById(id.Id);
                    baseTovarWriteRepository.Delete(tovar);
                    NavigationTab(tabTovars);
                }
            }
        }

        private void dataGridTovar_SelectionChanged(object sender, System.EventArgs e)
        {
            var count = dataGridTovar.SelectedRows.Count == 1;
            butEdit.Enabled =
            butDelete.Enabled = count;


            panelInfoTovar.Visible = count;
            if (count)
            {
                var id = (TovarResponce)dataGridTovar.Rows[dataGridTovar.SelectedRows[0].Index].DataBoundItem;
                textBoxDesc.Text = id.Description;
                pictureBoxTovar.Image = !string.IsNullOrEmpty(id.Photo) ? Bitmap.FromFile(id.Photo) : Properties.Resources.photoEmpty;
            }
        }

        private void butTovarView_Click(object sender, System.EventArgs e)
        {
            var id = (TovarResponce)dataGridTovar.Rows[dataGridTovar.SelectedRows[0].Index].DataBoundItem;

            var addTovarBasketForm = new AddTovarBasketForm(id);
            if (addTovarBasketForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new ApplicationContext(options))
                {
                    var tovar = db.Tovars.NotDeletedAt().FirstOrDefault(x => x.Id == id.Id);
                    if (tovar == null) return;
                    var basket = addTovarBasketForm.Basket;
                    var card = db.Cards.NotDeletedAt().FirstOrDefault(x => x.Nomer == AuthorizationForm.user.CardName);
                    var priceAll = (basket.Count * basket.Price) * 0.8m;
                    if (card.Balance < priceAll)
                    {
                        MessageBox.Show("Простите вы не можете бронировать товар без " +
                            $"возможности оплатить хотя бы 80%({priceAll})", "Информация!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    tovar.MaxCount -= basket.Count;
                    baseTovarWriteRepository.Update(tovar);
                    if (tovar.MaxCount <= 0)
                    {
                        baseTovarWriteRepository.Delete(tovar);
                    }
                    baseBasketWriteRepository.Add(basket, AuthorizationForm.UserName);
                    NavigationTab(tabTovars);
                }
            }
        }

        private void butSortWithFiltr_Click(object sender, System.EventArgs e)
        {
            var filtrAndSortForm = new FiltrAndSortTovarForm();
            this.Hide();
            if (filtrAndSortForm.ShowDialog() == DialogResult.OK)
            {
                dataGridTovar.DataSource = filtrAndSortForm.GetDataGridView().DataSource;
            }
            this.Show();
        }
        #endregion

        #region Basket
        private void ResetListView()
        {
            listView.Items.Clear();
            using (var db = new ApplicationContext(options))
            {
                var imageList = new ImageList();
                imageList.ImageSize = new Size(32, 32);
                var list = db.Baskets.NotDeletedAt()
                    .OrderBy(x => x.StatusBy)
                    .ThenByDescending(x => x.CreatedAt)
                    .Where(x => x.PersonId == AuthorizationForm.user.Id).ToList();
                foreach (var l in list)
                {
                    listItem = new ListViewItem(new string[] {
                        string.Empty,
                        l.Title,
                        l.CreatedAt.ToString("G"),
                        l.Count.ToString(),
                        (l.Price*l.Count).ToString(),
                        l.StatusBy.PerevodDescription()
                    });
                    listItem.Tag = l.Id;

                    if (l.Photo != string.Empty)
                    {
                        imageList.Images.Add(l.Photo, new Bitmap(l.Photo));
                        listView.SmallImageList = imageList;
                        listItem.ImageIndex = imageList.Images.IndexOfKey(l.Photo);
                    }
                    listView.Items.Add(listItem);
                    listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.None);
                    listView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Item.BackColor = Color.FromArgb(200, 248, 213, 104);
            e.Item.UseItemStyleForSubItems = true;
        }

        private void listView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(127, 232, 229)), e.Bounds);
            e.DrawText();
        }
        private void butCancelTovar_Click(object sender, System.EventArgs e)
        {
            var id = listView.SelectedItems[0].Tag.ToString();
            using (var db = new ApplicationContext(options))
            {
                var basket = db.Baskets.NotDeletedAt().FirstOrDefault(x => x.Id == Guid.Parse(id) && x.StatusBy == StatusBy.Attendant);
                if (basket == null)
                {
                    MessageBox.Show("Вы не можете отменить товар, который уже куплен!", "Предупреждение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите отменить из брони данный товар!", "Предупреждение!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    baseBasketWriteRepository.Delete(basket);
                    var tovar = db.Tovars.NotDeletedAt().FirstOrDefault(x => x.Title == basket.Title);
                    if (tovar == null)
                    {
                        var tovarNew = new Tovar()
                        {
                            Title = basket.Title,
                            Price = basket.Price,
                            MaxCount = basket.Count,
                            Description = basket.Description,
                            Photo = basket.Photo,
                        };
                        baseTovarWriteRepository.Add(tovarNew, AuthorizationForm.UserName);
                    }
                    else
                    {
                        tovar.MaxCount += basket.Count;
                        baseTovarWriteRepository.Update(tovar, AuthorizationForm.UserName);
                    }
                    NavigationTab(tabBasket);
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            butCancelTovar.Enabled =
            butBy.Enabled =
                listView.SelectedItems.Count == 1;
        }

        private void butBy_Click(object sender, EventArgs e)
        {
            var id = listView.SelectedItems[0].Tag.ToString();
            using (var db = new ApplicationContext(options))
            {
                var basket = db.Baskets.NotDeletedAt().FirstOrDefault(x => x.Id == Guid.Parse(id));
                if (basket == null) { return; }
                if (basket.StatusBy == StatusBy.Attendant)
                {
                    var priceAll = basket.Price * basket.Count;
                    if (MessageBox.Show("Вы действительно хотите купить данный товар:\n\r" +
                        $"Название: {basket.Title}\n\r" +
                        $"Всего: {priceAll:C2}\n\r" +
                        $"Кол-во: {basket.Count}", "Информация!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        var card = db.Cards.NotDeletedAt().FirstOrDefault(x => x.Nomer == AuthorizationForm.user.CardName);
                        if (card == null) return;
                        if (card.Balance < priceAll)
                        {
                            MessageBox.Show("Недостаточно средств для оплаты товара!", "Ошибка операции!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        card.Balance -= priceAll;
                        baseCardWriteRepository.Update(card);
                        basket.StatusBy = StatusBy.By;
                        baseBasketWriteRepository.Update(basket);
                    }
                }
                else
                {
                    MessageBox.Show("Вы уже оплатили этот товар!", "Товар оплачен!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                NavigationTab(tabBasket);
            }
        }
        #endregion

        #region Settings
        private void butEditCard_Click(object sender, EventArgs e)
        {
            var regCardBankForm = new RegCardBankForm();
            this.Hide();
            if (regCardBankForm.ShowDialog() == DialogResult.OK)
            {
                var card = regCardBankForm.Card;
                card.Balance = 2000;
                baseCardWriteRepository.Add(card, AuthorizationForm.UserName);
                AuthorizationForm.SetCardNameUser(card.Nomer);
                basePersonWriteRepository.Update(AuthorizationForm.user, AuthorizationForm.UserName);
                NavigationTab(tabSettings);
            }
            this.Show();
        }

        private void butChangeCard_Click(object sender, EventArgs e)
        {
            var cardValidate = new CardValidateForm();
            this.Hide();
            if (cardValidate.ShowDialog() == DialogResult.OK)
            {
                AuthorizationForm.SetCardNameUser(cardValidate.Card.Nomer);
                basePersonWriteRepository.Update(AuthorizationForm.user, AuthorizationForm.UserName);
                NavigationTab(tabProfile);
            }
            this.Show();
        }

        private void butDeleteAccaunt_Click(object sender, EventArgs e)
        {
            var user = AuthorizationForm.user;
            if (MessageBox.Show("Вы действительно хотите удалить данный аккаунт!!!", "Предупреждение!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (MessageBox.Show($"Все ваши данные будут стерты!" +
                    $"\n\rФамилия: {user.Surname}" +
                    $"\n\rИмя: {user.Name}" +
                    $"\n\rТелефон: {user.Phone}", "Предупреждение!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    using (var db = new ApplicationContext(options))
                    {
                        var personEnterForm = new PersonEnterForm(true);
                        if (personEnterForm.ShowDialog() == DialogResult.OK)
                        {
                            var dbBank = db.DBBanks.IsAuthorization(user.Phone, personEnterForm.DBBank.Password);
                            if (dbBank == null)
                            {
                                MessageBox.Show("Неправильный пароль!!!", "Отказано в удаление",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            baseDBBankWriteRepository.Delete(dbBank);
                            basePersonWriteRepository.Delete(user);
                        }

                    }
                     this.Close();
                }
            }
        }
        private void butSendTexnWork_Click(object sender, EventArgs e)
        {
            chat.SendClose();
        }

        private void butEditPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Извините, опция находится на стадии разработки!\n\rЖдите дальнейших обновлений программы!",
                "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butEditPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Извините, опция находится на стадии разработки!\n\rЖдите дальнейших обновлений программы!",
               "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butInfo_Click(object sender, EventArgs e)
        {
            var aboutBoxInfo = new AboutBoxInfo();
            aboutBoxInfo.ShowDialog();
        }
        #endregion

        #region Profile
        private void ResetDataUserProfile()
        {
            var user = AuthorizationForm.user;
            textBoxSurname.Text = user.Surname;
            textBoxSurname.BackColor = SystemColors.Window;
            textBoxName.Text = user.Name;
            maskTextBoxPhone.Text = user.Phone.Trim();
            textBoxGender.Text = user.Gender.PerevodDescription();
            using (var db = new ApplicationContext(options))
            {
                var card = db.Cards.NotDeletedAt().FirstOrDefault(x => x.Nomer == user.CardName);
                if (card == null) return;
                maskTextBoxCardName.Text = card.Nomer;
                maskedTextBoxCVCCode.Text = card.CSCCode.ToString();
                maskedTextBoxDataEnd.Text = card.DateEnd.ToString();
                butEditCard.Visible = false;
            }
        }
        private void maskedTextBoxPhoneChat_TextChanged(object sender, EventArgs e)
        {
            butClearChat.Enabled = butSendChat.Enabled = maskedTextBoxPhoneChat.MaskFull;
            listBoxChat.Items.Clear();
            if (maskedTextBoxPhoneChat.MaskFull)
            {
                using (var db = new ApplicationContext(options))
                {
                    var isPhone = db.DBBanks.Where(x => x.Login != AuthorizationForm.user.Phone).IsPhoneWithLogin(maskedTextBoxPhoneChat.Text);
                    if (!isPhone)
                    {
                        maskedTextBoxPhoneChat.Text = string.Empty;
                        MessageBox.Show("Чат не найден!!!", "Ошибка!",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    chat.Receive(AuthorizationForm.user.Phone, maskedTextBoxPhoneChat.Text);
                }
            }
        }

        private void butSendChat_Click(object sender, EventArgs e)
        {
            if (textBoxMessageChat.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Введите какое-нибудь сообщение!!!", "Инофрмация!",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            chat.Send(AuthorizationForm.user.Phone, maskedTextBoxPhoneChat.Text, textBoxMessageChat.Text);
        }

        private void butClearChat_Click(object sender, EventArgs e)
        {
            listBoxChat.Items.Clear();
        }



        #endregion

        #region Timer
        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (int.TryParse(toolStripStatusTime.Text,out int count))
            {
                toolStripProgressBarTime.Value = count;
                toolStripStatusTime.Text = (count - 1).ToString();
            }

            if(count - 1 == 0)
            {
                timerClose.Stop();
                Environment.Exit(0);
            }
        }
        #endregion
    }
}
