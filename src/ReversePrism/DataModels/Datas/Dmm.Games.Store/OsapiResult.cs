using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasBody                                  ModelPrimitiveType bool bool bool Bool
    // 018 ResponseHeaders                          Dictionary`2<string, List`1<string>> IL2CPP_TYPE_GENERICINST
    // 020 IsNetworkErrorOccurred                   ModelPrimitiveType bool bool bool Bool
    // 028 RawBody                                  ModelPrimitiveType string string string String
    // 030 HttpStatus                               ModelPrimitiveType int int int Int32
    // 038 Error                                    ModelClassType Error Error Error Pointer
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

            value.HasBody                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 HasBody                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsNetworkErrorOccurred                    = GetBool(new IntPtr(p + 0x020)); // 0x20 IsNetworkErrorOccurred      ( ModelPrimitiveType bool bool bool Bool )
            value.RawBody                                   = GetString(new IntPtr(p + 0x028)); // 0x28 RawBody                     ( ModelPrimitiveType string string string String )
            value.HttpStatus                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 HttpStatus                  ( ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x038), ReversePrism.DataModels.Error.FromPointer); // 0x38 Error                       ( ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
