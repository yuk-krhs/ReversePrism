using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishProduceAdvReply               00018650FAA0 ModelClassType IFinishProduceAdvReply IFinishProduceAdvReply IFinishProduceAdvReply Pointer
    public partial class FinishProduceAdvModel : DataModel
    {
        public IFinishProduceAdvReply?                  CacheFinishProduceAdvReply              { get; set; }

        public static FinishProduceAdvModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishProduceAdvModel() { Pointer= p0 };

            value.CacheFinishProduceAdvReply                = GetObject<IFinishProduceAdvReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishProduceAdvReply.FromPointer); // 024666626A08 0x10 CacheFinishProduceAdvReply  ( 00018650FAA0 ModelClassType IFinishProduceAdvReply IFinishProduceAdvReply IFinishProduceAdvReply Pointer )

            return value;
        }
    }
}
