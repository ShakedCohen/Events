using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {

        //func for curr mission
        private Func<double, double> missionFunction;

        private string name;

        public string Name
        { get { return name; } private set { name = value; }
        }

        //define type
        public string Type { get; } = "Single";
        public event EventHandler<double> listeners;
        //ctor
        public SingleMission(Func<double, double> function, string name)
        {
            missionFunction = function;
            this.name = name;
        }

        public double Calculate(double value)
        {
            //calc the new vlaue
            double afterCalc = missionFunction(value);
            //invoke to all listeners, if exists
            listeners?.Invoke(this, afterCalc);
            return afterCalc;
        }
    }
}
