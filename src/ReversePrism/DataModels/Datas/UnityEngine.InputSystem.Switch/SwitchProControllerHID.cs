using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1F0 CaptureButton                            0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1F8 HomeButton                               0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 000 s_HandshakeSequence                      CommandIdType[] IL2CPP_TYPE_SZARRAY
    // 200 M_HandshakeStepIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 208 M_HandshakeTimer                         0001865C2950 ModelPrimitiveType double double double Double
    // 000 JitterMaskLow                            sbyte IL2CPP_TYPE_U1
    // 000 JitterMaskHigh                           sbyte IL2CPP_TYPE_U1
    public partial class SwitchProControllerHID
    {
        public ButtonControl?                           CaptureButton                           { get; set; }
        public ButtonControl?                           HomeButton                              { get; set; }
        public int                                      M_HandshakeStepIndex                    { get; set; }
        public double                                   M_HandshakeTimer                        { get; set; }

        public static SwitchProControllerHID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchProControllerHID();

            value.CaptureButton                             = GetObject<ButtonControl>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270034976A8 0x1F0 CaptureButton               ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.HomeButton                                = GetObject<ButtonControl>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270034976C8 0x1F8 HomeButton                  ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.M_HandshakeStepIndex                      = GetInt32(new IntPtr(p + 0x200)); // 027003497708 0x200 M_HandshakeStepIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_HandshakeTimer                          = GetDouble(new IntPtr(p + 0x208)); // 027003497728 0x208 M_HandshakeTimer            ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
