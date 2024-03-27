using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 UnityWebRequest                          00018672E3F0 ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer
    // 098 Result                                   0001866B2920 ModelEnumType Result Result Result Int32
    // 0A0 Error                                    000186672F10 ModelPrimitiveType string string string String
    // 0A8 Text                                     000186672F10 ModelPrimitiveType string string string String
    // 0B0 ResponseCode                             0001865F8300 ModelPrimitiveType long long long Int64
    // 0B8 <ResponseHeaders>k__BackingField         Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0C0 Msg                                      000186671910 ModelPrimitiveType string string string String
    public partial class UnityWebRequestException
    {
        public UnityWebRequest?                         UnityWebRequest                         { get; set; }
        public Result                                   Result                                  { get; set; }
        public string                                   Error                                   { get; set; }
        public string                                   Text                                    { get; set; }
        public long                                     ResponseCode                            { get; set; }
        public string                                   Msg                                     { get; set; }

        public static UnityWebRequestException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityWebRequestException();

            value.UnityWebRequest                           = GetObject<UnityWebRequest>(new IntPtr(p + 0x090), ReversePrism.DataModels.UnityWebRequest.FromPointer); // 027004E31DE0 0x90 UnityWebRequest             ( 00018672E3F0 ModelClassType UnityWebRequest UnityWebRequest UnityWebRequest Pointer )
            value.Result                                    = (Result)GetInt32(new IntPtr(p + 0x098)); // 027004E31E00 0x98 Result                      ( 0001866B2920 ModelEnumType Result Result Result Int32 )
            value.Error                                     = GetString(new IntPtr(p + 0x0A0)); // 027004E31E20 0xA0 Error                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x0A8)); // 027004E31E40 0xA8 Text                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.ResponseCode                              = GetInt64(new IntPtr(p + 0x0B0)); // 027004E31E60 0xB0 ResponseCode                ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.Msg                                       = GetString(new IntPtr(p + 0x0C0)); // 027004E31EA0 0xC0 Msg                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
