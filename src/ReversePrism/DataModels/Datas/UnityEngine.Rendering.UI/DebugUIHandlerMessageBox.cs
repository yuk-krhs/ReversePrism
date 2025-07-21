using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 M_Field                                  ModelClassType MessageBox MessageBox MessageBox Pointer
    // 000 k_WarningBackgroundColor                 Color32 IL2CPP_TYPE_VALUETYPE
    // 004 k_WarningTextColor                       Color32 IL2CPP_TYPE_VALUETYPE
    // 008 k_ErrorBackgroundColor                   Color32 IL2CPP_TYPE_VALUETYPE
    // 00C k_ErrorTextColor                         Color32 IL2CPP_TYPE_VALUETYPE
    public partial class DebugUIHandlerMessageBox : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public MessageBox?                              M_Field                                 { get; set; }

        public static DebugUIHandlerMessageBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerMessageBox() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<MessageBox>(new IntPtr(p + 0x068), ReversePrism.DataModels.MessageBox.FromPointer); // 0x68 M_Field                     ( ModelClassType MessageBox MessageBox MessageBox Pointer )

            return value;
        }
    }
}
