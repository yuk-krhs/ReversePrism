using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HttpBody> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ContentTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ContentType                              ModelPrimitiveType string string string String
    // 000 DataFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Data                                     ModelClassType ByteString ByteString ByteString Pointer
    // 000 ExtensionsFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_extensions_codec               FieldCodec`1<Any> IL2CPP_TYPE_GENERICINST
    // 028 Extensions                               ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer
    public partial class HttpBody : DataModel
    {
        public string                                   ContentType                             { get; set; }
        public ByteString?                              Data                                    { get; set; }
        public List<Any>?                               Extensions                              { get; set; }

        public static HttpBody? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpBody() { Pointer= p0 };

            value.ContentType                               = GetString(new IntPtr(p + 0x018)); // 0x18 ContentType                 ( ModelPrimitiveType string string string String )
            value.Data                                      = GetObject<ByteString>(new IntPtr(p + 0x020), ReversePrism.DataModels.ByteString.FromPointer); // 0x20 Data                        ( ModelClassType ByteString ByteString ByteString Pointer )
            value.Extensions                                = GetObjectList<Any>(new IntPtr(p + 0x028), ReversePrism.DataModels.Any.FromPointer); // 0x28 Extensions                  ( ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer )

            return value;
        }
    }
}
