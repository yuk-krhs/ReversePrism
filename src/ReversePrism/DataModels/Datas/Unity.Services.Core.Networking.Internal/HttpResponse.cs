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
    public partial class HttpResponse
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
            var value   = new HttpResponse();

            value.Request                                   = (ReadOnlyHttpRequest)GetInt32(new IntPtr(p + 0x010)); // 0270DBA5CC38 0x10 Request                     ( 00018661AC50 ModelEnumType ReadOnlyHttpRequest ReadOnlyHttpRequest ReadOnlyHttpRequest Int32 )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x020)); // 0270DBA5CC78 0x20 Data                        ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StatusCode                                = GetInt64(new IntPtr(p + 0x028)); // 0270DBA5CC98 0x28 StatusCode                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.ErrorMessage                              = GetString(new IntPtr(p + 0x030)); // 0270DBA5CCB8 0x30 ErrorMessage                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsHttpError                               = GetBool(new IntPtr(p + 0x038)); // 0270DBA5CCD8 0x38 IsHttpError                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNetworkError                            = GetBool(new IntPtr(p + 0x039)); // 0270DBA5CCF8 0x39 IsNetworkError              ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
