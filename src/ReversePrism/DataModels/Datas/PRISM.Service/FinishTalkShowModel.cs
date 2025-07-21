using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NextOrder                                ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer
    public partial class FinishTalkShowModel : DataModel
    {
        public IProduceNextOrderStatus?                 NextOrder                               { get; set; }

        public static FinishTalkShowModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishTalkShowModel() { Pointer= p0 };

            value.NextOrder                                 = GetObject<IProduceNextOrderStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceNextOrderStatus.FromPointer); // 0x10 NextOrder                   ( ModelClassType IProduceNextOrderStatus IProduceNextOrderStatus IProduceNextOrderStatus Pointer )

            return value;
        }
    }
}
