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
            // 중요: .Trim()을 붙여서 '줄바꿈'이나 '공백'을 제거한 깨끗한 글자만 가져옵니다.
            string cleanText = txtSubmit.Text.Trim();

            // 내용이 없으면 중단
            if (string.IsNullOrWhiteSpace(cleanText))
            {
                return;
            }

            // 리스트박스에는 깨끗한 글자만 추가
            lstMsgWindow.Items.Add(cleanText);

            // 입력창 비우고 포커스
            txtSubmit.Clear();
            txtSubmit.Focus();

            string typed_msg;
            typed_msg = txtSubmit.Text;
            lstMsgWindow.Items.Add(typed_msg);

            txtSubmit.Text = "";

            txtSubmit.Focus();

        }

        private void lstMsgWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMsgWindow.DrawMode = DrawMode.Normal;
        }
    }
}
