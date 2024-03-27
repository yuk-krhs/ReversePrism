using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasBody                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ResponseHeaders                          Dictionary`2<string, List`1<string>> IL2CPP_TYPE_GENERICINST
    // 020 IsNetworkErrorOccurred                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 RawBody                                  0001866722E0 ModelPrimitiveType string string string String
    // 030 HttpStatus                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 Error                                    0001865C8690 ModelClassType Error Error Error Pointer
    public partial class OsapiResult
    {
        public bool                                     HasBody                                 { get; set; }
        public bool                                     IsNetworkErrorOccurred                  { get; set; }
        public string                                   RawBody                                 { get; set; }
        public int                                      HttpStatus                              { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static OsapiResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiResult();

            value.HasBody                                   = GetBool(new IntPtr(p + 0x010)); // 0270DB498990 0x10 HasBody                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNetworkErrorOccurred                    = GetBool(new IntPtr(p + 0x020)); // 0270DB4989D0 0x20 IsNetworkErrorOccurred      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RawBody                                   = GetString(new IntPtr(p + 0x028)); // 0270DB4989F0 0x28 RawBody                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HttpStatus                                = GetInt32(new IntPtr(p + 0x030)); // 0270DB498A10 0x30 HttpStatus                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x038), ReversePrism.DataModels.Error.FromPointer); // 0270DB498A30 0x38 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
