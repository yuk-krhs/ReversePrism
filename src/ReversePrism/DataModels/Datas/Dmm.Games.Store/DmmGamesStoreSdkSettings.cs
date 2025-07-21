using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppId                                    ModelPrimitiveType string string string String
    // 018 ConsumerKey                              ModelPrimitiveType string string string String
    // 020 ConsumerSecret                           ModelPrimitiveType string string string String
    // 028 Environment                              ModelPrimitiveType string string string String
    // 030 DevelopmentMode                          ModelPrimitiveType string string string String
    // 038 GameName                                 ModelPrimitiveType string string string String
    // 040 OauthSignaturePublicKey                  ModelPrimitiveType string string string String
    // 048 WebViewTimeoutMillis                     ModelPrimitiveType int int int Int32
    // 050 MarketingEventIds                        ModelClassType MarketingEventIds MarketingEventIds MarketingEventIds Pointer
    // 058 Callback                                 ModelClassType Callback Callback Callback Pointer
    // 060 IsStandaloneAuthEnable                   ModelPrimitiveType bool bool bool Bool
    // 068 AuthParams                               ModelClassType AuthParams AuthParams AuthParams Pointer
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

            value.AppId                                     = GetString(new IntPtr(p + 0x010)); // 0x10 AppId                       ( ModelPrimitiveType string string string String )
            value.ConsumerKey                               = GetString(new IntPtr(p + 0x018)); // 0x18 ConsumerKey                 ( ModelPrimitiveType string string string String )
            value.ConsumerSecret                            = GetString(new IntPtr(p + 0x020)); // 0x20 ConsumerSecret              ( ModelPrimitiveType string string string String )
            value.Environment                               = GetString(new IntPtr(p + 0x028)); // 0x28 Environment                 ( ModelPrimitiveType string string string String )
            value.DevelopmentMode                           = GetString(new IntPtr(p + 0x030)); // 0x30 DevelopmentMode             ( ModelPrimitiveType string string string String )
            value.GameName                                  = GetString(new IntPtr(p + 0x038)); // 0x38 GameName                    ( ModelPrimitiveType string string string String )
            value.OauthSignaturePublicKey                   = GetString(new IntPtr(p + 0x040)); // 0x40 OauthSignaturePublicKey     ( ModelPrimitiveType string string string String )
            value.WebViewTimeoutMillis                      = GetInt32(new IntPtr(p + 0x048)); // 0x48 WebViewTimeoutMillis        ( ModelPrimitiveType int int int Int32 )
            value.MarketingEventIds                         = GetObject<MarketingEventIds>(new IntPtr(p + 0x050), ReversePrism.DataModels.MarketingEventIds.FromPointer); // 0x50 MarketingEventIds           ( ModelClassType MarketingEventIds MarketingEventIds MarketingEventIds Pointer )
            value.Callback                                  = GetObject<Callback>(new IntPtr(p + 0x058), ReversePrism.DataModels.Callback.FromPointer); // 0x58 Callback                    ( ModelClassType Callback Callback Callback Pointer )
            value.IsStandaloneAuthEnable                    = GetBool(new IntPtr(p + 0x060)); // 0x60 IsStandaloneAuthEnable      ( ModelPrimitiveType bool bool bool Bool )
            value.AuthParams                                = GetObject<AuthParams>(new IntPtr(p + 0x068), ReversePrism.DataModels.AuthParams.FromPointer); // 0x68 AuthParams                  ( ModelClassType AuthParams AuthParams AuthParams Pointer )

            return value;
        }
    }
}
