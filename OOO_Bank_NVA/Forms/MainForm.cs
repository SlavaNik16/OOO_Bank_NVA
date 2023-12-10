using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.ModelsResponce;
using OOO_Bank_NVA.Nuget;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace OOO_Bank_NVA.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly DbContextOptions<ApplicationContext> options;
        private readonly BaseWriteRepository<Basket> baseBasketWriteRepository;
        private readonly BaseWriteRepository<Tovar> baseTovarWriteRepository;
        private ListViewItem listItem;
        public MainForm()
        {
            InitializeComponent();
           // connection = new HubConnectionBuilder()
           //        .WithUrl("https://localhost:7097/chat")
           //        .Build();

           // connection.On<string, string>("Send", (message, username) =>
           //{
           //    this.Invoke(new Action(() =>
           //    {
           //        listBox1.Items.Add($"{username} отправил: {message}");
           //    }));
           //});

            options = DataBaseHelper.Options();
            baseBasketWriteRepository = new BaseWriteRepository<Basket>();
            baseTovarWriteRepository = new BaseWriteRepository<Tovar>();

        }
        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var material = (MaterialTabControl)sender;
            var tabName = material.TabPages[e.TabPageIndex].Name;
            switch (tabName)
            {
                case nameof(tabUsers):
                    ResetDataGridUser();
                    break;
                case nameof(tabTovars):
                    if(AuthorizationForm.user.CardName == null)
                    {
                        var result = MessageBox.Show("Чтобы перейти к товарам, нужно создать карту или добавить существующую!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(result == DialogResult.OK)
                        {
                            materialTabControl1.SelectedTab = tabProfile;
                        }
                    }
                    ResetDataGridTovars();
                    break;
                case nameof(tabBasket):
                    ResetListView();
                    break;
                case nameof(tabSettings):
                    
                    break;
                case nameof(tabProfile):
                    ResetDataUserProfile();
                    break;
                default:
                    ResetDataGridUser();
                    ResetDataGridTovars();
                    ResetListView();
                    break;
            }
        }
        private void ResetDataUserProfile()
        {
            var user = AuthorizationForm.user;
            textBoxSurname.Text = user.Surname;
            textBoxSurname.BackColor = SystemColors.Window;
            textBoxName.Text = user.Name;
            maskTextBoxPhone.Text = user.Phone.Trim();
            textBoxGender.Text = user.Gender.PerevodDescription();
            maskTextBoxCardName.Text = user.CardName ?? string.Empty;
        }

        #region Users
        private void ResetDataGridUser()
        {
            using (var db = new ApplicationContext(options))
            {
                dataGridUsers.DataSource = db.Persons
                    .NotDeletedAt()
                    .Where(s => s.Phone != AuthorizationForm.user.Phone)
                    .Join(db.DBBanks, x => x.Phone, b => b.Login,
                    (x, b) => new
                    {
                        Phone = x.Phone.ToString(),
                        Surname = x.Surname.ToString(),
                        Name = x.Name.ToString(),
                        CardName = x.CardName ?? "Нет",
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
            butSend.Enabled = 
                butStripSend.Enabled = 
            butTranslate.Enabled =
                butStripTranslate.Enabled =
                    dataGridUsers.SelectedRows.Count == 1;  
        }


        //var id = dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].Cells["ColumnPhone"];
            //using (var db = new ApplicationContext(options))
            //{
            //    var person = db.Persons.FirstOrDefault(x => x.Phone == id.Value.ToString());
            //    if (person == null) return;

            //    var result = MessageBox.Show($"Вы действительно хотите забанить\n" +
            //        $"Id: {person.Id}\n" +
            //        $"Телефон: {person.Phone}\n" +
            //        $"Фамилия:{person.Surname}\n" +
            //        $"Имя: {person.Name}", "Предупреждение!",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        var bank = db.DBBanks.FirstOrDefault(x => x.Login == person.Phone);
            //        bank.Status = StatusType.Blocked;
            //        baseDBBankWriteRepository.Update(bank, AuthorizationForm.UserName);
            //        MessageBox.Show($"Пользователь успешно забанен!",
            //            "Информация!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ResetDataGrid();
            //    }
            //}
        //HubConnection connection;

          //try
            //{
            //    // отправка сообщения
            //    await connection.InvokeAsync("Send", "sdfsfd", textBox1.Text);
            //}
            //catch (Exception ex)
            //{
            //    listBox1.Items.Add(ex.Message);
            //}
            
            
            //try
            //{
            //    // подключемся к хабу
            //    await connection.StartAsync();
            //    listBox1.Items.Add("Вы вошли в чат");
            //}
            //catch (Exception ex)
            //{
            //    listBox1.Items.Add(ex.Message);
            //}
        
        #endregion
        private void MainForm_Load(object sender, System.EventArgs e)
        {

            var butArray = new System.Windows.Forms.Button[]
            {
                butView, butSend, butTranslate, 
                butAdd,butEdit, butDelete, butSortWithFiltr,butTovarView,
                butCancelTovar, butBy
            };
            foreach(var but in butArray)
            {
                ColorsHelp.ButtonSubmit(but);
            }
            ResetDataGridUser();
            ResetDataGridTovars();
            ResetListView();
            ResetDataUserProfile();
            materialTabControl1.SelectedTab = tabProfile;
        }
        #region Tovars
        private void ResetDataGridTovars()
        {
            using (var db = new ApplicationContext(options))
            {
                dataGridTovar.DataSource = db.Tovars.AsNoTracking().NotDeletedAt().OrderBy(x => x.Title).Select(x => new TovarResponce
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
                ResetDataGridTovars();
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
                ResetDataGridTovars();
            }
            this.Show();
        }

        private void butDelete_Click(object sender, System.EventArgs e)
        {
            var id = (TovarResponce)dataGridTovar.Rows[dataGridTovar.SelectedRows[0].Index].DataBoundItem;
            if(MessageBox.Show($"Вы действительно хотите удалить товар:\nНазвание: {id.Title}\nЦена: {id.Price}", "Предупреждение!",
                MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (var db = new ApplicationContext(options))
                {
                    var tovar = db.Tovars.ById(id.Id);
                    baseTovarWriteRepository.Delete(tovar);
                    ResetDataGridTovars();
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
                pictureBoxTovar.Image = !string.IsNullOrEmpty(id.Photo) ? Bitmap.FromFile(id.Photo) : null;
            }
        }

        private void butTovarView_Click(object sender, System.EventArgs e)
        {
            var id = (TovarResponce)dataGridTovar.Rows[dataGridTovar.SelectedRows[0].Index].DataBoundItem;
            var addTovarBasketForm = new AddTovarBasketForm(id);
            this.Hide();
            if (addTovarBasketForm.ShowDialog() == DialogResult.OK)
            {
                var basket = addTovarBasketForm.Basket;
                baseBasketWriteRepository.Add(basket, AuthorizationForm.UserName);
                ResetDataGridTovars();
            }
            this.Show();
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
                var list = db.Baskets.AsNoTracking().NotDeletedAt().Where(x=>x.PersonId == AuthorizationForm.user.Id).OrderBy(x => x.CreatedAt).ToList();
                foreach (var l in list)
                {
                    var tovar = db.Tovars.FirstOrDefault(x => x.Id == l.TovarId);
                    listItem = new ListViewItem(new string[] {
                        string.Empty,
                        tovar.CreatedAt.ToString("G"),
                        l.Count.ToString(),
                        (tovar.Price*l.Count).ToString(),
                        l.StatusBy.PerevodDescription()
                    });
                    listItem.Tag = l.Id;
                    var photo = db.Tovars.FirstOrDefault(x => x.Id == l.TovarId).Photo;
                    if (!string.IsNullOrEmpty(photo))
                    {
                        imageList.Images.Add(photo, new Bitmap(photo));
                        listView.SmallImageList = imageList;
                        listItem.ImageIndex = imageList.Images.IndexOfKey(photo);
                    }
                    listView.Items.Add(listItem);
                    listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.None);
                    listView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
        #endregion

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
                var basket = db.Baskets.FirstOrDefault(x => x.Id == Guid.Parse(id));
                if (basket == null) { return; }
                if (MessageBox.Show("Вы действительно хотите отменить из брони данный товар!", "Предупреждение!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    baseBasketWriteRepository.Delete(basket);
                    ResetListView();
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
                var basket = db.Baskets.FirstOrDefault(x => x.Id == Guid.Parse(id));
                if (basket == null) { return; }
                if (MessageBox.Show("Вы действительно хотите отменить из брони данный товар!", "Предупреждение!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    baseBasketWriteRepository.Delete(basket);
                    ResetListView();
                }
            }
        }
    }
}
