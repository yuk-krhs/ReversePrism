using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TextSelectingUtility                   ModelClassType TextSelectingUtilities TextSelectingUtilities TextSelectingUtilities Pointer
    // 018 M_TextHandle                             ModelClassType TextHandle TextHandle TextHandle Pointer
    // 020 M_CursorIndexSavedState                  ModelPrimitiveType int int int Int32
    // 024 IsCompositionActive                      ModelPrimitiveType bool bool bool Bool
    // 025 M_UpdateImeWindowPosition                ModelPrimitiveType bool bool bool Bool
    // 026 Multiline                                ModelPrimitiveType bool bool bool Bool
    // 028 M_Text                                   ModelPrimitiveType string string string String
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

            value.M_TextSelectingUtility                    = GetObject<TextSelectingUtilities>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextSelectingUtilities.FromPointer); // 0x10 M_TextSelectingUtility      ( ModelClassType TextSelectingUtilities TextSelectingUtilities TextSelectingUtilities Pointer )
            value.M_TextHandle                              = GetObject<TextHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextHandle.FromPointer); // 0x18 M_TextHandle                ( ModelClassType TextHandle TextHandle TextHandle Pointer )
            value.M_CursorIndexSavedState                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_CursorIndexSavedState     ( ModelPrimitiveType int int int Int32 )
            value.IsCompositionActive                       = GetBool(new IntPtr(p + 0x024)); // 0x24 IsCompositionActive         ( ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateImeWindowPosition                 = GetBool(new IntPtr(p + 0x025)); // 0x25 M_UpdateImeWindowPosition   ( ModelPrimitiveType bool bool bool Bool )
            value.Multiline                                 = GetBool(new IntPtr(p + 0x026)); // 0x26 Multiline                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_Text                                    = GetString(new IntPtr(p + 0x028)); // 0x28 M_Text                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
