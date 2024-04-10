using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KeyAdid                                  string IL2CPP_TYPE_STRING
    // 008 KeyMessage                               string IL2CPP_TYPE_STRING
    // 010 KeyNetwork                               000186672D00 ModelPrimitiveType string string string String
    // 018 KeyAdgroup                               000186672D00 ModelPrimitiveType string string string String
    // 020 KeyCampaign                              000186672D00 ModelPrimitiveType string string string String
    // 028 KeyCreative                              000186672D00 ModelPrimitiveType string string string String
    // 030 KeyWillRetry                             000186672D00 ModelPrimitiveType string string string String
    // 038 KeyTimestamp                             000186672D00 ModelPrimitiveType string string string String
    // 040 KeyCallbackId                            000186672D00 ModelPrimitiveType string string string String
    // 048 KeyEventToken                            000186672D00 ModelPrimitiveType string string string String
    // 050 KeyClickLabel                            000186672D00 ModelPrimitiveType string string string String
    // 058 KeyTrackerName                           000186672D00 ModelPrimitiveType string string string String
    // 060 KeyTrackerToken                          000186672D00 ModelPrimitiveType string string string String
    // 068 KeyJsonResponse                          000186672D00 ModelPrimitiveType string string string String
    // 070 KeyCostType                              000186672D00 ModelPrimitiveType string string string String
    // 078 KeyCostAmount                            000186672D00 ModelPrimitiveType string string string String
    // 080 KeyCostCurrency                          000186672D00 ModelPrimitiveType string string string String
    // 088 KeyFbInstallReferrer                     000186672D00 ModelPrimitiveType string string string String
    // 090 KeySkadConversionValue                   000186672D00 ModelPrimitiveType string string string String
    // 098 KeySkadCoarseValue                       000186672D00 ModelPrimitiveType string string string String
    // 0A0 KeySkadLockWindow                        000186672D00 ModelPrimitiveType string string string String
    // 0A8 KeyTestOptionsBaseUrl                    000186672D00 ModelPrimitiveType string string string String
    // 0B0 KeyTestOptionsGdprUrl                    000186672D00 ModelPrimitiveType string string string String
    // 0B8 KeyTestOptionsSubscriptionUrl            000186672D00 ModelPrimitiveType string string string String
    // 0C0 KeyTestOptionsExtraPath                  000186672D00 ModelPrimitiveType string string string String
    // 0C8 KeyTestOptionsBasePath                   000186672D00 ModelPrimitiveType string string string String
    // 0D0 KeyTestOptionsGdprPath                   000186672D00 ModelPrimitiveType string string string String
    // 0D8 KeyTestOptionsDeleteState                000186672D00 ModelPrimitiveType string string string String
    // 0E0 KeyTestOptionsUseTestConnectionOptions   000186672D00 ModelPrimitiveType string string string String
    // 0E8 KeyTestOptionsTimerIntervalInMilliseconds 000186672D00 ModelPrimitiveType string string string String
    // 0F0 KeyTestOptionsTimerStartInMilliseconds   000186672D00 ModelPrimitiveType string string string String
    // 0F8 KeyTestOptionsSessionIntervalInMilliseconds 000186672D00 ModelPrimitiveType string string string String
    // 100 KeyTestOptionsSubsessionIntervalInMilliseconds 000186672D00 ModelPrimitiveType string string string String
    // 108 KeyTestOptionsTeardown                   000186672D00 ModelPrimitiveType string string string String
    // 110 KeyTestOptionsNoBackoffWait              000186672D00 ModelPrimitiveType string string string String
    // 118 KeyTestOptionsiAdFrameworkEnabled        000186672D00 ModelPrimitiveType string string string String
    // 120 KeyTestOptionsAdServicesFrameworkEnabled 000186672D00 ModelPrimitiveType string string string String
    public partial class AdjustUtils : DataModel
    {
        public string                                   KeyNetwork                              { get; set; }
        public string                                   KeyAdgroup                              { get; set; }
        public string                                   KeyCampaign                             { get; set; }
        public string                                   KeyCreative                             { get; set; }
        public string                                   KeyWillRetry                            { get; set; }
        public string                                   KeyTimestamp                            { get; set; }
        public string                                   KeyCallbackId                           { get; set; }
        public string                                   KeyEventToken                           { get; set; }
        public string                                   KeyClickLabel                           { get; set; }
        public string                                   KeyTrackerName                          { get; set; }
        public string                                   KeyTrackerToken                         { get; set; }
        public string                                   KeyJsonResponse                         { get; set; }
        public string                                   KeyCostType                             { get; set; }
        public string                                   KeyCostAmount                           { get; set; }
        public string                                   KeyCostCurrency                         { get; set; }
        public string                                   KeyFbInstallReferrer                    { get; set; }
        public string                                   KeySkadConversionValue                  { get; set; }
        public string                                   KeySkadCoarseValue                      { get; set; }
        public string                                   KeySkadLockWindow                       { get; set; }
        public string                                   KeyTestOptionsBaseUrl                   { get; set; }
        public string                                   KeyTestOptionsGdprUrl                   { get; set; }
        public string                                   KeyTestOptionsSubscriptionUrl           { get; set; }
        public string                                   KeyTestOptionsExtraPath                 { get; set; }
        public string                                   KeyTestOptionsBasePath                  { get; set; }
        public string                                   KeyTestOptionsGdprPath                  { get; set; }
        public string                                   KeyTestOptionsDeleteState               { get; set; }
        public string                                   KeyTestOptionsUseTestConnectionOptions  { get; set; }
        public string                                   KeyTestOptionsTimerIntervalInMilliseconds { get; set; }
        public string                                   KeyTestOptionsTimerStartInMilliseconds  { get; set; }
        public string                                   KeyTestOptionsSessionIntervalInMilliseconds { get; set; }
        public string                                   KeyTestOptionsSubsessionIntervalInMilliseconds { get; set; }
        public string                                   KeyTestOptionsTeardown                  { get; set; }
        public string                                   KeyTestOptionsNoBackoffWait             { get; set; }
        public string                                   KeyTestOptionsiAdFrameworkEnabled       { get; set; }
        public string                                   KeyTestOptionsAdServicesFrameworkEnabled { get; set; }

        public static AdjustUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustUtils() { Pointer= p0 };

            value.KeyNetwork                                = GetString(new IntPtr(p + 0x010)); // 02466BB95BF8 0x10 KeyNetwork                  ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyAdgroup                                = GetString(new IntPtr(p + 0x018)); // 02466BB95C18 0x18 KeyAdgroup                  ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCampaign                               = GetString(new IntPtr(p + 0x020)); // 02466BB95C38 0x20 KeyCampaign                 ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCreative                               = GetString(new IntPtr(p + 0x028)); // 02466BB95C58 0x28 KeyCreative                 ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyWillRetry                              = GetString(new IntPtr(p + 0x030)); // 02466BB95C78 0x30 KeyWillRetry                ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTimestamp                              = GetString(new IntPtr(p + 0x038)); // 02466BB95C98 0x38 KeyTimestamp                ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCallbackId                             = GetString(new IntPtr(p + 0x040)); // 02466BB95CB8 0x40 KeyCallbackId               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyEventToken                             = GetString(new IntPtr(p + 0x048)); // 02466BB95CD8 0x48 KeyEventToken               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyClickLabel                             = GetString(new IntPtr(p + 0x050)); // 02466BB95CF8 0x50 KeyClickLabel               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTrackerName                            = GetString(new IntPtr(p + 0x058)); // 02466BB95D18 0x58 KeyTrackerName              ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTrackerToken                           = GetString(new IntPtr(p + 0x060)); // 02466BB95D38 0x60 KeyTrackerToken             ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyJsonResponse                           = GetString(new IntPtr(p + 0x068)); // 02466BB95D58 0x68 KeyJsonResponse             ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCostType                               = GetString(new IntPtr(p + 0x070)); // 02466BB95D78 0x70 KeyCostType                 ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCostAmount                             = GetString(new IntPtr(p + 0x078)); // 02466BB95D98 0x78 KeyCostAmount               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCostCurrency                           = GetString(new IntPtr(p + 0x080)); // 02466BB95DB8 0x80 KeyCostCurrency             ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyFbInstallReferrer                      = GetString(new IntPtr(p + 0x088)); // 02466BB95DD8 0x88 KeyFbInstallReferrer        ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeySkadConversionValue                    = GetString(new IntPtr(p + 0x090)); // 02466BB95DF8 0x90 KeySkadConversionValue      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeySkadCoarseValue                        = GetString(new IntPtr(p + 0x098)); // 02466BB95E18 0x98 KeySkadCoarseValue          ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeySkadLockWindow                         = GetString(new IntPtr(p + 0x0A0)); // 02466BB95E38 0xA0 KeySkadLockWindow           ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsBaseUrl                     = GetString(new IntPtr(p + 0x0A8)); // 02466BB95E58 0xA8 KeyTestOptionsBaseUrl       ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsGdprUrl                     = GetString(new IntPtr(p + 0x0B0)); // 02466BB95E78 0xB0 KeyTestOptionsGdprUrl       ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsSubscriptionUrl             = GetString(new IntPtr(p + 0x0B8)); // 02466BB95E98 0xB8 KeyTestOptionsSubscriptionUrl ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsExtraPath                   = GetString(new IntPtr(p + 0x0C0)); // 02466BB95EB8 0xC0 KeyTestOptionsExtraPath     ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsBasePath                    = GetString(new IntPtr(p + 0x0C8)); // 02466BB95ED8 0xC8 KeyTestOptionsBasePath      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsGdprPath                    = GetString(new IntPtr(p + 0x0D0)); // 02466BB95EF8 0xD0 KeyTestOptionsGdprPath      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsDeleteState                 = GetString(new IntPtr(p + 0x0D8)); // 02466BB95F18 0xD8 KeyTestOptionsDeleteState   ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsUseTestConnectionOptions    = GetString(new IntPtr(p + 0x0E0)); // 02466BB95F38 0xE0 KeyTestOptionsUseTestConnectionOptions ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsTimerIntervalInMilliseconds = GetString(new IntPtr(p + 0x0E8)); // 02466BB95F58 0xE8 KeyTestOptionsTimerIntervalInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsTimerStartInMilliseconds    = GetString(new IntPtr(p + 0x0F0)); // 02466BB95F78 0xF0 KeyTestOptionsTimerStartInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsSessionIntervalInMilliseconds = GetString(new IntPtr(p + 0x0F8)); // 02466BB95F98 0xF8 KeyTestOptionsSessionIntervalInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsSubsessionIntervalInMilliseconds = GetString(new IntPtr(p + 0x100)); // 02466BB95FB8 0x100 KeyTestOptionsSubsessionIntervalInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsTeardown                    = GetString(new IntPtr(p + 0x108)); // 02466BB95FD8 0x108 KeyTestOptionsTeardown      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsNoBackoffWait               = GetString(new IntPtr(p + 0x110)); // 02466BB95FF8 0x110 KeyTestOptionsNoBackoffWait ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsiAdFrameworkEnabled         = GetString(new IntPtr(p + 0x118)); // 02466BB96018 0x118 KeyTestOptionsiAdFrameworkEnabled ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsAdServicesFrameworkEnabled  = GetString(new IntPtr(p + 0x120)); // 02466BB96038 0x120 KeyTestOptionsAdServicesFrameworkEnabled ( 000186672D00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
