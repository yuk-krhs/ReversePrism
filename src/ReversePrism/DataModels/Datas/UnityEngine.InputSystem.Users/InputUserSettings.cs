using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CustomBindings                           ModelPrimitiveType string string string String
    // 018 InvertMouseX                             ModelPrimitiveType bool bool bool Bool
    // 019 InvertMouseY                             ModelPrimitiveType bool bool bool Bool
    // 01C <mouseSmoothing>k__BackingField          Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 024 <mouseSensitivity>k__BackingField        Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 02C InvertStickX                             ModelPrimitiveType bool bool bool Bool
    // 02D InvertStickY                             ModelPrimitiveType bool bool bool Bool
    // 02E SwapSticks                               ModelPrimitiveType bool bool bool Bool
    // 02F SwapBumpers                              ModelPrimitiveType bool bool bool Bool
    // 030 SwapTriggers                             ModelPrimitiveType bool bool bool Bool
    // 031 SwapDpadAndLeftStick                     ModelPrimitiveType bool bool bool Bool
    // 034 VibrationStrength                        ModelPrimitiveType float float float Single
    // 038 M_CustomBindings                         ModelPrimitiveType string string string String
    public partial class InputUserSettings : DataModel
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
            var value   = new InputUserSettings() { Pointer= p0 };

            value.CustomBindings                            = GetString(new IntPtr(p + 0x010)); // 0x10 CustomBindings              ( ModelPrimitiveType string string string String )
            value.InvertMouseX                              = GetBool(new IntPtr(p + 0x018)); // 0x18 InvertMouseX                ( ModelPrimitiveType bool bool bool Bool )
            value.InvertMouseY                              = GetBool(new IntPtr(p + 0x019)); // 0x19 InvertMouseY                ( ModelPrimitiveType bool bool bool Bool )
            value.InvertStickX                              = GetBool(new IntPtr(p + 0x02C)); // 0x2C InvertStickX                ( ModelPrimitiveType bool bool bool Bool )
            value.InvertStickY                              = GetBool(new IntPtr(p + 0x02D)); // 0x2D InvertStickY                ( ModelPrimitiveType bool bool bool Bool )
            value.SwapSticks                                = GetBool(new IntPtr(p + 0x02E)); // 0x2E SwapSticks                  ( ModelPrimitiveType bool bool bool Bool )
            value.SwapBumpers                               = GetBool(new IntPtr(p + 0x02F)); // 0x2F SwapBumpers                 ( ModelPrimitiveType bool bool bool Bool )
            value.SwapTriggers                              = GetBool(new IntPtr(p + 0x030)); // 0x30 SwapTriggers                ( ModelPrimitiveType bool bool bool Bool )
            value.SwapDpadAndLeftStick                      = GetBool(new IntPtr(p + 0x031)); // 0x31 SwapDpadAndLeftStick        ( ModelPrimitiveType bool bool bool Bool )
            value.VibrationStrength                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 VibrationStrength           ( ModelPrimitiveType float float float Single )
            value.M_CustomBindings                          = GetString(new IntPtr(p + 0x038)); // 0x38 M_CustomBindings            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
