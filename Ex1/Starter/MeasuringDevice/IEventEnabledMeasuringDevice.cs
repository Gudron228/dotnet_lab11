using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuringDevice
{
    interface IEventEnabledMeasuringDevice: IMeasuringDevice
    {
        event EventHandler NewMeasurementTaken;
    }
}
