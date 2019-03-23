using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    interface IMission
    {
        // handles events - notifies listeners
        event EventHandler<double> listeners;  

        String Name { get; }
        String Type { get; }

        double Calculate(double value);

    }
}
