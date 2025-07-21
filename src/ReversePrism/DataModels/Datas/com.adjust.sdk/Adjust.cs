using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 errorMsgEditor                           string IL2CPP_TYPE_STRING
    // 000 errorMsgStart                            string IL2CPP_TYPE_STRING
    // 000 errorMsgPlatform                         string IL2CPP_TYPE_STRING
    // 020 StartManually                            ModelPrimitiveType bool bool bool Bool
    // 028 AppToken                                 ModelPrimitiveType string string string String
    // 030 Environment                              ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32
    // 034 LogLevel                                 ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32
    // 038 EventBuffering                           ModelPrimitiveType bool bool bool Bool
    // 039 SendInBackground                         ModelPrimitiveType bool bool bool Bool
    // 03A LaunchDeferredDeeplink                   ModelPrimitiveType bool bool bool Bool
    // 03B NeedsCost                                ModelPrimitiveType bool bool bool Bool
    // 03C CoppaCompliant                           ModelPrimitiveType bool bool bool Bool
    // 03D LinkMe                                   ModelPrimitiveType bool bool bool Bool
    // 040 DefaultTracker                           ModelPrimitiveType string string string String
    // 048 UrlStrategy                              ModelEnumType AdjustUrlStrategy AdjustUrlStrategy AdjustUrlStrategy Int32
    // 050 StartDelay                               ModelPrimitiveType double double double Double
    // 058 SecretId                                 ModelPrimitiveType long long long Int64
    // 060 Info1                                    ModelPrimitiveType long long long Int64
    // 068 Info2                                    ModelPrimitiveType long long long Int64
    // 070 Info3                                    ModelPrimitiveType long long long Int64
    // 078 Info4                                    ModelPrimitiveType long long long Int64
    // 080 PreinstallTracking                       ModelPrimitiveType bool bool bool Bool
    // 088 PreinstallFilePath                       ModelPrimitiveType string string string String
    // 090 PlayStoreKidsApp                         ModelPrimitiveType bool bool bool Bool
    // 091 IadInfoReading                           ModelPrimitiveType bool bool bool Bool
    // 092 AdServicesInfoReading                    ModelPrimitiveType bool bool bool Bool
    // 093 IdfaInfoReading                          ModelPrimitiveType bool bool bool Bool
    // 094 SkAdNetworkHandling                      ModelPrimitiveType bool bool bool Bool
    public partial class Adjust : DataModel
    {
        public bool                                     StartManually                           { get; set; }
        public string                                   AppToken                                { get; set; }
        public AdjustEnvironment                        Environment                             { get; set; }
        public AdjustLogLevel                           LogLevel                                { get; set; }
        public bool                                     EventBuffering                          { get; set; }
        public bool                                     SendInBackground                        { get; set; }
        public bool                                     LaunchDeferredDeeplink                  { get; set; }
        public bool                                     NeedsCost                               { get; set; }
        public bool                                     CoppaCompliant                          { get; set; }
        public bool                                     LinkMe                                  { get; set; }
        public string                                   DefaultTracker                          { get; set; }
        public AdjustUrlStrategy                        UrlStrategy                             { get; set; }
        public double                                   StartDelay                              { get; set; }
        public long                                     SecretId                                { get; set; }
        public long                                     Info1                                   { get; set; }
        public long                                     Info2                                   { get; set; }
        public long                                     Info3                                   { get; set; }
        public long                                     Info4                                   { get; set; }
        public bool                                     PreinstallTracking                      { get; set; }
        public string                                   PreinstallFilePath                      { get; set; }
        public bool                                     PlayStoreKidsApp                        { get; set; }
        public bool                                     IadInfoReading                          { get; set; }
        public bool                                     AdServicesInfoReading                   { get; set; }
        public bool                                     IdfaInfoReading                         { get; set; }
        public bool                                     SkAdNetworkHandling                     { get; set; }

        public static Adjust? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Adjust() { Pointer= p0 };

            value.StartManually                             = GetBool(new IntPtr(p + 0x020)); // 0x20 StartManually               ( ModelPrimitiveType bool bool bool Bool )
            value.AppToken                                  = GetString(new IntPtr(p + 0x028)); // 0x28 AppToken                    ( ModelPrimitiveType string string string String )
            value.Environment                               = (AdjustEnvironment)GetInt32(new IntPtr(p + 0x030)); // 0x30 Environment                 ( ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32 )
            value.LogLevel                                  = (AdjustLogLevel)GetInt32(new IntPtr(p + 0x034)); // 0x34 LogLevel                    ( ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32 )
            value.EventBuffering                            = GetBool(new IntPtr(p + 0x038)); // 0x38 EventBuffering              ( ModelPrimitiveType bool bool bool Bool )
            value.SendInBackground                          = GetBool(new IntPtr(p + 0x039)); // 0x39 SendInBackground            ( ModelPrimitiveType bool bool bool Bool )
            value.LaunchDeferredDeeplink                    = GetBool(new IntPtr(p + 0x03A)); // 0x3A LaunchDeferredDeeplink      ( ModelPrimitiveType bool bool bool Bool )
            value.NeedsCost                                 = GetBool(new IntPtr(p + 0x03B)); // 0x3B NeedsCost                   ( ModelPrimitiveType bool bool bool Bool )
            value.CoppaCompliant                            = GetBool(new IntPtr(p + 0x03C)); // 0x3C CoppaCompliant              ( ModelPrimitiveType bool bool bool Bool )
            value.LinkMe                                    = GetBool(new IntPtr(p + 0x03D)); // 0x3D LinkMe                      ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultTracker                            = GetString(new IntPtr(p + 0x040)); // 0x40 DefaultTracker              ( ModelPrimitiveType string string string String )
            value.UrlStrategy                               = (AdjustUrlStrategy)GetInt32(new IntPtr(p + 0x048)); // 0x48 UrlStrategy                 ( ModelEnumType AdjustUrlStrategy AdjustUrlStrategy AdjustUrlStrategy Int32 )
            value.StartDelay                                = GetDouble(new IntPtr(p + 0x050)); // 0x50 StartDelay                  ( ModelPrimitiveType double double double Double )
            value.SecretId                                  = GetInt64(new IntPtr(p + 0x058)); // 0x58 SecretId                    ( ModelPrimitiveType long long long Int64 )
            value.Info1                                     = GetInt64(new IntPtr(p + 0x060)); // 0x60 Info1                       ( ModelPrimitiveType long long long Int64 )
            value.Info2                                     = GetInt64(new IntPtr(p + 0x068)); // 0x68 Info2                       ( ModelPrimitiveType long long long Int64 )
            value.Info3                                     = GetInt64(new IntPtr(p + 0x070)); // 0x70 Info3                       ( ModelPrimitiveType long long long Int64 )
            value.Info4                                     = GetInt64(new IntPtr(p + 0x078)); // 0x78 Info4                       ( ModelPrimitiveType long long long Int64 )
            value.PreinstallTracking                        = GetBool(new IntPtr(p + 0x080)); // 0x80 PreinstallTracking          ( ModelPrimitiveType bool bool bool Bool )
            value.PreinstallFilePath                        = GetString(new IntPtr(p + 0x088)); // 0x88 PreinstallFilePath          ( ModelPrimitiveType string string string String )
            value.PlayStoreKidsApp                          = GetBool(new IntPtr(p + 0x090)); // 0x90 PlayStoreKidsApp            ( ModelPrimitiveType bool bool bool Bool )
            value.IadInfoReading                            = GetBool(new IntPtr(p + 0x091)); // 0x91 IadInfoReading              ( ModelPrimitiveType bool bool bool Bool )
            value.AdServicesInfoReading                     = GetBool(new IntPtr(p + 0x092)); // 0x92 AdServicesInfoReading       ( ModelPrimitiveType bool bool bool Bool )
            value.IdfaInfoReading                           = GetBool(new IntPtr(p + 0x093)); // 0x93 IdfaInfoReading             ( ModelPrimitiveType bool bool bool Bool )
            value.SkAdNetworkHandling                       = GetBool(new IntPtr(p + 0x094)); // 0x94 SkAdNetworkHandling         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
