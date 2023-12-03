using MaterialSkin.Controls;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OOO_Bank_NVA.Forms
{
    public partial class FiltrAndSortForm : MaterialForm
    {
        public FiltrAndSortForm(DataGridView dataGridViewOld)
        {
            InitializeComponent();
            dataGridViewNew.DataSource = dataGridViewOld.DataSource;
        }
    }
}
