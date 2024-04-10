using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 M_Field                                  000186583250 ModelClassType Button Button Button Pointer
    public partial class DebugUIHandlerButton : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Button?                                  M_Field                                 { get; set; }

        public static DebugUIHandlerButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerButton() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 024669374550 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.M_Field                                   = GetObject<Button>(new IntPtr(p + 0x068), ReversePrism.DataModels.Button.FromPointer); // 024669374570 0x68 M_Field                     ( 000186583250 ModelClassType Button Button Button Pointer )

            return value;
        }
    }
}
