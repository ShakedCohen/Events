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

        public Func<double, double> this[string funcName]
        {
            get
            {
                //if the function exist in the missions list, return it
                if (missions.Keys.Any(keyName => keyName == funcName))
                {
                    return missions[funcName];
                }
                //else return function that returns the value without any change (id function)
                else
                {
                    missions.Add(funcName, val => val);
                    return missions[funcName];
                }
            }
            set
            {
                missions[funcName] = value;
            }
        }
        //returns all keys from func container
        public List<string> getAllMissions()
        {
            var allKeys = missions.Keys;
            List<string> list = new List<string>();
            foreach (var key in allKeys)
            {
                list.Add(key);
            }
            return list;
        }

    }
}
