using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_Spacing                                000186665B50 ModelPrimitiveType float float float Single
    // 064 M_ChildForceExpandWidth                  000186595480 ModelPrimitiveType bool bool bool Bool
    // 065 M_ChildForceExpandHeight                 000186595480 ModelPrimitiveType bool bool bool Bool
    // 066 M_ChildControlWidth                      000186595480 ModelPrimitiveType bool bool bool Bool
    // 067 M_ChildControlHeight                     000186595480 ModelPrimitiveType bool bool bool Bool
    // 068 M_ChildScaleWidth                        000186595480 ModelPrimitiveType bool bool bool Bool
    // 069 M_ChildScaleHeight                       000186595480 ModelPrimitiveType bool bool bool Bool
    // 06A M_ReverseArrangement                     000186595480 ModelPrimitiveType bool bool bool Bool
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

            value.M_Spacing                                 = GetSingle(new IntPtr(p + 0x060)); // 0245A3F9AD80 0x60 M_Spacing                   ( 000186665B50 ModelPrimitiveType float float float Single )
            value.M_ChildForceExpandWidth                   = GetBool(new IntPtr(p + 0x064)); // 0245A3F9ADA0 0x64 M_ChildForceExpandWidth     ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ChildForceExpandHeight                  = GetBool(new IntPtr(p + 0x065)); // 0245A3F9ADC0 0x65 M_ChildForceExpandHeight    ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ChildControlWidth                       = GetBool(new IntPtr(p + 0x066)); // 0245A3F9ADE0 0x66 M_ChildControlWidth         ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ChildControlHeight                      = GetBool(new IntPtr(p + 0x067)); // 0245A3F9AE00 0x67 M_ChildControlHeight        ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ChildScaleWidth                         = GetBool(new IntPtr(p + 0x068)); // 0245A3F9AE20 0x68 M_ChildScaleWidth           ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ChildScaleHeight                        = GetBool(new IntPtr(p + 0x069)); // 0245A3F9AE40 0x69 M_ChildScaleHeight          ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.M_ReverseArrangement                      = GetBool(new IntPtr(p + 0x06A)); // 0245A3F9AE60 0x6A M_ReverseArrangement        ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
