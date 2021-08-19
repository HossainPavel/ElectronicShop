using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using ElecShop.DataAccess;


namespace ElecShop
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            Userdataaccess ud = new Userdataaccess();
            
            ul.Name = txtName.Text;
            ul.Password = txtPass.Text;
            ul.UserType = comboType.Text;
            int a = ud.AddUser(ul);


            if (a == 1)
            { 
                MessageBox.Show("User Has Been Added");
                txtName.Text = "";
                txtPass.Text = "";
                comboType.Text = "";
            }

            else 
            { MessageBox.Show("User Has Not Been Added"); }

        }

        private void btnBackSignin_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Visible = true;
            this.Visible = false;
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            OptionView OV = new OptionView();
            OV.Visible = true;
           
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
