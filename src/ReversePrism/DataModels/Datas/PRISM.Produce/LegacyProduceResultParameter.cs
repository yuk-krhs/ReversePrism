using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    ModelClassType IProduceResultReply IProduceResultReply IProduceResultReply Pointer
    public partial class LegacyProduceResultParameter : DataModel
    {
        public IProduceResultReply?                     Reply                                   { get; set; }

        public static LegacyProduceResultParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceResultParameter() { Pointer= p0 };

            value.Reply                                     = GetObject<IProduceResultReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceResultReply.FromPointer); // 0x10 Reply                       ( ModelClassType IProduceResultReply IProduceResultReply IProduceResultReply Pointer )

            return value;
        }
    }
}
