using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnvoySinks                               ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    public partial class EnvoyInfo : DataModel
    {
        public IMessageSink?                            EnvoySinks                              { get; set; }

        public static EnvoyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnvoyInfo() { Pointer= p0 };

            value.EnvoySinks                                = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x10 EnvoySinks                  ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )

            return value;
        }
    }
}
