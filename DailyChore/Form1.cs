using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyChore
{
    public partial class DailyChore : Form
    {

        public DailyChore()
        {
            InitializeComponent();
        }

        private void laundryYesButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Great job on the laundry!";

        }

        private void laundryNoButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Quit being lazy on the laundry!";
        }

        private void dishesYesButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Great job on the dishes!";
        }

        private void dishesNoButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Quit being lazy on the dishes!";
        }

        private void clothesYesButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Great job on the clothes!";
        }

        private void clothesNoButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Quit being lazy on the clothes!";
        }

        private void dinnerYesButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Great job on cooking dinner!";
        }

        private void dinnerNoButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = " Quit being lazy on the clothes!";
        }
    }
}
