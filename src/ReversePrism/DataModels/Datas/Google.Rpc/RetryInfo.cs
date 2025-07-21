using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RetryInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RetryDelayFieldNumber                    int IL2CPP_TYPE_I4
    // 018 RetryDelay                               ModelClassType Duration Duration Duration Pointer
    public partial class RetryInfo : DataModel
    {
        public Duration?                                RetryDelay                              { get; set; }

        public static RetryInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RetryInfo() { Pointer= p0 };

            value.RetryDelay                                = GetObject<Duration>(new IntPtr(p + 0x018), ReversePrism.DataModels.Duration.FromPointer); // 0x18 RetryDelay                  ( ModelClassType Duration Duration Duration Pointer )

            return value;
        }
    }
}
