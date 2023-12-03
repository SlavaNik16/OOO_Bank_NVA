using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.Nuget;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly DbContextOptions<ApplicationContext> options;
        private readonly BaseWriteRepository<DBBank> baseDBBankWriteRepository;
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
            baseDBBankWriteRepository = new BaseWriteRepository<DBBank>();
            ResetDataGridUser();
            ResetDataGridTovars();
            ColorsHelp.ButtonSubmit(butView);
            ColorsHelp.ButtonSubmit(butSend);
            ColorsHelp.ButtonSubmit(butTranslate);
        }

        #region Users
        private void ResetDataGridUser()
        {
            using (var db = new ApplicationContext(options))
            {
                dataGridUsers.DataSource = db.Persons
                    .Where(s => s.Phone != "(222)-222-22-22")
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
        private async Task GetHttp(string message)
        {
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
        }
        #endregion

        #region Tovars
        private void ResetDataGridTovars()
        {
            using (var db = new ApplicationContext(options))
            {
                dataGridTovar.DataSource = db.Tovars.Select(x => new
                {
                    Title = x.Tittle,
                    Price = x.Price.ToString(),
                }).ToList();
            }
        }
        private void butAdd_Click(object sender, System.EventArgs e)
        {
            var addTovarForm = new AddTovarForm();
            this.Hide();
            addTovarForm.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
