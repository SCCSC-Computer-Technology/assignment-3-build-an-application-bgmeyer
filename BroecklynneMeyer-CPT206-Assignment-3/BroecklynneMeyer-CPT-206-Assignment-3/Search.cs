using BroecklynneMeyer_CPT_206_Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BroecklynneMeyer_CPT_206_Assignment_3
{
    public class Search
    {
        public void SearchState(string criteria)
        {
            SearchForm form = new SearchForm();
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.StateID.Contains(criteria)
                          select state;
            form.stateDataGridView.DataSource = results;
        }
    }
}
