using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 confirmSubscriptionPriceChangeName       TelemetryMetricDefinition IL2CPP_TYPE_VALUETYPE
    // 010 ContinuePromotionalPurchasesName         ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 020 DequeueQueryProductsTimeName             ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 030 DequeueQueryPurchasesTimeName            ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 040 FetchStorePromotionOrderName             ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 050 FetchStorePromotionVisibilityName        ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 060 InitPurchaseName                         ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 070 PackageInitTimeName                      ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 080 PresentCodeRedemptionSheetName           ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 090 RefreshAppReceiptName                    ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0A0 RestoreTransactionName                   ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0B0 RetrieveProductsName                     ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0C0 SetStorePromotionOrderName               ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0D0 SetStorePromotionVisibilityName          ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    // 0E0 UpgradeDowngradeSubscriptionName         ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32
    public partial class TelemetryMetricDefinitions : DataModel
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
            var value   = new TelemetryMetricDefinitions() { Pointer= p0 };

            value.ContinuePromotionalPurchasesName          = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x010)); // 0x10 ContinuePromotionalPurchasesName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.DequeueQueryProductsTimeName              = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x020)); // 0x20 DequeueQueryProductsTimeName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.DequeueQueryPurchasesTimeName             = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x030)); // 0x30 DequeueQueryPurchasesTimeName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.FetchStorePromotionOrderName              = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x040)); // 0x40 FetchStorePromotionOrderName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.FetchStorePromotionVisibilityName         = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x050)); // 0x50 FetchStorePromotionVisibilityName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.InitPurchaseName                          = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x060)); // 0x60 InitPurchaseName            ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.PackageInitTimeName                       = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x070)); // 0x70 PackageInitTimeName         ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.PresentCodeRedemptionSheetName            = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x080)); // 0x80 PresentCodeRedemptionSheetName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.RefreshAppReceiptName                     = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x090)); // 0x90 RefreshAppReceiptName       ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.RestoreTransactionName                    = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 RestoreTransactionName      ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.RetrieveProductsName                      = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 RetrieveProductsName        ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.SetStorePromotionOrderName                = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 SetStorePromotionOrderName  ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.SetStorePromotionVisibilityName           = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 SetStorePromotionVisibilityName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )
            value.UpgradeDowngradeSubscriptionName          = (TelemetryMetricDefinition)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 UpgradeDowngradeSubscriptionName ( ModelEnumType TelemetryMetricDefinition TelemetryMetricDefinition TelemetryMetricDefinition Int32 )

            return value;
        }
    }
}
