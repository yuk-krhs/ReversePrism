using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    0001865F1D10 ModelClassType IProduceResultReply IProduceResultReply IProduceResultReply Pointer
    public partial class LegacyProduceResultParameter
    {
        public IProduceResultReply?                     Reply                                   { get; set; }

        public static LegacyProduceResultParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceResultParameter();

            value.Reply                                     = GetObject<IProduceResultReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceResultReply.FromPointer); // 0270D55DE790 0x10 Reply                       ( 0001865F1D10 ModelClassType IProduceResultReply IProduceResultReply IProduceResultReply Pointer )

            return value;
        }
    }
}
