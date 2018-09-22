using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    public class MyList
    {
        private string[] _data;

        public MyList(int listSize)
        {
            _data = new string[listSize];
        }

        /// <summary>
        /// Add a value to the list
        /// </summary>
        /// <param name="value">The value to be added</param>
        /// <returns>True if successful, false if not</returns>
        public bool Add(string value)
        {
            // Initial Condition
            int i = 0;

            // Test n condition
            while (i < _data.Length && !string.IsNullOrWhiteSpace(_data[i]))
            {
                // Change in condition
                i++;
            }
            // Check to make sure we're not at the end of the list
            if (i != _data.Length)
            {
                // Add the value to the empty location
                _data[i] = value;
                return true;
            }
            // If it's full, return false
            else
            {
                return false;
            }
            
        }

        public string Get(int i)
        {

            if (i < _data.Length)
            {
                return _data[i];
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            string s = "";
            int i = 0;

            while (i < _data.Length && !string.IsNullOrEmpty(_data[i]))
            {
                s += (_data[i] + ", ");
                i++;
            }

            return s;
        }

        public int Contains(string value)
        {
            bool found = false;
            // Loop through the list until the end or the value is found
            int i = 0;
            while (!found && i < _data.Length)
            {
                // If equal, set found to true
                if (_data[i] == value)
                {
                    found = true;
                }
                // Otherwise, increment the counter
                else
                {
                    i++;
                }
            }

            // If found, return the location it was found
            if (found)
            {
                return i;
            }
            // If not, return a negative number
            else
            {
                return -1;
            }
        }
    }
}
