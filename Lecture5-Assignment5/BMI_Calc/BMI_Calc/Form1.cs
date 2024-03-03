using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMI_Calc
{
    public partial class Form1 : Form
    {
        private double bmi;
        private int height;
        private int weight;
        private string gender;
        private DateTime calcTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void cacluate_click(object sender, EventArgs e)
        {
            weight = (int)weight_input.Value;
            height = (int)height_input.Value;
            gender = gender_input.Text;
            double gender_modifier = gender == "Male" ? 1.6 : 1.4;
            bmi = (weight / Math.Pow(height, 2)) * 250 * gender_modifier;
            calcTime = DateTime.Now;

            bmi_output.Text = bmi.ToString();
        }

        private void save_click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\Database1.mdf;Integrated Security=True");
            conn.Open();
            string sql = "INSERT INTO EnhancedBMI(Gender, Weight, Height, EnhancedBMI, DateTimeStamp) VALUES(@gender,@weight,@height,@bmi,@date)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@gender", SqlDbType.VarChar, 20).Value = gender;
                cmd.Parameters.Add("@weight", SqlDbType.Int).Value = weight;
                cmd.Parameters.Add("@height", SqlDbType.Int).Value = height;
                cmd.Parameters.Add("@bmi", SqlDbType.Float).Value = bmi;
                cmd.Parameters.Add("@date", SqlDbType.DateTime2).Value = calcTime;
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "SQL Error");
                }
                
            }
            conn.Close();
        }
    }
}
