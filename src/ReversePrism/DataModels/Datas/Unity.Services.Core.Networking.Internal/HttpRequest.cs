using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   ModelPrimitiveType string string string String
    // 018 Url                                      ModelPrimitiveType string string string String
    // 020 Headers                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 028 Body                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Options                                  ModelEnumType HttpOptions HttpOptions HttpOptions Int32
    public partial class HttpRequest : DataModel
    {
        public string                                   Method                                  { get; set; }
        public string                                   Url                                     { get; set; }
        public List<sbyte>?                             Body                                    { get; set; }
        public HttpOptions                              Options                                 { get; set; }

        public static HttpRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpRequest() { Pointer= p0 };

            value.Method                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Method                      ( ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Url                         ( ModelPrimitiveType string string string String )
            value.Body                                      = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Body                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Options                                   = (HttpOptions)GetInt32(new IntPtr(p + 0x030)); // 0x30 Options                     ( ModelEnumType HttpOptions HttpOptions HttpOptions Int32 )

            return value;
        }
    }
}
