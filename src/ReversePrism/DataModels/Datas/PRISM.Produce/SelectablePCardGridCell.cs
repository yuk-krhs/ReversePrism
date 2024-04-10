using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SelectableProduceCardContent             00018671FE70 ModelClassType SelectableProduceCardContent SelectableProduceCardContent SelectableProduceCardContent Pointer
    public partial class SelectablePCardGridCell : DataModel
    {
        public SelectableProduceCardContent?            SelectableProduceCardContent            { get; set; }

        public static SelectablePCardGridCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectablePCardGridCell() { Pointer= p0 };

            value.SelectableProduceCardContent              = GetObject<SelectableProduceCardContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.SelectableProduceCardContent.FromPointer); // 024665D46190 0x40 SelectableProduceCardContent ( 00018671FE70 ModelClassType SelectableProduceCardContent SelectableProduceCardContent SelectableProduceCardContent Pointer )

            return value;
        }
    }
}
