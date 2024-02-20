using System.Data;
using System.Data.SqlClient;

namespace Library_managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textusername_MouseEnter(object sender, EventArgs e)
        {
            if (textusername.Text == "username") ;
            {
                textusername.Clear();
            }
        }

        private void textusername_MouseClick(object sender, MouseEventArgs e)
        {

            if (textusername.Text == "username") ;
            {
                textusername.Clear();
            }
        }

        private void textpassword_MouseClick(object sender, MouseEventArgs e)
        {

            if (textpassword.Text =="password") ;
            {
                textpassword.Clear();
                textpassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-QKQUN34U\\SQLEXPRESS01; database=Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where username ='"+textusername.Text+"' and pass = '"+textpassword.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("wrong username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}