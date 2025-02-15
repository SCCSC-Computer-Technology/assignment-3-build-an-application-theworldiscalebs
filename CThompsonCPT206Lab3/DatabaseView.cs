using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CThompsonCPT206Lab3
{
    public partial class DatabaseView : Form
    {
        public DatabaseView()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.unitedStatesDatabaseDataSet);

        }

        private void DatabaseView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unitedStatesDatabaseDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.unitedStatesDatabaseDataSet.States);

        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();//Closing the Form
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.statesTableAdapter.SearchByName(this.unitedStatesDatabaseDataSet.States, userEnteredStateNameTB.Text);//Calling created sql query for search mechanism
        }

        private void ShowAllBtn_Click_1(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.unitedStatesDatabaseDataSet.States);
        }
    }
}
