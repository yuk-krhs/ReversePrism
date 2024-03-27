using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 238 LeftTriggerButton                        0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 240 RightTriggerButton                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 248 PlayStationButton                        0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 250 m_LowFrequencyMotorSpeed                 Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 258 m_HighFrequenceyMotorSpeed               Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 260 m_LightBarColor                          Nullable`1<Color> IL2CPP_TYPE_GENERICINST
    // 274 OutputSequenceId                         00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 000 JitterMaskLow                            sbyte IL2CPP_TYPE_U1
    // 000 JitterMaskHigh                           sbyte IL2CPP_TYPE_U1
    public partial class DualSenseGamepadHID
    {
        public ButtonControl?                           LeftTriggerButton                       { get; set; }
        public ButtonControl?                           RightTriggerButton                      { get; set; }
        public ButtonControl?                           PlayStationButton                       { get; set; }
        public sbyte                                    OutputSequenceId                        { get; set; }

        public static DualSenseGamepadHID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualSenseGamepadHID();

            value.LeftTriggerButton                         = GetObject<ButtonControl>(new IntPtr(p + 0x238), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D8BD0 0x238 LeftTriggerButton           ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightTriggerButton                        = GetObject<ButtonControl>(new IntPtr(p + 0x240), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D8BF0 0x240 RightTriggerButton          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.PlayStationButton                         = GetObject<ButtonControl>(new IntPtr(p + 0x248), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D8C10 0x248 PlayStationButton           ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.OutputSequenceId                          = GetSByte(new IntPtr(p + 0x274)); // 0270033D8C90 0x274 OutputSequenceId            ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
