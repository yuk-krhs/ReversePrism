using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 confirmSubscriptionPriceChangeName       TelemetryMetricDefinition IL2CPP_TYPE_VALUETYPE
    // 010 ContinuePromotionalPurchasesName         00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 020 DequeueQueryProductsTimeName             00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 030 DequeueQueryPurchasesTimeName            00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 040 FetchStorePromotionOrderName             00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 050 FetchStorePromotionVisibilityName        00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 060 InitPurchaseName                         00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 070 PackageInitTimeName                      00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 080 PresentCodeRedemptionSheetName           00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 090 RefreshAppReceiptName                    00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0A0 RestoreTransactionName                   00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0B0 RetrieveProductsName                     00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0C0 SetStorePromotionOrderName               00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0D0 SetStorePromotionVisibilityName          00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0E0 UpgradeDowngradeSubscriptionName         00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    public partial class TelemetryMetricDefinitions
    {
        public TelemetryMetricDefinition                ContinuePromotionalPurchasesName        { get; set; }
        public TelemetryMetricDefinition                DequeueQueryProductsTimeName            { get; set; }
        public TelemetryMetricDefinition                DequeueQueryPurchasesTimeName           { get; set; }
        public TelemetryMetricDefinition                FetchStorePromotionOrderName            { get; set; }
        public TelemetryMetricDefinition                FetchStorePromotionVisibilityName       { get; set; }
        public TelemetryMetricDefinition                InitPurchaseName                        { get; set; }
        public TelemetryMetricDefinition                PackageInitTimeName                     { get; set; }
        public TelemetryMetricDefinition                PresentCodeRedemptionSheetName          { get; set; }
        public TelemetryMetricDefinition                RefreshAppReceiptName                   { get; set; }
        public TelemetryMetricDefinition                RestoreTransactionName                  { get; set; }
        public TelemetryMetricDefinition                RetrieveProductsName                    { get; set; }
        public TelemetryMetricDefinition                SetStorePromotionOrderName              { get; set; }
        public TelemetryMetricDefinition                SetStorePromotionVisibilityName         { get; set; }
        public TelemetryMetricDefinition                UpgradeDowngradeSubscriptionName        { get; set; }

        public static TelemetryMetricDefinitions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricDefinitions();

            value.ContinuePromotionalPurchasesName          = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x010)); // 0270066C5FA8 0x10 ContinuePromotionalPurchasesName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.DequeueQueryProductsTimeName              = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x020)); // 0270066C5FC8 0x20 DequeueQueryProductsTimeName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.DequeueQueryPurchasesTimeName             = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x030)); // 0270066C5FE8 0x30 DequeueQueryPurchasesTimeName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.FetchStorePromotionOrderName              = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x040)); // 0270066C6008 0x40 FetchStorePromotionOrderName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.FetchStorePromotionVisibilityName         = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x050)); // 0270066C6028 0x50 FetchStorePromotionVisibilityName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.InitPurchaseName                          = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x060)); // 0270066C6048 0x60 InitPurchaseName            ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.PackageInitTimeName                       = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x070)); // 0270066C6068 0x70 PackageInitTimeName         ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.PresentCodeRedemptionSheetName            = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x080)); // 0270066C6088 0x80 PresentCodeRedemptionSheetName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.RefreshAppReceiptName                     = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x090)); // 0270066C60A8 0x90 RefreshAppReceiptName       ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.RestoreTransactionName                    = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0A0)); // 0270066C60C8 0xA0 RestoreTransactionName      ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.RetrieveProductsName                      = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0B0)); // 0270066C60E8 0xB0 RetrieveProductsName        ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.SetStorePromotionOrderName                = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0C0)); // 0270066C6108 0xC0 SetStorePromotionOrderName  ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.SetStorePromotionVisibilityName           = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0D0)); // 0270066C6128 0xD0 SetStorePromotionVisibilityName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.UpgradeDowngradeSubscriptionName          = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0E0)); // 0270066C6148 0xE0 UpgradeDowngradeSubscriptionName ( 00018662AAF0 ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )

            return value;
        }
    }
}
