using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Url                                      0001866722E0 ModelPrimitiveType string string string String
    // 020 Headers                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 028 Body                                     000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Options                                  0001866E11A0 ModelEnumType HttpOptions HttpOptions HttpOptions Int32
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

            value.Method                                    = GetString(new IntPtr(p + 0x010)); // 02466BAE38A8 0x10 Method                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 02466BAE38C8 0x18 Url                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Body                                      = GetSByteList(new IntPtr(p + 0x028)); // 02466BAE3908 0x28 Body                        ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Options                                   = (HttpOptions)GetInt32(new IntPtr(p + 0x030)); // 02466BAE3928 0x30 Options                     ( 0001866E11A0 ModelEnumType HttpOptions HttpOptions HttpOptions Int32 )

            return value;
        }
    }
}
