using MaterialSkin.Controls;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.Forms
{
    public partial class PersonEnterForm : MaterialForm
    {
        private DBBank dbBank;
        public PersonEnterForm()
        {
            InitializeComponent();

            dbBank = new DBBank();
            ColorsHelp.ButtonSubmit(butEnter);
            ColorsHelp.ButtonCancel(butCancel);
        }

        public DBBank DBBank => dbBank;
    }
}
