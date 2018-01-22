﻿using System.Collections.Generic;

namespace Demo_TheTravelingSalesperson
{
    /// <summary>
    /// Salesperson MVC Model class
    /// </summary>
    public class Salesperson
    {
        #region FIELDS

        private string _firstName;
        private string _lastName;
        private string _accountID;
        private List<string> _citiesVisited;

        #endregion
        
        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }
      
        public List<string> CitiesVisited
        {
            get { return _citiesVisited; }
            set { _citiesVisited = value; }
        }

        #endregion
        
        #region CONSTRUCTORS

        public Salesperson()
        {
            _citiesVisited = new List<string>();
        }

        public Salesperson(string firstName, string lastName, string acountID)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountID = acountID;

            _citiesVisited = new List<string>();
        }

        #endregion
        
        #region METHODS



        #endregion
    }
}
