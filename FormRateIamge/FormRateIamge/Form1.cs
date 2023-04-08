using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FormRateIamge
{
    public partial class Form1 : Form
    {
        //gender = 0 -> female
        private string _name = "";
        private string _age = "";
        private int _gender = -1;
        private int _shortSighted = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_gender_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_yes.Checked)
            {
                _shortSighted = 1;
                cb_no.Checked = false;

            }
        }


        private void cb_no_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_no.Checked)
            {
                _shortSighted = 0;
                cb_yes.Checked = false;

            }
        }

        private void cb_female_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_female.Checked)
            {
                _gender = 0;
                cb_male.Checked = false;

            }
        }

        private void cb_male_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_male.Checked)
            {
                _gender = 1;
                cb_female.Checked = false;

            }
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            _name = tb_name.Text;
            _age = tb_age.Text;
            char[] age = _age.ToCharArray();

            if (string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_age) || _gender == -1 || _shortSighted == -1)
            {
                const string title = "Thông báo";
                const string msg = "Bạn phải nhập đủ thông tin";
                MessageBox.Show(msg, title);
            }
            else
            {
                int flag = 0;
                for(int i = 0; i < age.Length; i++)
                {
                    if (age[i] < '0' || age[i] > '9')
                    {
                        const string title = "Thông báo";
                        const string msg = "Bạn phải nhập tuổi là số nguyên";
                        MessageBox.Show(msg, title);
                        flag = 1;
                    }
                }
                if(flag == 0) {
                    User user = new User(_name, _age, _gender, _shortSighted);
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = _name + ".txt";
                    string filePath = Path.Combine(desktopPath, fileName);
                    using (FileStream fs = File.Create(filePath))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(user.displayUser());
                        fs.Write(info, 0, info.Length);
                    }
                }
            }
        }
    }
}