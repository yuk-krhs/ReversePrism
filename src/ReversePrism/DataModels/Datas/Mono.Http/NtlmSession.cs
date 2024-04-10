using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  000186606300 ModelClassType MessageBase MessageBase MessageBase Pointer
    public partial class NtlmSession : DataModel
    {
        public MessageBase?                             Message                                 { get; set; }

        public static NtlmSession? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NtlmSession() { Pointer= p0 };

            value.Message                                   = GetObject<MessageBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessageBase.FromPointer); // 0246679A39C0 0x10 Message                     ( 000186606300 ModelClassType MessageBase MessageBase MessageBase Pointer )

            return value;
        }
    }
}
