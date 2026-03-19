using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string typed_msg; 
            typed_msg = txtSubmit.Text;
            lstMsgWindow.Items.Add(typed_msg);

            txtSubmit.Text = "";

            txtSubmit.Focus();
        }
    }
}
