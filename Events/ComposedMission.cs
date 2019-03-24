using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class ComposedMission : IMission
    {
        //holds the functions to apply
        //no need to use command pattern when we can simply hold a list, but the imp is pretty obvious
        private List<Func<double, double>> funcsList = new List<Func<double, double>>();
        private string name;

        public event EventHandler<double> listeners;
        //define type
        public string Type { get; } = "Composed";

        public ComposedMission(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        //add func to composed. supports builder pattern
        public ComposedMission Add(Func<double, double> func)
        {
            funcsList.Add(func);
            return this;
        }

        public double Calculate(double appliedValue)
        {
            //loops on list and applies all functions - from start to end
            foreach (var func in funcsList)
            {
                appliedValue = func(appliedValue);
            }
            //invoke listeners
            listeners?.Invoke(this, appliedValue);
            return appliedValue;
        }
    }
}
