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
    public partial class StateForm : Form
    {
        public StateForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();//close form
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm newSearchForm = new SearchForm();//create an instance of search form
            newSearchForm.ShowDialog();//show search form
        }

        private void StateForm_Load(object sender, EventArgs e)
        {

            string stateName = SelectStateForm.state;//give string from combo box choice to variable
            //create data context object 
            StatesDataContext db = new StatesDataContext();
            //query flag desc
            var results = from state in db.States
                          where state.StateID.Contains(stateName)
                          select state.FlagDescription;
            //assign results of query to controls
            
            foreach ( var result in results ) 
            {
                flagDescTextBox.Text = result.ToString();
            }
            
            //query state id
             results = from state in db.States
                       where state.StateID.Contains(stateName)
                       select state.StateID;
            //assign results of query to controls

            foreach (var result in results)
            {
                stateIdTextBox.Text = result.ToString();
            }

            //query flower
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.Flower;
            //assign results of query to controls
            
            foreach (var result in results)
            {
                flowerTextBox.Text = result.ToString();
            }

            //query population
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.Population;
            //assign results of query to controls

            foreach (var result in results)
            {
                populationTextBox.Text = result.ToString();
            }

            //query bird
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.Bird;
            //assign results of query to controls

            foreach (var result in results)
            {
                birdTextBox.Text = result.ToString();
            }

            //query capitol
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.Capitol;
            //assign results of query to controls

            foreach (var result in results)
            {
                capitolTextBox.Text = result.ToString();
            }

            //query color
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.Color;
            //assign results of query to controls

            foreach (var result in results)
            {
                if (result == null)
                {
                    colorTextBox.Text = "n/a";
                }
                else
                {
                    colorTextBox.Text = result.ToString();
                }
            }

            //query median income
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.MedianIncome;
            //assign results of query to controls

            foreach (var result in results)
            {
                incomeTextBox.Text = result.ToString();
            }

            //query computer-related jobs
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.ComputerRelatedJobs;
            //assign results of query to controls

            foreach (var result in results)
            {
                jobTextBox.Text = result.ToString();
            }

            //query largest city
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.LargestCity;
            //assign results of query to controls

            foreach (var result in results)
            {
                largTextBox.Text = result.ToString();
            }

            //query second largest city
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.SecondLargestCity;
            //assign results of query to controls

            foreach (var result in results)
            {
                secondLargTextBox.Text = result.ToString();
            }

            //query third largest city
            results = from state in db.States
                      where state.StateID.Contains(stateName)
                      select state.ThirdLargestCity;
            //assign results of query to controls

            foreach (var result in results)
            {
                thirdLargTextBox.Text = result.ToString();
            }
        }
    }
}
