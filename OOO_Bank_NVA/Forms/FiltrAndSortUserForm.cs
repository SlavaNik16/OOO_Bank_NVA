using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models.Enums;
using OOO_Bank_NVA.ModelsResponce;
using OOO_Bank_NVA.Nuget;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Constants = OOO_Bank_NVA.DB.ReadDB.Constants;

namespace OOO_Bank_NVA.Forms
{
    public partial class FiltrAndSortUsersForm : MaterialForm
    {
        private DbContextOptions<DB.ApplicationContext> options;
        public FiltrAndSortUsersForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
            DataGridReset();
            listBoxSort.SelectedIndex = 0;
            ColorsHelp.ButtonSubmit(butSearch);
            ColorsHelp.ButtonRed(butExport);
            ColorsHelp.ButtonSubmit(butFiltr);
        }
        public DataGridView GetDataGridView()
            => dataGridUsers;

        private IEnumerable<UserResponce> GetTovarList()
        {
            var list = new List<UserResponce>();
            using (var db = new DB.ApplicationContext(options))
            {
                list = db.Persons
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
            return list;
        }
        private void DataGridReset()
        {
            dataGridUsers.DataSource = GetTovarList();
        }
        private void butSort_Click(object sender, System.EventArgs e)
        {
            if (listBoxSort.SelectedIndex >= 0)
            {
                var list = GetTovarList();
                using (var db = new DB.ApplicationContext(options))
                {
                    switch (dataGridUsers.Columns[listBoxSort.SelectedIndex + 1].DataPropertyName)
                    {
                        case "Phone":
                            list = radioAsc.Checked ? list.OrderBy(x => x.Phone).ToList() : list.OrderByDescending(x => x.Phone).ToList();
                            break;
                        case "Surname":
                            list = radioAsc.Checked ? list.OrderBy(x => x.Surname).ToList() : list.OrderByDescending(x => x.Surname).ToList();
                            break;
                        case "Name":
                            list = radioAsc.Checked ? list.OrderBy(x => x.Name).ToList() : list.OrderByDescending(x => x.Name).ToList();
                            break;
                        case "Gender":
                            list = radioAsc.Checked ? list.OrderBy(x => x.Gender).ToList() : list.OrderByDescending(x => x.Gender).ToList();
                            break;
                    }

                    dataGridUsers.DataSource = list;
                }
            }
        }

        private void butViewAll_Click(object sender, System.EventArgs e)
        {
            DataGridReset();
        }

        private void butSearch_Click(object sender, System.EventArgs e)
        {
            var isSearch = false;
            for (int i = 0; i < dataGridUsers.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridUsers.RowCount; j++)
                {
                    dataGridUsers[i, j].Style.BackColor = Color.FromArgb(255, 255, 251, 217);
                    dataGridUsers[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridUsers.RowCount; i++)
            {
                for (int j = 0; j < dataGridUsers.ColumnCount; j++)
                {
                    if (dataGridUsers.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                    {
                        isSearch = true;
                        dataGridUsers.Rows[i].Cells[j].Style.BackColor = Color.AliceBlue;
                        dataGridUsers.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                    }
                }
            }
            if (!isSearch)
            {
                MessageBox.Show("Ничего не найдено!");
            }
        }

        private void searchBox_TextChanged(object sender, System.EventArgs e)
        {
            butSearch.Enabled =
               !string.IsNullOrWhiteSpace(searchBox.Text);
        }

        private void butExport_Click(object sender, System.EventArgs e)
        {
            Nuget.Export.CreateExcelSheet(dataGridUsers, "Список пользователей");
        }

        private void butFiltr_Click(object sender, System.EventArgs e)
        {
            var list = GetTovarList();
            dataGridUsers.DataSource = list.Where(x => x.Status == comboBoxStatus.SelectedItem.ToString() && x.Role == comboBoxRole.SelectedItem.ToString()).ToList();
        }

        private void FiltrAndSortUsersForm_Load(object sender, System.EventArgs e)
        {
            FillComboBoxRole();
            FillComboBoxStatus();

        }
        private void FillComboBoxRole()
        {
            foreach (RoleType role in Enum.GetValues(typeof(RoleType)))
            {
                comboBoxRole.Items.Add(role.PerevodDescription());
            }
            comboBoxRole.SelectedIndex = 0;
        }
        private void FillComboBoxStatus()
        {
            foreach (StatusType status in Enum.GetValues(typeof(StatusType)))
            {
                comboBoxStatus.Items.Add(status.PerevodDescription());
            }
            comboBoxStatus.SelectedIndex = 0;
        }
    }
}
