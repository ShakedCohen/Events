using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class FunctionsContainer
    {
        //dictionary betweens keys and functions
        Dictionary<string, Func<double, double>> missions = new Dictionary<string, Func<double, double>>();

        public Func<double, double> this[string key]
        {
            get
            {
                //if the function exist in the missions list, return it
                if (missions.Keys.Any(keyName => keyName == key))
                {
                    return missions[key];
                }
                //else return function that returns the value without any change (id function)
                else
                {
                    missions.Add(key, val => val);
                    return missions[key];
                }
            }
            set
            {
                missions[key] = value;
            }
        }
        //returns all keys from func container
        public List<string> getAllMissions()
        {
            return missions.Keys.ToList();
        }

    }
}
