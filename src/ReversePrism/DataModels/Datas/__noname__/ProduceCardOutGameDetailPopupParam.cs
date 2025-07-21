using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ProduceCard                              ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    public partial class ProduceCardOutGameDetailPopupParam : DataModel
    {
        public IProduceCardStatus?                      ProduceCard                             { get; set; }

        public static ProduceCardOutGameDetailPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardOutGameDetailPopupParam() { Pointer= p0 };

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x90 ProduceCard                 ( ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )

            return value;
        }
    }
}
