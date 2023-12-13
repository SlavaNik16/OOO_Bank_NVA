using MaterialSkin.Controls;

namespace OOO_Bank_NVA.Forms
{
    public partial class PINCodeForm : MaterialForm
    {
        private string pincode;
        public PINCodeForm()
        {
            InitializeComponent();
        }
        public string PINCODE => pincode;
        private void maskedTextBoxPinCode_TextChanged(object sender, System.EventArgs e)
        {
            pincode = maskedTextBoxPinCode.Text;
            butEnter.Enabled = maskedTextBoxPinCode.MaskFull ? true : false;
        }
    }
}
