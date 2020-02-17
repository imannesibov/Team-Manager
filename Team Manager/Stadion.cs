using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Manager
{
    public partial class Stadion : Form
    {  
        

        public void SetPlayerPosition(Point point,int n)
        {
            if (n == 0)
            {
                gk.Location = point;
            }
            else if (n == 1)
            {
                player1.Location = point;
            }
            else if (n == 2)
            {
                player2.Location = point;
            }
            else if (n == 3)
            {
                player3.Location = point;
            }
            else if (n == 4)
            {
                player4.Location = point;
            }
            else if (n == 5)
            {
                player5.Location = point;
            }
            else if (n == 6)
            {
                player6.Location = point;
            }
            else if (n == 7)
            {
                player7.Location = point;
            }
            else if (n == 8)
            {
                player8.Location = point;
            }
            else if (n == 9)
            {
                player9.Location = point;
            }
            else if (n == 10)
            {
                player10.Location = point;
            }
        }
        public void SetNamePosition(Point point, int n)
        {
            if (n == 0)
            {
                gk.Location = point;
            }
            else if (n == 1)
            {
                player1name.Location = point;
            }
            else if (n == 2)
            {
                player2name.Location = point;
            }
            else if (n == 3)
            {
                player3name.Location = point;
            }
            else if (n == 4)
            {
                player4name.Location = point;
            }
            else if (n == 5)
            {
                player5name.Location = point;
            }
            else if (n == 6)
            {
                player6name.Location = point;
            }
            else if (n == 7)
            {
                player7name.Location = point;
            }
            else if (n == 8)
            {
                player8name.Location = point;
            }
            else if (n == 9)
            {
                player9name.Location = point;
            }
            else if (n == 10)
            {
                player10name.Location = point;
            }
        }
        public void SetNumberPosition(Point point, int n)
        {
            if (n == 0)
            {
                numbgk.Location = point;
            }
            else if (n == 1)
            {
                numb1.Location = point;
            }
            else if (n == 2)
            {
                numb2.Location = point;
            }
            else if (n == 3)
            {
                numb3.Location = point;
            }
            else if (n == 4)
            {
                numb4.Location = point;
            }
            else if (n == 5)
            {
                numb5.Location = point;
            }
            else if (n == 6)
            {
                numb6.Location = point;
            }
            else if (n == 7)
            {
                numb7.Location = point;
            }
            else if (n == 8)
            {
                numb8.Location = point;
            }
            else if (n == 9)
            {
                numb9.Location = point;
            }
            else if (n == 10)
            {
                numb10.Location = point;
            }
        }
        public void SetNumber(string number,int n)
        {
            if (n == 0)
            {
                numbgk.Text = number;
            }
            else if (n == 1)
            {
                numb1.Text = number;
            }
            else if (n == 2)
            {
                numb2.Text = number;
            }
            else if (n == 3)
            {
                numb3.Text = number;
            }
            else if (n == 4)
            {
                numb4.Text = number;
            }
            else if (n == 5)
            {
                numb5.Text = number;
            }
            else if (n == 6)
            {
                numb6.Text = number;
            }
            else if (n == 7)
            {
                numb7.Text = number;
            }
            else if (n == 8)
            {
                numb8.Text = number;
            }
            else if (n == 9)
            {
                numb9.Text = number;
            }
            else if (n == 10)
            {
                numb10.Text = number;
            }
        }


        public void SetName(string name, int n)
        {
            if (n == 0)
            {
                gkname.Text = name;
            }
            else if (n == 1)
            {
                player1name.Text = name;
            }
            else if (n == 2)
            {
                player2name.Text = name;
            }
            else if (n == 3)
            {
                player3name.Text = name; 
            }
            else if (n == 4)
            {
                player4name.Text = name;
            }
            else if (n == 5)
            {
                player5name.Text = name;
            }
            else if (n == 6)
            {
                player6name.Text = name;
            }
            else if (n == 7)
            {
                player7name.Text = name;
            }
            else if (n == 8)
            {
                player8name.Text = name;
            }
            else if (n == 9)
            {
                player9name.Text = name;
            }
            else if (n == 10)
            {
                player10name.Text = name;
            }
        }


        public Stadion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Stadion_Load(object sender, EventArgs e)
        {

        }
    }
}
