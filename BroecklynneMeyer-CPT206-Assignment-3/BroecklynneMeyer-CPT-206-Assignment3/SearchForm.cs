using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BroecklynneMeyer_CPT_206_Assignment3
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //create data context object
            StatesDataContext db = new StatesDataContext();
            //get all state objects from the states collection quer
            var results = from state in db.States
                          select state;
            //assign results of query to DataGridView control
            stateDataGridView.DataSource = results;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//close the form
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear form
            SearchForm newSearchForm = new SearchForm();
            newSearchForm.Show();
            this.Dispose(false);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Error! Please enter a search criteria.");//empty text box error
            }
            else
            { 
                string criteria = searchTextBox.Text;//initialize variable with search criteria from text box
                
                if (stateRadioButton.Checked) //check if state radio button checked
                {
                    SearchState(criteria);//call method to search state
                }
                else if (populationRadioButton.Checked)//check if population radio button checked  
                {
                    SearchPopulation(criteria);//call method to search population
                }
                else if (flowerRadioButton.Checked)//check if flower radio button checked  
                {
                    SearchFlower(criteria);//call method to search flower
                }
                else if (birdRadioButton.Checked)//check if bird radio button checked  
                {
                    SearchBird(criteria);//call method to search bird
                }
                else if (capitolRadioButton.Checked)//check if capitol radio button checked  
                {
                    SearchCapitol(criteria);//call method to search capitol
                }
                else if (flagDescRadioButton.Checked)//check if flag desc radio button checked  
                {
                    SearchFlagDesc(criteria);//call method to search flag desc
                }
                else if (colorRadioButton.Checked)//check if color radio button checked  
                {
                    SearchColor(criteria);//call method to search color
                }
                else if (incomeRadioButton.Checked)//check if income radio button checked  
                {
                    SearchIncome(criteria);//call method to search income
                }
                else if (jobRadioButton.Checked)//check if computer jobs radio button checked  
                {
                    SearchJobs(criteria);//call method to search jobs
                }
                else if (largestRadioButton.Checked)//check if largest city radio button checked  
                {
                    SearchLargCity(criteria);//call method to search largest city
                }
                else if (secondLargRadioButton.Checked)//check if second largest city radio button checked  
                {
                    SearchSecondLarg(criteria);//call method to search second largest city
                }
                else if (thirdLargRadioButton.Checked)//check if third largest city radio button checked  
                {
                    SearchThirdLarg(criteria);//call method to search third largest city
                }
                else
                {
                    MessageBox.Show("Error! Please select a column to search and try again.");
                }
            }
        }

        private void ascendingButton_Click(object sender, EventArgs e)
        {
            if (sortStateRadioButton.Checked) //check if sort state radio button checked
            {
                SortAscendStateID();//call method to sort state ascending
            }
            else if (sortPopulationRadioButton.Checked)//check if sort population radio button checked  
            {
                SortAscendPopulation();//call method to sort population ascending
            }
            else if (sortFlowerRadioButton.Checked)//check if sort flower radio button checked  
            {
                SortAscendFlower();//call method to sort flower ascending
            }
            else if (sortBirdRadioButton.Checked)//check if sort bird radio button checked  
            {
                SortAscendBird();//call method to sort bird ascending
            }
            else if (sortCapitolRadioButton.Checked)//check if sort capitol radio button checked  
            {
                SortAscendCapitol();//call method to sort capitol ascending
            }
            else if (sortFlagDescRadioButton.Checked)//check if sort flag desc radio button checked  
            {
                SortAscendFlagDesc();//call method to sort flag desc ascending
            }
            else if (sortColorRadioButton.Checked)//check if sort color radio button checked  
            {
                SortAscendColor();//call method to sort color ascending
            }
            else if (sortIncomeRadioButton.Checked)//check if sort income radio button checked  
            {
                SortAscendIncome();//call method to sort income ascending
            }
            else if (sortJobRadioButton.Checked)//check if sort computer jobs radio button checked  
            {
                SortAscendJobs();//call method to sort jobs ascending
            }
            else if (sortLargRadioButton.Checked)//check if sort largest city radio button checked  
            {
                SortAscendLargCity();//call method to sort largest city ascending
            }
            else if (sortSecondLargRadioButton.Checked)//check if sort second largest city radio button checked  
            {
                SortAscendSecondLarg();//call method to sort second largest city ascending
            }
            else if (sortThirdLargRadioButton.Checked)//check if sort third largest city radio button checked  
            {
                SortAscendThirdLarg();//call method to sort third largest city ascending
            }
            else
            {
                MessageBox.Show("Error! Please select a column to sort and try again.");
            }


        }

        private void descendingButton_Click(object sender, EventArgs e)
        {
            if (sortStateRadioButton.Checked) //check if sort state radio button checked
            {
                SortDescStateID();//call method to sort state descending

            }
            else if (sortPopulationRadioButton.Checked)//check if sort population radio button checked  
            {
                SortDescPopulation();//call method to sort population descending
            }
            else if (sortFlowerRadioButton.Checked)//check if sort flower radio button checked  
            {
                SortDescFlower();//call method to sort flower descending
            }
            else if (sortBirdRadioButton.Checked)//check if sort bird radio button checked  
            {
                SortDescBird();//call method to sort bird descending
            }
            else if (sortCapitolRadioButton.Checked)//check if sort capitol radio button checked  
            {
                SortDescCapitol();//call method to sort capitol descending
            }
            else if (sortFlagDescRadioButton.Checked)//check if sort flag desc radio button checked  
            {
                SortDescFlagDesc();//call method to sort flag desc descending
            }
            else if (sortColorRadioButton.Checked)//check if sort color radio button checked  
            {
                SortDescColor(); //call method to sort color descending
            }
            else if (sortIncomeRadioButton.Checked)//check if sort income radio button checked  
            {
                SortDescIncome();//call method to sort income descending
            }
            else if (sortJobRadioButton.Checked)//check if sort computer jobs radio button checked  
            {
                SortDescJobs();//call method to sort jobs descending
            }
            else if (sortLargRadioButton.Checked)//check if sort largest city radio button checked  
            {
                SortDescLargCity();//call method to sort largest city descending
            }
            else if (sortSecondLargRadioButton.Checked)//check if sort second largest city radio button checked  
            {
                SortDescSecondLarg();//call method to sort second largest city descending
            }
            else if (sortThirdLargRadioButton.Checked)//check if sort third largest city radio button checked  
            {
                SortDescendThirdLarg();//call method to sort third largest city descending
            }
            else
            {
                MessageBox.Show("Error! Please select a column to sort and try again.");
            }
        }

        public void SortAscendStateID()
        { 
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.StateID
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescStateID()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.StateID descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendPopulation()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Population
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescPopulation()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Population descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendFlower()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Flower
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescFlower()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Flower descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendBird()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Bird
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescBird()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Bird descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendCapitol()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Capitol
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescCapitol()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Capitol descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendFlagDesc()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.FlagDescription
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescFlagDesc()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.FlagDescription descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendColor()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Color
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescColor()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Color descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendIncome()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.MedianIncome
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescIncome()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.MedianIncome descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendJobs()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ComputerRelatedJobs
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescJobs()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ComputerRelatedJobs descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendLargCity()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.LargestCity
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescLargCity()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.LargestCity descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendSecondLarg()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.SecondLargestCity
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescSecondLarg()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.SecondLargestCity descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortAscendThirdLarg()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ThirdLargestCity
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SortDescendThirdLarg()
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ThirdLargestCity descending
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchState(string criteria)
        { 
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.StateID.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchPopulation(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Population.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchFlower(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Flower.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchBird(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Bird.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchCapitol(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Capitol.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchFlagDesc(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.FlagDescription.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchColor(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Color.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchIncome(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.MedianIncome.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchJobs(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.ComputerRelatedJobs.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchLargCity(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.LargestCity.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchSecondLarg(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.SecondLargestCity.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }

        public void SearchThirdLarg(string criteria)
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.ThirdLargestCity.Contains(criteria)
                          select state;
            stateDataGridView.DataSource = results;
        }



        private void stateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
