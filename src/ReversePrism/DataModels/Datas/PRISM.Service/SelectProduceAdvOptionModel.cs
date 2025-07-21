using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheSelectProduceAdvOptionReply         ModelClassType ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply Pointer
    public partial class SelectProduceAdvOptionModel : DataModel
    {
        public ISelectProduceAdvOptionReply?            CacheSelectProduceAdvOptionReply        { get; set; }

        public static SelectProduceAdvOptionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectProduceAdvOptionModel() { Pointer= p0 };

            value.CacheSelectProduceAdvOptionReply          = GetObject<ISelectProduceAdvOptionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISelectProduceAdvOptionReply.FromPointer); // 0x10 CacheSelectProduceAdvOptionReply ( ModelClassType ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply Pointer )

            return value;
        }
    }
}
