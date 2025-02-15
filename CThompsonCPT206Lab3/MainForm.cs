using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CThompsonCPT206Lab3
{

    public partial class MainForm : Form
    {

        //private string userSelectedState;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unitedStatesDatabaseDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.unitedStatesDatabaseDataSet.States);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (stateComboBox.SelectedItem != null)//if stateComboBox selected Item is not equal to null 
                {
                    DataRowView Row = stateComboBox.SelectedItem as DataRowView;//DataRowView Row = stateComboBox selectedItem
                    State selectedState = null;

                    if (Row != null)// if there's data in the row 
                    {
                        selectedState = new State //setting my instance variables to specific columns in my database
                        {
                            stateName = Row["name"].ToString(),
                            statePopulation = Convert.ToInt64(Row["population"]),
                            stateFlagDesc = Row["flag_description"].ToString(),
                            stateFlower = Row["flower"].ToString(),
                            stateBird = Row["bird"].ToString(),
                            stateColors = Row["colors"].ToString(),
                            statesThreeLargestCities = Row["threeLargstCities"].ToString(),
                            stateCapital = Row["stateCapital"].ToString(),
                            stateMedianIncome = Convert.ToDecimal(Row["medianInc"]),
                            stateComputerJobPercent = Convert.ToDecimal(Row["computerJobPercent"]),
                        };



                    }
                    StateDetails stateDetailsForm = new StateDetails(selectedState);//declaring an instance for my stateDetailsForm
                    stateDetailsForm.ShowDialog();//displaying the form
                }
            }
            catch(Exception ex)//Catch clause to display exception error message
            {
                MessageBox.Show("Invalid state selection" + ex.Message);
            }
            
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();//closing the form
        }
    }
}
