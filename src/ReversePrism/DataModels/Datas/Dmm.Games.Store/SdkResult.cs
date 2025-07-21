using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAlreadyInitialized                     ModelPrimitiveType bool bool bool Bool
    // 011 IsInitializeStarted                      ModelPrimitiveType bool bool bool Bool
    // 012 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 013 IsStartedPaymentView                     ModelPrimitiveType bool bool bool Bool
    // 018 DmmGamesId                               ModelPrimitiveType string string string String
    // 020 IsSuccess                                ModelPrimitiveType bool bool bool Bool
    // 028 Error                                    ModelClassType Error Error Error Pointer
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

            value.IsAlreadyInitialized                      = GetBool(new IntPtr(p + 0x010)); // 0x10 IsAlreadyInitialized        ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitializeStarted                       = GetBool(new IntPtr(p + 0x011)); // 0x11 IsInitializeStarted         ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x012)); // 0x12 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.IsStartedPaymentView                      = GetBool(new IntPtr(p + 0x013)); // 0x13 IsStartedPaymentView        ( ModelPrimitiveType bool bool bool Bool )
            value.DmmGamesId                                = GetString(new IntPtr(p + 0x018)); // 0x18 DmmGamesId                  ( ModelPrimitiveType string string string String )
            value.IsSuccess                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSuccess                   ( ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x028), ReversePrism.DataModels.Error.FromPointer); // 0x28 Error                       ( ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
