using System;
using System.IO;
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
    public partial class StateDetails : Form
    {
        private State selectedState;//declaring selectedState variable 
        Dictionary<string, string> stateFlags = new Dictionary<string, string>//Dictionary to set specific state names with their appropriate state flags
        {
            { "Alabama", "Alabama.jpeg"},
            {"Alaska", "AlaskasFlag.jpg"},
            {"Arizona","Arizona.jpeg"},
            {"Arkansas","Arkansas.jpeg"},
            {"California","California.jpeg"},
            {"Colorado","Colorado.jpeg"},
            {"Connecticut","Connecticut.jpeg"},
            {"Delaware","Delaware.jpeg"},
            {"Florida","Florida.jpeg"},
            {"Georgia", "Georgia.jpeg"},
            {"Hawaii", "Hawaii.jpeg"},
            {"Idaho","idaho.jpg"},
            {"Illinois","Illinois.jpeg"},
            {"Indiana","Indiana.jpeg"},
            {"Iowa","Iowa.jpg"},
            {"Kansas", "Kansas.jpg"},
            {"Kentucky", "Kentucky.jpg"},
            {"Louisiana","Louisiana.jpeg"},
            {"Maine", "Maine.jpeg"},
            {"Maryland","Maryland.jpg"},
            {"Massachusetts","Massachusetts.jpeg"},
            {"Michigan", "Michigan.jpeg"},
            {"Minnesota", "Minnesota.jpeg"},
            {"Mississippi", "Mississippi.jpeg"},
            {"Montana", "Montana.jpeg"},
            {"Nebraska", "Nebraska.jpeg"},
            {"Nevada", "Nevada.jpg"},
            {"New Hampshire", "New Hampshire.jpeg"},
            {"New Jersey ", "New Jersey.jpg"},
            {"New Mexico","New Mexico.jpeg"},
            {"New York", "New York.jpeg" },
            {"North Carolina", "North Carolina.jpg"},
            {"North Dakota","North Dakota.jpg" },
            {"Ohio", "Ohio.jpeg" },
            {"Oklahoma","Oklahoma.jpeg"},
            {"Oregon","Oregon.jpeg" },
            {"Pennsylvania","Pennsylvania.jpg" },
            {"Rhode Island","Rhode Island.jpg" },
            {"South Carolina","South Carolina.jpg" },
            {"South Dakota","South Dakota.jpg" },
            {"Tennessee","Tennessee.jpg" },
            {"Texas", "Texas.jpeg" },
            {"Utah","Utah.jpg" },
            {"Vermont","Vermont.jpeg" },
            {"Virginia","Virginia.jpeg" },
            {"Washington", "Washington.jpg" },
            {"West Virginia","West Virginia.jpg" },
            {"Wisconsin","Wisconsin.jpg" },
            {"Wyoming","Wyoming.jpeg"}
        };



        public StateDetails(State stateDetails)
        {
            InitializeComponent();
            selectedState = stateDetails;//setting selectedState to stateDetails

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();//closing the form 
        }

        private void StateDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (selectedState != null) // if selectedState is not equal to null
                {
                    //Setting Label Text 
                    stateNameLabel.Text = selectedState.stateName;
                    statePopulationLabel.Text = selectedState.statePopulation.ToString("n");
                    stateFlagDescLabel.Text = selectedState.stateFlagDesc;
                    stateFlowerLabel.Text = selectedState.stateFlower;
                    stateBirdLabel.Text = selectedState.stateBird;
                    stateColorLabel.Text = selectedState.stateColors;
                    threeLargestCitiesLabel.Text = selectedState.statesThreeLargestCities;
                    stateCapitalLabel.Text = selectedState.stateCapital;
                    stateMedianIncomeLabel.Text = selectedState.stateMedianIncome.ToString("C");
                    computerRelatedJobPercentLabel.Text = selectedState.stateComputerJobPercent.ToString("n") + "%";

                    //If statement that deploys the stateFlags
                    if (stateFlags.TryGetValue(selectedState.stateName, out string flagFileName))
                    {
                        string flagFilePath = Path.Combine(Application.StartupPath, "Flag Images", flagFileName);
                        if (File.Exists(flagFilePath))
                        {
                            stateFlag.Image = Image.FromFile(flagFilePath);
                        }
                        else
                        {
                            MessageBox.Show("Flag file not found: " + flagFilePath);
                        }
                    }

                }
            }
            catch(Exception ex)//Exception Handler
            {
                MessageBox.Show("Error"+ex.Message);
            }
            
        }

        private void databaseViewBtn_Click(object sender, EventArgs e)
        {
            DatabaseView databaseViewForm = new DatabaseView();//Declaring the databaseviewForm
            databaseViewForm.ShowDialog();//Opening Form
        }
    }
}
