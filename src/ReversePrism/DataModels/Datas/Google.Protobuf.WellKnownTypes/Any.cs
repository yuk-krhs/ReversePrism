using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Any> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TypeUrlFieldNumber                       int IL2CPP_TYPE_I4
    // 018 TypeUrl                                  000186671910 ModelPrimitiveType string string string String
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Value                                    00018659EF10 ModelClassType ByteString ByteString ByteString Pointer
    // 000 DefaultPrefix                            string IL2CPP_TYPE_STRING
    public partial class Any : DataModel
    {
        public string                                   TypeUrl                                 { get; set; }
        public ByteString?                              Value                                   { get; set; }

        public static Any? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Any() { Pointer= p0 };

            value.TypeUrl                                   = GetString(new IntPtr(p + 0x018)); // 0246605D52C0 0x18 TypeUrl                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetObject<ByteString>(new IntPtr(p + 0x020), ReversePrism.DataModels.ByteString.FromPointer); // 0246605D5300 0x20 Value                       ( 00018659EF10 ModelClassType ByteString ByteString ByteString Pointer )

            return value;
        }
    }
}
