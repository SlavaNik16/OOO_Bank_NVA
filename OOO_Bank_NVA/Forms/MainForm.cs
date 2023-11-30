using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.Nuget;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;

namespace OOO_Bank_NVA.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly DbContextOptions<ApplicationContext> options;
        public MainForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
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
                    Phone = opt.Phone,
                    Surname = opt.Surname,
                    Name = opt.Name,
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
    }
}
