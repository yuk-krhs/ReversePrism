using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 MeasuredSizes                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 RoundedSizes                             0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 M_TextElement                            000186638B30 ModelClassType TextElement TextElement TextElement Pointer
    // 050 IsOverridingCursor                       000186595210 ModelPrimitiveType bool bool bool Bool
    // 054 CurrentLinkIDHash                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 058 HasLinkTag                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 059 HasATag                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 k_MinPadding                             float IL2CPP_TYPE_R4
    public partial class UITKTextHandle
    {
        public Vector2                                  MeasuredSizes                           { get; set; }
        public Vector2                                  RoundedSizes                            { get; set; }
        public TextElement?                             M_TextElement                           { get; set; }
        public bool                                     IsOverridingCursor                      { get; set; }
        public int                                      CurrentLinkIDHash                       { get; set; }
        public bool                                     HasLinkTag                              { get; set; }
        public bool                                     HasATag                                 { get; set; }

        public static UITKTextHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITKTextHandle();

            value.MeasuredSizes                             = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 027006847790 0x38 MeasuredSizes               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RoundedSizes                              = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0270068477B0 0x40 RoundedSizes                ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_TextElement                             = GetObject<TextElement>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextElement.FromPointer); // 0270068477D0 0x48 M_TextElement               ( 000186638B30 ModelClassType TextElement TextElement TextElement Pointer )
            value.IsOverridingCursor                        = GetBool(new IntPtr(p + 0x050)); // 0270068477F0 0x50 IsOverridingCursor          ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.CurrentLinkIDHash                         = GetInt32(new IntPtr(p + 0x054)); // 027006847810 0x54 CurrentLinkIDHash           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.HasLinkTag                                = GetBool(new IntPtr(p + 0x058)); // 027006847830 0x58 HasLinkTag                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasATag                                   = GetBool(new IntPtr(p + 0x059)); // 027006847850 0x59 HasATag                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
