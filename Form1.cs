using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingGame
{
    public partial class Form1 : Form
    {
        int increment = 0;
        int firstpicnumber, spicnumber;

        public Form1()
        {
            InitializeComponent();
            Random rand=new Random();
            int num = rand.Next(1, 17);
            btnpic.Image = Image.FromFile(@"E:\Afzal's Data\Local Disk\5th_Semester\Visual_Programming( C Sharp )\Images\candy" + num + ".jpg");
            btnpic.ImageAlign = ContentAlignment.MiddleRight;
            firstpicnumber = num;
            btnpic.FlatStyle = FlatStyle.Flat;
        }
        int counter = 0;
        private void click_button(object sender, EventArgs e)
        {
            if(increment < 3)
            {
                Random random = new Random();
                Button b = (Button)sender;
                int num = random.Next(1, 17);
                b.Image = Image.FromFile(@"E:\Afzal's Data\Local Disk\5th_Semester\Visual_Programming( C Sharp )\Images\candy" + num + ".jpg");
                spicnumber = num;
                b.ImageAlign = ContentAlignment.MiddleRight;
                b.FlatStyle = FlatStyle.Flat;
                increment += 1;
                if(firstpicnumber == spicnumber)
                {
                    counter ++;
                    if(counter==3)
                    {
                        MessageBox.Show("You Won");
                    }
                }
            }
            else
            {
                MessageBox.Show("Out of Limit ");
                MessageBox.Show("You Lost");
               
            }
        }
    }
}
