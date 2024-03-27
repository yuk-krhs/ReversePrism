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
    public partial class AdjustUtils
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
            var value   = new AdjustUtils();

            value.KeyNetwork                                = GetString(new IntPtr(p + 0x010)); // 0270DBB0E718 0x10 KeyNetwork                  ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyAdgroup                                = GetString(new IntPtr(p + 0x018)); // 0270DBB0E738 0x18 KeyAdgroup                  ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCampaign                               = GetString(new IntPtr(p + 0x020)); // 0270DBB0E758 0x20 KeyCampaign                 ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCreative                               = GetString(new IntPtr(p + 0x028)); // 0270DBB0E778 0x28 KeyCreative                 ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyWillRetry                              = GetString(new IntPtr(p + 0x030)); // 0270DBB0E798 0x30 KeyWillRetry                ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTimestamp                              = GetString(new IntPtr(p + 0x038)); // 0270DBB0E7B8 0x38 KeyTimestamp                ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCallbackId                             = GetString(new IntPtr(p + 0x040)); // 0270DBB0E7D8 0x40 KeyCallbackId               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyEventToken                             = GetString(new IntPtr(p + 0x048)); // 0270DBB0E7F8 0x48 KeyEventToken               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyClickLabel                             = GetString(new IntPtr(p + 0x050)); // 0270DBB0E818 0x50 KeyClickLabel               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTrackerName                            = GetString(new IntPtr(p + 0x058)); // 0270DBB0E838 0x58 KeyTrackerName              ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTrackerToken                           = GetString(new IntPtr(p + 0x060)); // 0270DBB0E858 0x60 KeyTrackerToken             ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyJsonResponse                           = GetString(new IntPtr(p + 0x068)); // 0270DBB0E878 0x68 KeyJsonResponse             ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCostType                               = GetString(new IntPtr(p + 0x070)); // 0270DBB0E898 0x70 KeyCostType                 ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCostAmount                             = GetString(new IntPtr(p + 0x078)); // 0270DBB0E8B8 0x78 KeyCostAmount               ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyCostCurrency                           = GetString(new IntPtr(p + 0x080)); // 0270DBB0E8D8 0x80 KeyCostCurrency             ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyFbInstallReferrer                      = GetString(new IntPtr(p + 0x088)); // 0270DBB0E8F8 0x88 KeyFbInstallReferrer        ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeySkadConversionValue                    = GetString(new IntPtr(p + 0x090)); // 0270DBB0E918 0x90 KeySkadConversionValue      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeySkadCoarseValue                        = GetString(new IntPtr(p + 0x098)); // 0270DBB0E938 0x98 KeySkadCoarseValue          ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeySkadLockWindow                         = GetString(new IntPtr(p + 0x0A0)); // 0270DBB0E958 0xA0 KeySkadLockWindow           ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsBaseUrl                     = GetString(new IntPtr(p + 0x0A8)); // 0270DBB0E978 0xA8 KeyTestOptionsBaseUrl       ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsGdprUrl                     = GetString(new IntPtr(p + 0x0B0)); // 0270DBB0E998 0xB0 KeyTestOptionsGdprUrl       ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsSubscriptionUrl             = GetString(new IntPtr(p + 0x0B8)); // 0270DBB0E9B8 0xB8 KeyTestOptionsSubscriptionUrl ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsExtraPath                   = GetString(new IntPtr(p + 0x0C0)); // 0270DBB0E9D8 0xC0 KeyTestOptionsExtraPath     ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsBasePath                    = GetString(new IntPtr(p + 0x0C8)); // 0270DBB0E9F8 0xC8 KeyTestOptionsBasePath      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsGdprPath                    = GetString(new IntPtr(p + 0x0D0)); // 0270DBB0EA18 0xD0 KeyTestOptionsGdprPath      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsDeleteState                 = GetString(new IntPtr(p + 0x0D8)); // 0270DBB0EA38 0xD8 KeyTestOptionsDeleteState   ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsUseTestConnectionOptions    = GetString(new IntPtr(p + 0x0E0)); // 0270DBB0EA58 0xE0 KeyTestOptionsUseTestConnectionOptions ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsTimerIntervalInMilliseconds = GetString(new IntPtr(p + 0x0E8)); // 0270DBB0EA78 0xE8 KeyTestOptionsTimerIntervalInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsTimerStartInMilliseconds    = GetString(new IntPtr(p + 0x0F0)); // 0270DBB0EA98 0xF0 KeyTestOptionsTimerStartInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsSessionIntervalInMilliseconds = GetString(new IntPtr(p + 0x0F8)); // 0270DBB0EAB8 0xF8 KeyTestOptionsSessionIntervalInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsSubsessionIntervalInMilliseconds = GetString(new IntPtr(p + 0x100)); // 0270DBB0EAD8 0x100 KeyTestOptionsSubsessionIntervalInMilliseconds ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsTeardown                    = GetString(new IntPtr(p + 0x108)); // 0270DBB0EAF8 0x108 KeyTestOptionsTeardown      ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsNoBackoffWait               = GetString(new IntPtr(p + 0x110)); // 0270DBB0EB18 0x110 KeyTestOptionsNoBackoffWait ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsiAdFrameworkEnabled         = GetString(new IntPtr(p + 0x118)); // 0270DBB0EB38 0x118 KeyTestOptionsiAdFrameworkEnabled ( 000186672D00 ModelPrimitiveType string string string String )
            value.KeyTestOptionsAdServicesFrameworkEnabled  = GetString(new IntPtr(p + 0x120)); // 0270DBB0EB58 0x120 KeyTestOptionsAdServicesFrameworkEnabled ( 000186672D00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
