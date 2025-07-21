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
    // 010 KeyNetwork                               ModelPrimitiveType string string string String
    // 018 KeyAdgroup                               ModelPrimitiveType string string string String
    // 020 KeyCampaign                              ModelPrimitiveType string string string String
    // 028 KeyCreative                              ModelPrimitiveType string string string String
    // 030 KeyWillRetry                             ModelPrimitiveType string string string String
    // 038 KeyTimestamp                             ModelPrimitiveType string string string String
    // 040 KeyCallbackId                            ModelPrimitiveType string string string String
    // 048 KeyEventToken                            ModelPrimitiveType string string string String
    // 050 KeyClickLabel                            ModelPrimitiveType string string string String
    // 058 KeyTrackerName                           ModelPrimitiveType string string string String
    // 060 KeyTrackerToken                          ModelPrimitiveType string string string String
    // 068 KeyJsonResponse                          ModelPrimitiveType string string string String
    // 070 KeyCostType                              ModelPrimitiveType string string string String
    // 078 KeyCostAmount                            ModelPrimitiveType string string string String
    // 080 KeyCostCurrency                          ModelPrimitiveType string string string String
    // 088 KeyFbInstallReferrer                     ModelPrimitiveType string string string String
    // 090 KeySkadConversionValue                   ModelPrimitiveType string string string String
    // 098 KeySkadCoarseValue                       ModelPrimitiveType string string string String
    // 0A0 KeySkadLockWindow                        ModelPrimitiveType string string string String
    // 0A8 KeyTestOptionsBaseUrl                    ModelPrimitiveType string string string String
    // 0B0 KeyTestOptionsGdprUrl                    ModelPrimitiveType string string string String
    // 0B8 KeyTestOptionsSubscriptionUrl            ModelPrimitiveType string string string String
    // 0C0 KeyTestOptionsExtraPath                  ModelPrimitiveType string string string String
    // 0C8 KeyTestOptionsBasePath                   ModelPrimitiveType string string string String
    // 0D0 KeyTestOptionsGdprPath                   ModelPrimitiveType string string string String
    // 0D8 KeyTestOptionsDeleteState                ModelPrimitiveType string string string String
    // 0E0 KeyTestOptionsUseTestConnectionOptions   ModelPrimitiveType string string string String
    // 0E8 KeyTestOptionsTimerIntervalInMilliseconds ModelPrimitiveType string string string String
    // 0F0 KeyTestOptionsTimerStartInMilliseconds   ModelPrimitiveType string string string String
    // 0F8 KeyTestOptionsSessionIntervalInMilliseconds ModelPrimitiveType string string string String
    // 100 KeyTestOptionsSubsessionIntervalInMilliseconds ModelPrimitiveType string string string String
    // 108 KeyTestOptionsTeardown                   ModelPrimitiveType string string string String
    // 110 KeyTestOptionsNoBackoffWait              ModelPrimitiveType string string string String
    // 118 KeyTestOptionsiAdFrameworkEnabled        ModelPrimitiveType string string string String
    // 120 KeyTestOptionsAdServicesFrameworkEnabled ModelPrimitiveType string string string String
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

            value.KeyNetwork                                = GetString(new IntPtr(p + 0x010)); // 0x10 KeyNetwork                  ( ModelPrimitiveType string string string String )
            value.KeyAdgroup                                = GetString(new IntPtr(p + 0x018)); // 0x18 KeyAdgroup                  ( ModelPrimitiveType string string string String )
            value.KeyCampaign                               = GetString(new IntPtr(p + 0x020)); // 0x20 KeyCampaign                 ( ModelPrimitiveType string string string String )
            value.KeyCreative                               = GetString(new IntPtr(p + 0x028)); // 0x28 KeyCreative                 ( ModelPrimitiveType string string string String )
            value.KeyWillRetry                              = GetString(new IntPtr(p + 0x030)); // 0x30 KeyWillRetry                ( ModelPrimitiveType string string string String )
            value.KeyTimestamp                              = GetString(new IntPtr(p + 0x038)); // 0x38 KeyTimestamp                ( ModelPrimitiveType string string string String )
            value.KeyCallbackId                             = GetString(new IntPtr(p + 0x040)); // 0x40 KeyCallbackId               ( ModelPrimitiveType string string string String )
            value.KeyEventToken                             = GetString(new IntPtr(p + 0x048)); // 0x48 KeyEventToken               ( ModelPrimitiveType string string string String )
            value.KeyClickLabel                             = GetString(new IntPtr(p + 0x050)); // 0x50 KeyClickLabel               ( ModelPrimitiveType string string string String )
            value.KeyTrackerName                            = GetString(new IntPtr(p + 0x058)); // 0x58 KeyTrackerName              ( ModelPrimitiveType string string string String )
            value.KeyTrackerToken                           = GetString(new IntPtr(p + 0x060)); // 0x60 KeyTrackerToken             ( ModelPrimitiveType string string string String )
            value.KeyJsonResponse                           = GetString(new IntPtr(p + 0x068)); // 0x68 KeyJsonResponse             ( ModelPrimitiveType string string string String )
            value.KeyCostType                               = GetString(new IntPtr(p + 0x070)); // 0x70 KeyCostType                 ( ModelPrimitiveType string string string String )
            value.KeyCostAmount                             = GetString(new IntPtr(p + 0x078)); // 0x78 KeyCostAmount               ( ModelPrimitiveType string string string String )
            value.KeyCostCurrency                           = GetString(new IntPtr(p + 0x080)); // 0x80 KeyCostCurrency             ( ModelPrimitiveType string string string String )
            value.KeyFbInstallReferrer                      = GetString(new IntPtr(p + 0x088)); // 0x88 KeyFbInstallReferrer        ( ModelPrimitiveType string string string String )
            value.KeySkadConversionValue                    = GetString(new IntPtr(p + 0x090)); // 0x90 KeySkadConversionValue      ( ModelPrimitiveType string string string String )
            value.KeySkadCoarseValue                        = GetString(new IntPtr(p + 0x098)); // 0x98 KeySkadCoarseValue          ( ModelPrimitiveType string string string String )
            value.KeySkadLockWindow                         = GetString(new IntPtr(p + 0x0A0)); // 0xA0 KeySkadLockWindow           ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsBaseUrl                     = GetString(new IntPtr(p + 0x0A8)); // 0xA8 KeyTestOptionsBaseUrl       ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsGdprUrl                     = GetString(new IntPtr(p + 0x0B0)); // 0xB0 KeyTestOptionsGdprUrl       ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsSubscriptionUrl             = GetString(new IntPtr(p + 0x0B8)); // 0xB8 KeyTestOptionsSubscriptionUrl ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsExtraPath                   = GetString(new IntPtr(p + 0x0C0)); // 0xC0 KeyTestOptionsExtraPath     ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsBasePath                    = GetString(new IntPtr(p + 0x0C8)); // 0xC8 KeyTestOptionsBasePath      ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsGdprPath                    = GetString(new IntPtr(p + 0x0D0)); // 0xD0 KeyTestOptionsGdprPath      ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsDeleteState                 = GetString(new IntPtr(p + 0x0D8)); // 0xD8 KeyTestOptionsDeleteState   ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsUseTestConnectionOptions    = GetString(new IntPtr(p + 0x0E0)); // 0xE0 KeyTestOptionsUseTestConnectionOptions ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsTimerIntervalInMilliseconds = GetString(new IntPtr(p + 0x0E8)); // 0xE8 KeyTestOptionsTimerIntervalInMilliseconds ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsTimerStartInMilliseconds    = GetString(new IntPtr(p + 0x0F0)); // 0xF0 KeyTestOptionsTimerStartInMilliseconds ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsSessionIntervalInMilliseconds = GetString(new IntPtr(p + 0x0F8)); // 0xF8 KeyTestOptionsSessionIntervalInMilliseconds ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsSubsessionIntervalInMilliseconds = GetString(new IntPtr(p + 0x100)); // 0x100 KeyTestOptionsSubsessionIntervalInMilliseconds ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsTeardown                    = GetString(new IntPtr(p + 0x108)); // 0x108 KeyTestOptionsTeardown      ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsNoBackoffWait               = GetString(new IntPtr(p + 0x110)); // 0x110 KeyTestOptionsNoBackoffWait ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsiAdFrameworkEnabled         = GetString(new IntPtr(p + 0x118)); // 0x118 KeyTestOptionsiAdFrameworkEnabled ( ModelPrimitiveType string string string String )
            value.KeyTestOptionsAdServicesFrameworkEnabled  = GetString(new IntPtr(p + 0x120)); // 0x120 KeyTestOptionsAdServicesFrameworkEnabled ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
