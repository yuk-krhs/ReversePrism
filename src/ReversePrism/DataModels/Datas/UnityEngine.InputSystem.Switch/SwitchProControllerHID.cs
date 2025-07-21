using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1F0 CaptureButton                            ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1F8 HomeButton                               ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 000 s_HandshakeSequence                      CommandIdType[] IL2CPP_TYPE_SZARRAY
    // 200 M_HandshakeStepIndex                     ModelPrimitiveType int int int Int32
    // 208 M_HandshakeTimer                         ModelPrimitiveType double double double Double
    // 000 JitterMaskLow                            sbyte IL2CPP_TYPE_U1
    // 000 JitterMaskHigh                           sbyte IL2CPP_TYPE_U1
    public partial class SwitchProControllerHID : DataModel
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
            var value   = new SwitchProControllerHID() { Pointer= p0 };

            value.CaptureButton                             = GetObject<ButtonControl>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1F0 CaptureButton               ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.HomeButton                                = GetObject<ButtonControl>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1F8 HomeButton                  ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.M_HandshakeStepIndex                      = GetInt32(new IntPtr(p + 0x200)); // 0x200 M_HandshakeStepIndex        ( ModelPrimitiveType int int int Int32 )
            value.M_HandshakeTimer                          = GetDouble(new IntPtr(p + 0x208)); // 0x208 M_HandshakeTimer            ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
