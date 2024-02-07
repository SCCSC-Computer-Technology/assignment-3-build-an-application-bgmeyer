using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BroecklynneMeyer_CPT_206_Assignment3
{
    public partial class SelectStateForm : Form
    {
        public SelectStateForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();//close this form
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm newSearchForm = new SearchForm();//create instance of search form
            newSearchForm.ShowDialog();//open search form
        }
        public static string state;

        private void stateInfoButton_Click(object sender, EventArgs e)
        {
            if (stateComboBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Error! Please select a state to view information about.");//error message if no state has been selected
            }
            else
            {
                object s = stateComboBox.SelectedItem;//give selected state to public variable
                state = Convert.ToString(s);
                StateForm newStateForm = new StateForm();//create instance of state form
                newStateForm.ShowDialog();//open state form
                
            }

        }

        private void SelectStateForm_Load(object sender, EventArgs e)
        {
            //create data context object
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States//query to get state ids to populate combo box
                          select state.StateID;
            foreach ( var state in results ) 
            {
                stateComboBox.Items.Add(state);
            }
        }
    }
}
