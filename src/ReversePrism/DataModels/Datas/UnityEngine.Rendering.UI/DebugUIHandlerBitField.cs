using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 ValueToggle                              0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer
    // 070 Toggles                                  000185CD6CE8 ModelClassListType List`1<DebugUIHandlerIndirectToggle> List`1<DebugUIHandlerIndirectToggle> List<DebugUIHandlerIndirectToggle> Pointer
    // 078 M_Field                                  000186582850 ModelClassType BitField BitField BitField Pointer
    // 080 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerBitField
    {
        public Text?                                    NameLabel                               { get; set; }
        public UIFoldout?                               ValueToggle                             { get; set; }
        public List<DebugUIHandlerIndirectToggle>?      Toggles                                 { get; set; }
        public BitField?                                M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerBitField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerBitField();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D9303CC0 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 0270D9303CE0 0x68 ValueToggle                 ( 0001866E9A80 ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.Toggles                                   = GetObjectList<DebugUIHandlerIndirectToggle>(new IntPtr(p + 0x070), ReversePrism.DataModels.DebugUIHandlerIndirectToggle.FromPointer); // 0270D9303D00 0x70 Toggles                     ( 000185CD6CE8 ModelClassListType List`1<DebugUIHandlerIndirectToggle> List`1<DebugUIHandlerIndirectToggle> List<DebugUIHandlerIndirectToggle> Pointer )
            value.M_Field                                   = GetObject<BitField>(new IntPtr(p + 0x078), ReversePrism.DataModels.BitField.FromPointer); // 0270D9303D20 0x78 M_Field                     ( 000186582850 ModelClassType BitField BitField BitField Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x080), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0270D9303D40 0x80 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
