using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GetObject                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 NoGetObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 SelectableProduceCardContent             00018671FE70 ModelClassType SelectableProduceCardContent SelectableProduceCardContent SelectableProduceCardContent Pointer
    public partial class GetProduceCardContent
    {
        public GameObject?                              GetObject                               { get; set; }
        public GameObject?                              NoGetObject                             { get; set; }
        public SelectableProduceCardContent?            SelectableProduceCardContent            { get; set; }

        public static GetProduceCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceCardContent();

            value.GetObject                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CDA3A8 0x20 GetObject                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NoGetObject                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CDA3C8 0x28 NoGetObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectableProduceCardContent              = GetObject<SelectableProduceCardContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectableProduceCardContent.FromPointer); // 0270D5CDA3E8 0x30 SelectableProduceCardContent ( 00018671FE70 ModelClassType SelectableProduceCardContent SelectableProduceCardContent SelectableProduceCardContent Pointer )

            return value;
        }
    }
}
