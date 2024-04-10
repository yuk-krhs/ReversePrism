using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PrismOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AuthTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 018 AuthType                                 000186569160 ModelEnumType AuthType AuthType AuthType Int32
    public partial class PrismOptions : DataModel
    {
        public AuthType                                 AuthType                                { get; set; }

        public static PrismOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismOptions() { Pointer= p0 };

            value.AuthType                                  = (AuthType)GetInt32(new IntPtr(p + 0x018)); // 024660B6A558 0x18 AuthType                    ( 000186569160 ModelEnumType AuthType AuthType AuthType Int32 )

            return value;
        }
    }
}
