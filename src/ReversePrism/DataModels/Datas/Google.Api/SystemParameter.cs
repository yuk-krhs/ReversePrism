using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SystemParameter> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 HttpHeaderFieldNumber                    int IL2CPP_TYPE_I4
    // 020 HttpHeader                               ModelPrimitiveType string string string String
    // 000 UrlQueryParameterFieldNumber             int IL2CPP_TYPE_I4
    // 028 UrlQueryParameter                        ModelPrimitiveType string string string String
    public partial class SystemParameter : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   HttpHeader                              { get; set; }
        public string                                   UrlQueryParameter                       { get; set; }

        public static SystemParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemParameter() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.HttpHeader                                = GetString(new IntPtr(p + 0x020)); // 0x20 HttpHeader                  ( ModelPrimitiveType string string string String )
            value.UrlQueryParameter                         = GetString(new IntPtr(p + 0x028)); // 0x28 UrlQueryParameter           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
