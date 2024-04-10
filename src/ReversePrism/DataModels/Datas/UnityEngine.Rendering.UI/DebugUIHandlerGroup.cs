using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                0001866320F0 ModelClassType Text Text Text Pointer
    // 068 Header                                   0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 070 M_Field                                  000186583C70 ModelClassType Container Container Container Pointer
    // 078 M_Container                              0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    public partial class DebugUIHandlerGroup : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Transform?                               Header                                  { get; set; }
        public Container?                               M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerGroup() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 024669389F68 0x60 NameLabel                   ( 0001866320F0 ModelClassType Text Text Text Pointer )
            value.Header                                    = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 024669389F88 0x68 Header                      ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.M_Field                                   = GetObject<Container>(new IntPtr(p + 0x070), ReversePrism.DataModels.Container.FromPointer); // 024669389FA8 0x70 M_Field                     ( 000186583C70 ModelClassType Container Container Container Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 024669389FC8 0x78 M_Container                 ( 0001866A1D00 ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
