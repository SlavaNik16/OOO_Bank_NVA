using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOO_Bank_NVA.Forms
{
    public partial class FiltrAndSortForm : MaterialForm
    {
        public FiltrAndSortForm(DataGridView dataGridViewOld)
        {
            InitializeComponent();
            dataGridViewNew.DataSource = dataGridViewOld.DataSource;
            //dataGridViewNew.Columns[0].Visible= false;
            listBoxSort.Items.Add("Id");
        }
        private void butSort_Click(object sender, System.EventArgs e)
        {
            if(listBoxSort.SelectedIndex >= 0)
            {

            }
        }
    }
}
