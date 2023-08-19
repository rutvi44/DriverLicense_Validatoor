using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class txtDateofBirth : Form
    {
        private List<Driver> _driverRecords = new List<Driver>();
   
        public txtDateofBirth()
        {
            InitializeComponent();
        }
        private void btn_DriverCheck(object sender, EventArgs e)
        {
            try
            {
                // Adding new driver 
                Driver dv = new Driver(txtName.Text.ToString(), txtDob.Text, textHeight.Text, txtLicNumber.Text);
                _driverRecords.Add(dv);

                // Colour Green text will appear if all the information is correctly done 
                error.ForeColor = Color.Green;
                error.Text = "Driver Info is Valid";
            }
            catch (Exception ex)
            {
                //Setting Error Message
                SetErrorMessage(ex.Message);
            }

        }

        private void SetErrorMessage(string msg)
        {
            // Red Colour text if driver information is wrong
            error.ForeColor = Color.Red;
            error.Text = msg;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtDateofBirth_Load(object sender, EventArgs e)
        {

        }
    }
}