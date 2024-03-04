using System;
using System.Windows.Forms;

namespace Employee_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchName(this.employeeDataSet.Employee, searchTextBox.Text);
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
