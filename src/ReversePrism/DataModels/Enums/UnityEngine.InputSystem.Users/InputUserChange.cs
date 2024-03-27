using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum InputUserChange
    {
        Added,
        Removed,
        DevicePaired,
        DeviceUnpaired,
        DeviceLost,
        DeviceRegained,
        AccountChanged,
        AccountNameChanged,
        AccountSelectionInProgress,
        AccountSelectionCanceled,
        AccountSelectionComplete,
        ControlSchemeChanged,
        ControlsChanged,
    }
}
