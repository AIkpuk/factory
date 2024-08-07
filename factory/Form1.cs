using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace factory
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();

            int y = 0;
            string v;

            string login = "";
            string password = "";
            User user = new User();

            var result = users.Where(x => x.UserName == login && x.Password == password).FirstOrDefault();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
                "qqq",
                "ewq"
            };


            dataGridView1.DataSource = list;
        }
    }
}
