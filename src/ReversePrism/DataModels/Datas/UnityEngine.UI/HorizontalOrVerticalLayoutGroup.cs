using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_Spacing                                ModelPrimitiveType float float float Single
    // 064 M_ChildForceExpandWidth                  ModelPrimitiveType bool bool bool Bool
    // 065 M_ChildForceExpandHeight                 ModelPrimitiveType bool bool bool Bool
    // 066 M_ChildControlWidth                      ModelPrimitiveType bool bool bool Bool
    // 067 M_ChildControlHeight                     ModelPrimitiveType bool bool bool Bool
    // 068 M_ChildScaleWidth                        ModelPrimitiveType bool bool bool Bool
    // 069 M_ChildScaleHeight                       ModelPrimitiveType bool bool bool Bool
    // 06A M_ReverseArrangement                     ModelPrimitiveType bool bool bool Bool
    public partial class HorizontalOrVerticalLayoutGroup : DataModel
    {
        public float                                    M_Spacing                               { get; set; }
        public bool                                     M_ChildForceExpandWidth                 { get; set; }
        public bool                                     M_ChildForceExpandHeight                { get; set; }
        public bool                                     M_ChildControlWidth                     { get; set; }
        public bool                                     M_ChildControlHeight                    { get; set; }
        public bool                                     M_ChildScaleWidth                       { get; set; }
        public bool                                     M_ChildScaleHeight                      { get; set; }
        public bool                                     M_ReverseArrangement                    { get; set; }

        public static HorizontalOrVerticalLayoutGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HorizontalOrVerticalLayoutGroup() { Pointer= p0 };

            value.M_Spacing                                 = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_Spacing                   ( ModelPrimitiveType float float float Single )
            value.M_ChildForceExpandWidth                   = GetBool(new IntPtr(p + 0x064)); // 0x64 M_ChildForceExpandWidth     ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildForceExpandHeight                  = GetBool(new IntPtr(p + 0x065)); // 0x65 M_ChildForceExpandHeight    ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildControlWidth                       = GetBool(new IntPtr(p + 0x066)); // 0x66 M_ChildControlWidth         ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildControlHeight                      = GetBool(new IntPtr(p + 0x067)); // 0x67 M_ChildControlHeight        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildScaleWidth                         = GetBool(new IntPtr(p + 0x068)); // 0x68 M_ChildScaleWidth           ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildScaleHeight                        = GetBool(new IntPtr(p + 0x069)); // 0x69 M_ChildScaleHeight          ( ModelPrimitiveType bool bool bool Bool )
            value.M_ReverseArrangement                      = GetBool(new IntPtr(p + 0x06A)); // 0x6A M_ReverseArrangement        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
