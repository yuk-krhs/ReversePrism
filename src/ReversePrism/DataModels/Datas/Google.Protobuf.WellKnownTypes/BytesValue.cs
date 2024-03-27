using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BytesValue> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    00018659EF10 ModelClassType ByteString ByteString ByteString Pointer
    public partial class BytesValue
    {
        public ByteString?                              Value                                   { get; set; }

        public static BytesValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BytesValue();

            value.Value                                     = GetObject<ByteString>(new IntPtr(p + 0x018), ReversePrism.DataModels.ByteString.FromPointer); // 0270DA4D9E10 0x18 Value                       ( 00018659EF10 ModelClassType ByteString ByteString ByteString Pointer )

            return value;
        }
    }
}
