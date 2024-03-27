using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CustomBindings                           000186671910 ModelPrimitiveType string string string String
    // 018 InvertMouseX                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 InvertMouseY                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C <mouseSmoothing>k__BackingField          Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 024 <mouseSensitivity>k__BackingField        Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 02C InvertStickX                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D InvertStickY                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02E SwapSticks                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02F SwapBumpers                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 SwapTriggers                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 SwapDpadAndLeftStick                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 VibrationStrength                        0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_CustomBindings                         000186671910 ModelPrimitiveType string string string String
    public partial class InputUserSettings
    {
        public string                                   CustomBindings                          { get; set; }
        public bool                                     InvertMouseX                            { get; set; }
        public bool                                     InvertMouseY                            { get; set; }
        public bool                                     InvertStickX                            { get; set; }
        public bool                                     InvertStickY                            { get; set; }
        public bool                                     SwapSticks                              { get; set; }
        public bool                                     SwapBumpers                             { get; set; }
        public bool                                     SwapTriggers                            { get; set; }
        public bool                                     SwapDpadAndLeftStick                    { get; set; }
        public float                                    VibrationStrength                       { get; set; }
        public string                                   M_CustomBindings                        { get; set; }

        public static InputUserSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputUserSettings();

            value.CustomBindings                            = GetString(new IntPtr(p + 0x010)); // 0270D779BFC8 0x10 CustomBindings              ( 000186671910 ModelPrimitiveType string string string String )
            value.InvertMouseX                              = GetBool(new IntPtr(p + 0x018)); // 0270D779BFE8 0x18 InvertMouseX                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InvertMouseY                              = GetBool(new IntPtr(p + 0x019)); // 0270D779C008 0x19 InvertMouseY                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InvertStickX                              = GetBool(new IntPtr(p + 0x02C)); // 0270D779C068 0x2C InvertStickX                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InvertStickY                              = GetBool(new IntPtr(p + 0x02D)); // 0270D779C088 0x2D InvertStickY                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwapSticks                                = GetBool(new IntPtr(p + 0x02E)); // 0270D779C0A8 0x2E SwapSticks                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwapBumpers                               = GetBool(new IntPtr(p + 0x02F)); // 0270D779C0C8 0x2F SwapBumpers                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwapTriggers                              = GetBool(new IntPtr(p + 0x030)); // 0270D779C0E8 0x30 SwapTriggers                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwapDpadAndLeftStick                      = GetBool(new IntPtr(p + 0x031)); // 0270D779C108 0x31 SwapDpadAndLeftStick        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VibrationStrength                         = GetSingle(new IntPtr(p + 0x034)); // 0270D779C128 0x34 VibrationStrength           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CustomBindings                          = GetString(new IntPtr(p + 0x038)); // 0270D779C148 0x38 M_CustomBindings            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
