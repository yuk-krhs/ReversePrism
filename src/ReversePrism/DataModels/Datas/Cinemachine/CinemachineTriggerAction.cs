using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_LayerMask                              ModelEnumType LayerMask LayerMask LayerMask Int32
    // 028 M_WithTag                                ModelPrimitiveType string string string String
    // 030 M_WithoutTag                             ModelPrimitiveType string string string String
    // 038 M_SkipFirst                              ModelPrimitiveType int int int Int32
    // 03C M_Repeating                              ModelPrimitiveType bool bool bool Bool
    // 040 M_OnObjectEnter                          ModelEnumType ActionSettings ActionSettings ActionSettings Int32
    // 068 M_OnObjectExit                           ModelEnumType ActionSettings ActionSettings ActionSettings Int32
    // 090 m_ActiveTriggerObjects                   HashSet`1<GameObject> IL2CPP_TYPE_GENERICINST
    public partial class CinemachineTriggerAction : DataModel
    {
        public LayerMask                                M_LayerMask                             { get; set; }
        public string                                   M_WithTag                               { get; set; }
        public string                                   M_WithoutTag                            { get; set; }
        public int                                      M_SkipFirst                             { get; set; }
        public bool                                     M_Repeating                             { get; set; }
        public ActionSettings                           M_OnObjectEnter                         { get; set; }
        public ActionSettings                           M_OnObjectExit                          { get; set; }

        public static CinemachineTriggerAction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineTriggerAction() { Pointer= p0 };

            value.M_LayerMask                               = (LayerMask)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_LayerMask                 ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_WithTag                                 = GetString(new IntPtr(p + 0x028)); // 0x28 M_WithTag                   ( ModelPrimitiveType string string string String )
            value.M_WithoutTag                              = GetString(new IntPtr(p + 0x030)); // 0x30 M_WithoutTag                ( ModelPrimitiveType string string string String )
            value.M_SkipFirst                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_SkipFirst                 ( ModelPrimitiveType int int int Int32 )
            value.M_Repeating                               = GetBool(new IntPtr(p + 0x03C)); // 0x3C M_Repeating                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_OnObjectEnter                           = (ActionSettings)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_OnObjectEnter             ( ModelEnumType ActionSettings ActionSettings ActionSettings Int32 )
            value.M_OnObjectExit                            = (ActionSettings)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_OnObjectExit              ( ModelEnumType ActionSettings ActionSettings ActionSettings Int32 )

            return value;
        }
    }
}
