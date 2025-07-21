using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NextSink                                 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    public partial class ServerObjectTerminatorSink : DataModel
    {
        public IMessageSink?                            NextSink                                { get; set; }

        public static ServerObjectTerminatorSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerObjectTerminatorSink() { Pointer= p0 };

            value.NextSink                                  = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x10 NextSink                    ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )

            return value;
        }
    }
}
