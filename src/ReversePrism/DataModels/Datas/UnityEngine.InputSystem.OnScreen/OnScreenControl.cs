using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Control                                0001865EB190 ModelClassType InputControl InputControl InputControl Pointer
    // 028 M_NextControlOnDevice                    0001866DBD70 ModelClassType OnScreenControl OnScreenControl OnScreenControl Pointer
    // 030 M_InputEventPtr                          0001865EF0C0 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 000 s_OnScreenDevices                        InlinedArray`1<OnScreenDeviceInfo> IL2CPP_TYPE_GENERICINST
    public partial class OnScreenControl
    {
        public InputControl?                            M_Control                               { get; set; }
        public OnScreenControl?                         M_NextControlOnDevice                   { get; set; }
        public InputEventPtr                            M_InputEventPtr                         { get; set; }

        public static OnScreenControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnScreenControl();

            value.M_Control                                 = GetObject<InputControl>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputControl.FromPointer); // 0270D77BC4B0 0x20 M_Control                   ( 0001865EB190 ModelClassType InputControl InputControl InputControl Pointer )
            value.M_NextControlOnDevice                     = GetObject<OnScreenControl>(new IntPtr(p + 0x028), ReversePrism.DataModels.OnScreenControl.FromPointer); // 0270D77BC4D0 0x28 M_NextControlOnDevice       ( 0001866DBD70 ModelClassType OnScreenControl OnScreenControl OnScreenControl Pointer )
            value.M_InputEventPtr                           = (InputEventPtr)GetInt32(new IntPtr(p + 0x030)); // 0270D77BC4F0 0x30 M_InputEventPtr             ( 0001865EF0C0 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )

            return value;
        }
    }
}
