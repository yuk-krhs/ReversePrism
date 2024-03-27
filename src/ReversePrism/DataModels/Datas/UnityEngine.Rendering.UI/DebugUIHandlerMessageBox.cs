using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 M_Field                                  000186587280 ModelClassType MessageBox MessageBox MessageBox Pointer
    // 000 k_WarningBackgroundColor                 Color32 IL2CPP_TYPE_VALUETYPE
    // 004 k_WarningTextColor                       Color32 IL2CPP_TYPE_VALUETYPE
    // 008 k_ErrorBackgroundColor                   Color32 IL2CPP_TYPE_VALUETYPE
    // 00C k_ErrorTextColor                         Color32 IL2CPP_TYPE_VALUETYPE
    public partial class DebugUIHandlerMessageBox
    {
        public Text?                                    NameLabel                               { get; set; }
        public MessageBox?                              M_Field                                 { get; set; }

        public static DebugUIHandlerMessageBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerMessageBox();

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270D9337670 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<MessageBox>(new IntPtr(p + 0x068), ReversePrism.DataModels.MessageBox.FromPointer); // 0270D9337690 0x68 M_Field                     ( 000186587280 ModelClassType MessageBox MessageBox MessageBox Pointer )

            return value;
        }
    }
}
