using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.Nuget;
using System.Linq;
using System.Windows.Forms;
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
            options = DataBaseHelper.Options();
            baseDBBankWriteRepository = new BaseWriteRepository<DBBank>();
            ResetDataGrid();
            ColorsHelp.ButtonSubmit(butBlocked);
            ColorsHelp.ButtonSubmit(butView);

        }

        private void ResetDataGrid()
        {
            using (var db = new ApplicationContext(options))
            {
                var user = new Person();
                user.Phone = "(900)-000-00-00";
                var dbBanks = db.DBBanks.FirstOrDefault(y => y.Login == user.Phone);
                dataGridUsers.DataSource = db.Persons.Where(x => x.Phone != user.Phone).Select(opt=> new
                {
                    Phone = opt.Phone.ToString(),
                    Surname = opt.Surname.ToString(),
                    Name = opt.Name.ToString(),
                    Gender = opt.Gender.PerevodDescription(),
                    Status = dbBanks.Status.PerevodDescription(),
                    Role = dbBanks.Role.PerevodDescription()
                }).ToList();
            }
        }

        private void dataGridUsers_SelectionChanged(object sender, System.EventArgs e)
        {
            butBlocked.Enabled =
            butView.Enabled = 
                dataGridUsers.SelectedRows.Count == 1;  
        }

        private void butBlocked_Click(object sender, System.EventArgs e)
        {
            var id = dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].Cells["ColumnPhone"];
            using (var db = new ApplicationContext(options))
            {
                var person = db.Persons.FirstOrDefault(x => x.Phone == id.Value.ToString());
                if (person == null) return;

                var result = MessageBox.Show($"Вы действительно хотите забанить\n" +
                    $"Id: {person.Id}\n" +
                    $"Телефон: {person.Phone}\n" +
                    $"Фамилия:{person.Surname}\n" +
                    $"Имя: {person.Name}", "Предупреждение!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var bank = db.DBBanks.FirstOrDefault(x => x.Login == person.Phone);
                    bank.Status = StatusType.Blocked;
                    baseDBBankWriteRepository.Update(bank, AuthorizationForm.UserName);
                    MessageBox.Show($"Пользователь успешно забанен!",
                        "Информация!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetDataGrid();
                }
            }
            
        }
    }
}
