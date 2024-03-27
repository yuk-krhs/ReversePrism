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
    // 020 StartManually                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 AppToken                                 0001866722E0 ModelPrimitiveType string string string String
    // 030 Environment                              00018668F140 ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32
    // 034 LogLevel                                 000186690780 ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32
    // 038 EventBuffering                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 039 SendInBackground                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 03A LaunchDeferredDeeplink                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 03B NeedsCost                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 03C CoppaCompliant                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 03D LinkMe                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 DefaultTracker                           0001866722E0 ModelPrimitiveType string string string String
    // 048 UrlStrategy                              000186692250 ModelEnumType AdjustUrlStrategy AdjustUrlStrategy AdjustUrlStrategy Int32
    // 050 StartDelay                               0001865C2E50 ModelPrimitiveType double double double Double
    // 058 SecretId                                 0001865F7E40 ModelPrimitiveType long long long Int64
    // 060 Info1                                    0001865F7E40 ModelPrimitiveType long long long Int64
    // 068 Info2                                    0001865F7E40 ModelPrimitiveType long long long Int64
    // 070 Info3                                    0001865F7E40 ModelPrimitiveType long long long Int64
    // 078 Info4                                    0001865F7E40 ModelPrimitiveType long long long Int64
    // 080 PreinstallTracking                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 088 PreinstallFilePath                       0001866722E0 ModelPrimitiveType string string string String
    // 090 PlayStoreKidsApp                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 091 IadInfoReading                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 092 AdServicesInfoReading                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 093 IdfaInfoReading                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 094 SkAdNetworkHandling                      000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class Adjust
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
            var value   = new Adjust();

            value.StartManually                             = GetBool(new IntPtr(p + 0x020)); // 0270043756D0 0x20 StartManually               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AppToken                                  = GetString(new IntPtr(p + 0x028)); // 0270043756F0 0x28 AppToken                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Environment                               = (AdjustEnvironment)GetInt32(new IntPtr(p + 0x030)); // 027004375710 0x30 Environment                 ( 00018668F140 ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32 )
            value.LogLevel                                  = (AdjustLogLevel)GetInt32(new IntPtr(p + 0x034)); // 027004375730 0x34 LogLevel                    ( 000186690780 ModelEnumType AdjustLogLevel AdjustLogLevel AdjustLogLevel Int32 )
            value.EventBuffering                            = GetBool(new IntPtr(p + 0x038)); // 027004375750 0x38 EventBuffering              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SendInBackground                          = GetBool(new IntPtr(p + 0x039)); // 027004375770 0x39 SendInBackground            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LaunchDeferredDeeplink                    = GetBool(new IntPtr(p + 0x03A)); // 027004375790 0x3A LaunchDeferredDeeplink      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedsCost                                 = GetBool(new IntPtr(p + 0x03B)); // 0270043757B0 0x3B NeedsCost                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CoppaCompliant                            = GetBool(new IntPtr(p + 0x03C)); // 0270043757D0 0x3C CoppaCompliant              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LinkMe                                    = GetBool(new IntPtr(p + 0x03D)); // 0270043757F0 0x3D LinkMe                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultTracker                            = GetString(new IntPtr(p + 0x040)); // 027004375810 0x40 DefaultTracker              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UrlStrategy                               = (AdjustUrlStrategy)GetInt32(new IntPtr(p + 0x048)); // 027004375830 0x48 UrlStrategy                 ( 000186692250 ModelEnumType AdjustUrlStrategy AdjustUrlStrategy AdjustUrlStrategy Int32 )
            value.StartDelay                                = GetDouble(new IntPtr(p + 0x050)); // 027004375850 0x50 StartDelay                  ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.SecretId                                  = GetInt64(new IntPtr(p + 0x058)); // 027004375870 0x58 SecretId                    ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Info1                                     = GetInt64(new IntPtr(p + 0x060)); // 027004375890 0x60 Info1                       ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Info2                                     = GetInt64(new IntPtr(p + 0x068)); // 0270043758B0 0x68 Info2                       ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Info3                                     = GetInt64(new IntPtr(p + 0x070)); // 0270043758D0 0x70 Info3                       ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.Info4                                     = GetInt64(new IntPtr(p + 0x078)); // 0270043758F0 0x78 Info4                       ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.PreinstallTracking                        = GetBool(new IntPtr(p + 0x080)); // 027004375910 0x80 PreinstallTracking          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PreinstallFilePath                        = GetString(new IntPtr(p + 0x088)); // 027004375930 0x88 PreinstallFilePath          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PlayStoreKidsApp                          = GetBool(new IntPtr(p + 0x090)); // 027004375950 0x90 PlayStoreKidsApp            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IadInfoReading                            = GetBool(new IntPtr(p + 0x091)); // 027004375970 0x91 IadInfoReading              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AdServicesInfoReading                     = GetBool(new IntPtr(p + 0x092)); // 027004375990 0x92 AdServicesInfoReading       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IdfaInfoReading                           = GetBool(new IntPtr(p + 0x093)); // 0270043759B0 0x93 IdfaInfoReading             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SkAdNetworkHandling                       = GetBool(new IntPtr(p + 0x094)); // 0270043759D0 0x94 SkAdNetworkHandling         ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
