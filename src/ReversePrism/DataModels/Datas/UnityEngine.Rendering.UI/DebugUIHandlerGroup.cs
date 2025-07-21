using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 Header                                   ModelClassType Transform Transform Transform Pointer
    // 070 M_Field                                  ModelClassType Container Container Container Pointer
    // 078 M_Container                              ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
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

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.Header                                    = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 Header                      ( ModelClassType Transform Transform Transform Pointer )
            value.M_Field                                   = GetObject<Container>(new IntPtr(p + 0x070), ReversePrism.DataModels.Container.FromPointer); // 0x70 M_Field                     ( ModelClassType Container Container Container Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0x78 M_Container                 ( ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
