using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GetObject                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 NoGetObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 030 SelectableProduceCardContent             ModelClassType SelectableProduceCardContent SelectableProduceCardContent SelectableProduceCardContent Pointer
    public partial class GetProduceCardContent : DataModel
    {
        public GameObject?                              GetObject                               { get; set; }
        public GameObject?                              NoGetObject                             { get; set; }
        public SelectableProduceCardContent?            SelectableProduceCardContent            { get; set; }

        public static GetProduceCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceCardContent() { Pointer= p0 };

            value.GetObject                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GetObject                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NoGetObject                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 NoGetObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectableProduceCardContent              = GetObject<SelectableProduceCardContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectableProduceCardContent.FromPointer); // 0x30 SelectableProduceCardContent ( ModelClassType SelectableProduceCardContent SelectableProduceCardContent SelectableProduceCardContent Pointer )

            return value;
        }
    }
}
