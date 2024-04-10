using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AdjustUrlStrategyChina                   string IL2CPP_TYPE_STRING
    // 000 AdjustUrlStrategyIndia                   string IL2CPP_TYPE_STRING
    // 000 AdjustUrlStrategyCn                      string IL2CPP_TYPE_STRING
    // 000 AdjustDataResidencyEU                    string IL2CPP_TYPE_STRING
    // 000 AdjustDataResidencyTR                    string IL2CPP_TYPE_STRING
    // 000 AdjustDataResidencyUS                    string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceAppLovinMAX         string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceMopub               string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceAdMob               string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceIronSource          string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceAdmost              string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceUnity               string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourceHeliumChartboost    string IL2CPP_TYPE_STRING
    // 000 AdjustAdRevenueSourcePublisher           string IL2CPP_TYPE_STRING
    // 010 AppToken                                 000186671BA0 ModelPrimitiveType string string string String
    // 018 SceneName                                000186671BA0 ModelPrimitiveType string string string String
    // 020 UserAgent                                000186671BA0 ModelPrimitiveType string string string String
    // 028 DefaultTracker                           000186671BA0 ModelPrimitiveType string string string String
    // 030 ExternalDeviceId                         000186671BA0 ModelPrimitiveType string string string String
    // 038 UrlStrategy                              000186671BA0 ModelPrimitiveType string string string String
    // 040 info1                                    Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 050 info2                                    Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 060 info3                                    Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 070 info4                                    Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 080 secretId                                 Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 090 delayStart                               Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 0A0 isDeviceKnown                            Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0A2 sendInBackground                         Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0A4 eventBufferingEnabled                    Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0A6 coppaCompliantEnabled                    Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0A8 playStoreKidsAppEnabled                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0AA allowSuppressLogLevel                    Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0AC needsCost                                Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0AE LaunchDeferredDeeplink                   000186595210 ModelPrimitiveType bool bool bool Bool
    // 0B0 logLevel                                 Nullable`1<AdjustLogLevel> IL2CPP_TYPE_GENERICINST
    // 0B8 Environment                              00018668EF40 ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32
    // 0C0 deferredDeeplinkDelegate                 Action`1<string> IL2CPP_TYPE_GENERICINST
    // 0C8 eventSuccessDelegate                     Action`1<AdjustEventSuccess> IL2CPP_TYPE_GENERICINST
    // 0D0 eventFailureDelegate                     Action`1<AdjustEventFailure> IL2CPP_TYPE_GENERICINST
    // 0D8 sessionSuccessDelegate                   Action`1<AdjustSessionSuccess> IL2CPP_TYPE_GENERICINST
    // 0E0 sessionFailureDelegate                   Action`1<AdjustSessionFailure> IL2CPP_TYPE_GENERICINST
    // 0E8 attributionChangedDelegate               Action`1<AdjustAttribution> IL2CPP_TYPE_GENERICINST
    // 0F0 conversionValueUpdatedDelegate           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 0F8 skad4ConversionValueUpdatedDelegate      Action`3<int, string, bool> IL2CPP_TYPE_GENERICINST
    // 100 ProcessName                              000186671BA0 ModelPrimitiveType string string string String
    // 108 readImei                                 Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 10A preinstallTrackingEnabled                Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 110 PreinstallFilePath                       000186671BA0 ModelPrimitiveType string string string String
    // 118 allowiAdInfoReading                      Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 11A allowAdServicesInfoReading               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 11C allowIdfaReading                         Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 11E skAdNetworkHandling                      Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 120 linkMeEnabled                            Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 128 logDelegate                              Action`1<string> IL2CPP_TYPE_GENERICINST
    public partial class AdjustConfig : DataModel
    {
        public string                                   AppToken                                { get; set; }
        public string                                   SceneName                               { get; set; }
        public string                                   UserAgent                               { get; set; }
        public string                                   DefaultTracker                          { get; set; }
        public string                                   ExternalDeviceId                        { get; set; }
        public string                                   UrlStrategy                             { get; set; }
        public bool                                     LaunchDeferredDeeplink                  { get; set; }
        public AdjustEnvironment                        Environment                             { get; set; }
        public string                                   ProcessName                             { get; set; }
        public string                                   PreinstallFilePath                      { get; set; }

        public static AdjustConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustConfig() { Pointer= p0 };

            value.AppToken                                  = GetString(new IntPtr(p + 0x010)); // 0245A4480A98 0x10 AppToken                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.SceneName                                 = GetString(new IntPtr(p + 0x018)); // 0245A4480AB8 0x18 SceneName                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.UserAgent                                 = GetString(new IntPtr(p + 0x020)); // 0245A4480AD8 0x20 UserAgent                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.DefaultTracker                            = GetString(new IntPtr(p + 0x028)); // 0245A4480AF8 0x28 DefaultTracker              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ExternalDeviceId                          = GetString(new IntPtr(p + 0x030)); // 0245A4480B18 0x30 ExternalDeviceId            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.UrlStrategy                               = GetString(new IntPtr(p + 0x038)); // 0245A4480B38 0x38 UrlStrategy                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.LaunchDeferredDeeplink                    = GetBool(new IntPtr(p + 0x0AE)); // 0245A4480CF8 0xAE LaunchDeferredDeeplink      ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Environment                               = (AdjustEnvironment)GetInt32(new IntPtr(p + 0x0B8)); // 0245A4480D38 0xB8 Environment                 ( 00018668EF40 ModelEnumType AdjustEnvironment AdjustEnvironment AdjustEnvironment Int32 )
            value.ProcessName                               = GetString(new IntPtr(p + 0x100)); // 0245A4480E58 0x100 ProcessName                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PreinstallFilePath                        = GetString(new IntPtr(p + 0x110)); // 0245A4480EB8 0x110 PreinstallFilePath          ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
