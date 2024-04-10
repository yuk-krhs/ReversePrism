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
    public partial class SdkResult : DataModel
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
            var value   = new SdkResult() { Pointer= p0 };

            value.IsAlreadyInitialized                      = GetBool(new IntPtr(p + 0x010)); // 02466B50E980 0x10 IsAlreadyInitialized        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsInitializeStarted                       = GetBool(new IntPtr(p + 0x011)); // 02466B50E9A0 0x11 IsInitializeStarted         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x012)); // 02466B50E9C0 0x12 IsInitialized               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsStartedPaymentView                      = GetBool(new IntPtr(p + 0x013)); // 02466B50E9E0 0x13 IsStartedPaymentView        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DmmGamesId                                = GetString(new IntPtr(p + 0x018)); // 02466B50EA00 0x18 DmmGamesId                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsSuccess                                 = GetBool(new IntPtr(p + 0x020)); // 02466B50EA20 0x20 IsSuccess                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x028), ReversePrism.DataModels.Error.FromPointer); // 02466B50EA40 0x28 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
