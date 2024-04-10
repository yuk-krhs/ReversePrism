using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Request                                  00018661AC50 ModelEnumType ReadOnlyHttpRequest ReadOnlyHttpRequest ReadOnlyHttpRequest Int32
    // 018 Headers                                  Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 020 Data                                     000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 StatusCode                               0001865F7E40 ModelPrimitiveType long long long Int64
    // 030 ErrorMessage                             0001866722E0 ModelPrimitiveType string string string String
    // 038 IsHttpError                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 039 IsNetworkError                           000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class HttpResponse : DataModel
    {
        public ReadOnlyHttpRequest                      Request                                 { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }
        public long                                     StatusCode                              { get; set; }
        public string                                   ErrorMessage                            { get; set; }
        public bool                                     IsHttpError                             { get; set; }
        public bool                                     IsNetworkError                          { get; set; }

        public static HttpResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpResponse() { Pointer= p0 };

            value.Request                                   = (ReadOnlyHttpRequest)GetInt32(new IntPtr(p + 0x010)); // 02466BAE4118 0x10 Request                     ( 00018661AC50 ModelEnumType ReadOnlyHttpRequest ReadOnlyHttpRequest ReadOnlyHttpRequest Int32 )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x020)); // 02466BAE4158 0x20 Data                        ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StatusCode                                = GetInt64(new IntPtr(p + 0x028)); // 02466BAE4178 0x28 StatusCode                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.ErrorMessage                              = GetString(new IntPtr(p + 0x030)); // 02466BAE4198 0x30 ErrorMessage                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsHttpError                               = GetBool(new IntPtr(p + 0x038)); // 02466BAE41B8 0x38 IsHttpError                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNetworkError                            = GetBool(new IntPtr(p + 0x039)); // 02466BAE41D8 0x39 IsNetworkError              ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
