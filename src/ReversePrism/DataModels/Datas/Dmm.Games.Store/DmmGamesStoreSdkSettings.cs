using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 018 ConsumerKey                              0001866722E0 ModelPrimitiveType string string string String
    // 020 ConsumerSecret                           0001866722E0 ModelPrimitiveType string string string String
    // 028 Environment                              0001866722E0 ModelPrimitiveType string string string String
    // 030 DevelopmentMode                          0001866722E0 ModelPrimitiveType string string string String
    // 038 GameName                                 0001866722E0 ModelPrimitiveType string string string String
    // 040 OauthSignaturePublicKey                  0001866722E0 ModelPrimitiveType string string string String
    // 048 WebViewTimeoutMillis                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 050 MarketingEventIds                        0001865D5320 ModelClassType MarketingEventIds MarketingEventIds MarketingEventIds Pointer
    // 058 Callback                                 000186531CE0 ModelClassType Callback Callback Callback Pointer
    // 060 IsStandaloneAuthEnable                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 068 AuthParams                               00018671FAE0 ModelClassType AuthParams AuthParams AuthParams Pointer
    public partial class DmmGamesStoreSdkSettings : DataModel
    {
        public string                                   AppId                                   { get; set; }
        public string                                   ConsumerKey                             { get; set; }
        public string                                   ConsumerSecret                          { get; set; }
        public string                                   Environment                             { get; set; }
        public string                                   DevelopmentMode                         { get; set; }
        public string                                   GameName                                { get; set; }
        public string                                   OauthSignaturePublicKey                 { get; set; }
        public int                                      WebViewTimeoutMillis                    { get; set; }
        public MarketingEventIds?                       MarketingEventIds                       { get; set; }
        public Callback?                                Callback                                { get; set; }
        public bool                                     IsStandaloneAuthEnable                  { get; set; }
        public AuthParams?                              AuthParams                              { get; set; }

        public static DmmGamesStoreSdkSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesStoreSdkSettings() { Pointer= p0 };

            value.AppId                                     = GetString(new IntPtr(p + 0x010)); // 02466B50EED0 0x10 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ConsumerKey                               = GetString(new IntPtr(p + 0x018)); // 02466B50EEF0 0x18 ConsumerKey                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ConsumerSecret                            = GetString(new IntPtr(p + 0x020)); // 02466B50EF10 0x20 ConsumerSecret              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Environment                               = GetString(new IntPtr(p + 0x028)); // 02466B50EF30 0x28 Environment                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DevelopmentMode                           = GetString(new IntPtr(p + 0x030)); // 02466B50EF50 0x30 DevelopmentMode             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.GameName                                  = GetString(new IntPtr(p + 0x038)); // 02466B50EF70 0x38 GameName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.OauthSignaturePublicKey                   = GetString(new IntPtr(p + 0x040)); // 02466B50EF90 0x40 OauthSignaturePublicKey     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.WebViewTimeoutMillis                      = GetInt32(new IntPtr(p + 0x048)); // 02466B50EFB0 0x48 WebViewTimeoutMillis        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MarketingEventIds                         = GetObject<MarketingEventIds>(new IntPtr(p + 0x050), ReversePrism.DataModels.MarketingEventIds.FromPointer); // 02466B50EFD0 0x50 MarketingEventIds           ( 0001865D5320 ModelClassType MarketingEventIds MarketingEventIds MarketingEventIds Pointer )
            value.Callback                                  = GetObject<Callback>(new IntPtr(p + 0x058), ReversePrism.DataModels.Callback.FromPointer); // 02466B50EFF0 0x58 Callback                    ( 000186531CE0 ModelClassType Callback Callback Callback Pointer )
            value.IsStandaloneAuthEnable                    = GetBool(new IntPtr(p + 0x060)); // 02466B50F010 0x60 IsStandaloneAuthEnable      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AuthParams                                = GetObject<AuthParams>(new IntPtr(p + 0x068), ReversePrism.DataModels.AuthParams.FromPointer); // 02466B50F030 0x68 AuthParams                  ( 00018671FAE0 ModelClassType AuthParams AuthParams AuthParams Pointer )

            return value;
        }
    }
}
