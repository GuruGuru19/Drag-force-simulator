using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DargSim1
{
    public partial class Form1 : Form
    {
        private bool CheckIsFilled()
        {
            button_Reset.Enabled = textBox_Diameter.Text != "" || textBox_Mass.Text != "" ||
                textBox_Angle.Text != "" || textBox_Velocity.Text != "" || textBox_Hight.Text != "" ||
                listBox_Dt.SelectedItem != null;
            try
            {
                Convert.ToDouble(textBox_Diameter.Text);
                Convert.ToDouble(textBox_Mass.Text);
                Convert.ToDouble(textBox_Angle.Text);
                Convert.ToDouble(textBox_Velocity.Text);
                Convert.ToDouble(textBox_Hight.Text);
                return listBox_Dt.SelectedItem != null;
            }
            catch (System.FormatException)
            {
                return false;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            Trajectory trajectory = new Trajectory(Convert.ToDouble(textBox_Diameter.Text), Convert.ToDouble(textBox_Mass.Text),
                Convert.ToDouble(textBox_Angle.Text), Convert.ToDouble(textBox_Velocity.Text), Convert.ToDouble(textBox_Hight.Text),
                Convert.ToDouble(numeric_Time.Value), Convert.ToDouble(listBox_Dt.SelectedItem));
            trajectory.DrawTrajectory(chart1.Series[0].Points);
            if (checkBox_ShowNoDrag.Checked==true)
            {
                Trajectory trajectory2 = new Trajectory(0, 1,
                Convert.ToDouble(textBox_Angle.Text), Convert.ToDouble(textBox_Velocity.Text), Convert.ToDouble(textBox_Hight.Text),
                Convert.ToDouble(numeric_Time.Value), Convert.ToDouble(listBox_Dt.SelectedItem));
                trajectory2.DrawTrajectory(chart1.Series[1].Points);
            }
             
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {

        }

        private void button_Stop_Click(object sender, EventArgs e)
        {

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            button_Reset.Enabled = false;
            textBox_Diameter.Text = "";
            textBox_Mass.Text = "";
            textBox_Angle.Text = "";
            textBox_Velocity.Text = "";
            textBox_Hight.Text = "";
            listBox_Dt.SelectedItem = null;
            numeric_Time.Value = Decimal.Parse("1.0");
            checkBox_ShowNoDrag.Checked = false;
        }

        private void listBox_Dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();
        }

        private void numeric_Time_ValueChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();
        }

        private void checkBox_ShowNoDrag_CheckedChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();
        }

        private void textBox_Diameter_TextChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled(); 
        }

        private void textBox_Mass_TextChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();

        }

        private void textBox_Angle_TextChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();
        }

        private void textBox_Velocity_TextChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();
        }

        private void textBox_Hight_TextChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = CheckIsFilled();
        }
    }
}
