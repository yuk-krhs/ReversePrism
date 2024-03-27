using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAlreadyInitialized                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 IsInitializeStarted                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 IsInitialized                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 IsStartedPaymentView                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 DmmGamesId                               0001866722E0 ModelPrimitiveType string string string String
    // 020 IsSuccess                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 Error                                    0001865C8690 ModelClassType Error Error Error Pointer
    public partial class SdkResult
    {
        public bool                                     IsAlreadyInitialized                    { get; set; }
        public bool                                     IsInitializeStarted                     { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public bool                                     IsStartedPaymentView                    { get; set; }
        public string                                   DmmGamesId                              { get; set; }
        public bool                                     IsSuccess                               { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static SdkResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SdkResult();

            value.IsAlreadyInitialized                      = GetBool(new IntPtr(p + 0x010)); // 0270DB481A50 0x10 IsAlreadyInitialized        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsInitializeStarted                       = GetBool(new IntPtr(p + 0x011)); // 0270DB481A70 0x11 IsInitializeStarted         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x012)); // 0270DB481A90 0x12 IsInitialized               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsStartedPaymentView                      = GetBool(new IntPtr(p + 0x013)); // 0270DB481AB0 0x13 IsStartedPaymentView        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DmmGamesId                                = GetString(new IntPtr(p + 0x018)); // 0270DB481AD0 0x18 DmmGamesId                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsSuccess                                 = GetBool(new IntPtr(p + 0x020)); // 0270DB481AF0 0x20 IsSuccess                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x028), ReversePrism.DataModels.Error.FromPointer); // 0270DB481B10 0x28 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
