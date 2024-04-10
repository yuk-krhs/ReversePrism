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
    public partial class OsapiResult : DataModel
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
            var value   = new OsapiResult() { Pointer= p0 };

            value.HasBody                                   = GetBool(new IntPtr(p + 0x010)); // 02466B515890 0x10 HasBody                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsNetworkErrorOccurred                    = GetBool(new IntPtr(p + 0x020)); // 02466B5158D0 0x20 IsNetworkErrorOccurred      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RawBody                                   = GetString(new IntPtr(p + 0x028)); // 02466B5158F0 0x28 RawBody                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HttpStatus                                = GetInt32(new IntPtr(p + 0x030)); // 02466B515910 0x30 HttpStatus                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x038), ReversePrism.DataModels.Error.FromPointer); // 02466B515930 0x38 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
