using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum UsagePage
    {
        Undefined,
        GenericDesktop,
        Simulation,
        VRControls,
        SportControls,
        GameControls,
        GenericDeviceControls,
        Keyboard,
        LEDs,
        Button,
        Ordinal,
        Telephony,
        Consumer,
        Digitizer,
        PID,
        Unicode,
        AlphanumericDisplay,
        MedicalInstruments,
        Monitor,
        Power,
        BarCodeScanner,
        MagneticStripeReader,
        Camera,
        Arcade,
        VendorDefined,
    }
}
