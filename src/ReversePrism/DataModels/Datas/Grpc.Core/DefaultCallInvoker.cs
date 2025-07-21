using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel                                  ModelClassType Channel Channel Channel Pointer
    public partial class DefaultCallInvoker : DataModel
    {
        public Channel?                                 Channel                                 { get; set; }

        public static DefaultCallInvoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultCallInvoker() { Pointer= p0 };

            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x010), ReversePrism.DataModels.Channel.FromPointer); // 0x10 Channel                     ( ModelClassType Channel Channel Channel Pointer )

            return value;
        }
    }
}
