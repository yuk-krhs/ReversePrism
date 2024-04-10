using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TextSelectingUtility                   0001866472A0 ModelClassType TextSelectingUtilities TextSelectingUtilities TextSelectingUtilities Pointer
    // 018 M_TextHandle                             00018663D5B0 ModelClassType TextHandle TextHandle TextHandle Pointer
    // 020 M_CursorIndexSavedState                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IsCompositionActive                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 025 M_UpdateImeWindowPosition                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 026 Multiline                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 M_Text                                   000186671910 ModelPrimitiveType string string string String
    // 000 s_KeyEditOps                             Dictionary`2<Event, TextEditOp> IL2CPP_TYPE_GENERICINST
    public partial class TextEditingUtilities : DataModel
    {
        public TextSelectingUtilities?                  M_TextSelectingUtility                  { get; set; }
        public TextHandle?                              M_TextHandle                            { get; set; }
        public int                                      M_CursorIndexSavedState                 { get; set; }
        public bool                                     IsCompositionActive                     { get; set; }
        public bool                                     M_UpdateImeWindowPosition               { get; set; }
        public bool                                     Multiline                               { get; set; }
        public string                                   M_Text                                  { get; set; }

        public static TextEditingUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextEditingUtilities() { Pointer= p0 };

            value.M_TextSelectingUtility                    = GetObject<TextSelectingUtilities>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextSelectingUtilities.FromPointer); // 0245A68EDB18 0x10 M_TextSelectingUtility      ( 0001866472A0 ModelClassType TextSelectingUtilities TextSelectingUtilities TextSelectingUtilities Pointer )
            value.M_TextHandle                              = GetObject<TextHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextHandle.FromPointer); // 0245A68EDB38 0x18 M_TextHandle                ( 00018663D5B0 ModelClassType TextHandle TextHandle TextHandle Pointer )
            value.M_CursorIndexSavedState                   = GetInt32(new IntPtr(p + 0x020)); // 0245A68EDB58 0x20 M_CursorIndexSavedState     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsCompositionActive                       = GetBool(new IntPtr(p + 0x024)); // 0245A68EDB78 0x24 IsCompositionActive         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateImeWindowPosition                 = GetBool(new IntPtr(p + 0x025)); // 0245A68EDB98 0x25 M_UpdateImeWindowPosition   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Multiline                                 = GetBool(new IntPtr(p + 0x026)); // 0245A68EDBB8 0x26 Multiline                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_Text                                    = GetString(new IntPtr(p + 0x028)); // 0245A68EDBD8 0x28 M_Text                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
