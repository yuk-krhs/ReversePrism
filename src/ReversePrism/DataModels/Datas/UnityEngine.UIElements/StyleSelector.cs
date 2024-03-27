using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Parts                                  000185CA7FC8 ModelEnumListType StyleSelectorPart[] StyleSelectorPart[] List<StyleSelectorPart> Pointer
    // 018 M_PreviousRelationship                   0001865CC720 ModelEnumType StyleSelectorRelationship StyleSelectorRelationship StyleSelectorRelationship Int32
    // 01C PseudoStateMask                          0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 NegatedPseudoStateMask                   0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class StyleSelector
    {
        public List<StyleSelectorPart>?                 M_Parts                                 { get; set; }
        public StyleSelectorRelationship                M_PreviousRelationship                  { get; set; }
        public int                                      PseudoStateMask                         { get; set; }
        public int                                      NegatedPseudoStateMask                  { get; set; }

        public static StyleSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSelector();

            value.M_Parts                                   = GetEnumList<StyleSelectorPart>(new IntPtr(p + 0x010)); // 027006842310 0x10 M_Parts                     ( 000185CA7FC8 ModelEnumListType StyleSelectorPart[] StyleSelectorPart[] List<StyleSelectorPart> Pointer )
            value.M_PreviousRelationship                    = (StyleSelectorRelationship)GetInt32(new IntPtr(p + 0x018)); // 027006842330 0x18 M_PreviousRelationship      ( 0001865CC720 ModelEnumType StyleSelectorRelationship StyleSelectorRelationship StyleSelectorRelationship Int32 )
            value.PseudoStateMask                           = GetInt32(new IntPtr(p + 0x01C)); // 027006842350 0x1C PseudoStateMask             ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NegatedPseudoStateMask                    = GetInt32(new IntPtr(p + 0x020)); // 027006842370 0x20 NegatedPseudoStateMask      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
