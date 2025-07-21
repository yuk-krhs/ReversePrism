using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 Type                                     ModelEnumType ProductType ProductType ProductType Int32
    // 020 StoreIDs                                 ModelClassListType List`1<StoreID> List`1<StoreID> List<StoreID> Pointer
    // 028 DefaultDescription                       ModelClassType LocalizedProductDescription LocalizedProductDescription LocalizedProductDescription Pointer
    // 030 ScreenshotPath                           ModelPrimitiveType string string string String
    // 038 ApplePriceTier                           ModelPrimitiveType int int int Int32
    // 040 GooglePrice                              ModelClassType Price Price Price Pointer
    // 048 PricingTemplateID                        ModelPrimitiveType string string string String
    // 050 Descriptions                             ModelClassListType List`1<LocalizedProductDescription> List`1<LocalizedProductDescription> List<LocalizedProductDescription> Pointer
    // 058 UdpPrice                                 ModelClassType Price Price Price Pointer
    // 060 Payouts                                  ModelClassListType List`1<ProductCatalogPayout> List`1<ProductCatalogPayout> List<ProductCatalogPayout> Pointer
    public partial class ProductCatalogItem : DataModel
    {
        public string                                   Id                                      { get; set; }
        public ProductType                              Type                                    { get; set; }
        public List<StoreID>?                           StoreIDs                                { get; set; }
        public LocalizedProductDescription?             DefaultDescription                      { get; set; }
        public string                                   ScreenshotPath                          { get; set; }
        public int                                      ApplePriceTier                          { get; set; }
        public Price?                                   GooglePrice                             { get; set; }
        public string                                   PricingTemplateID                       { get; set; }
        public List<LocalizedProductDescription>?       Descriptions                            { get; set; }
        public Price?                                   UdpPrice                                { get; set; }
        public List<ProductCatalogPayout>?              Payouts                                 { get; set; }

        public static ProductCatalogItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductCatalogItem() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.Type                                      = (ProductType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType ProductType ProductType ProductType Int32 )
            value.StoreIDs                                  = GetObjectList<StoreID>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoreID.FromPointer); // 0x20 StoreIDs                    ( ModelClassListType List`1<StoreID> List`1<StoreID> List<StoreID> Pointer )
            value.DefaultDescription                        = GetObject<LocalizedProductDescription>(new IntPtr(p + 0x028), ReversePrism.DataModels.LocalizedProductDescription.FromPointer); // 0x28 DefaultDescription          ( ModelClassType LocalizedProductDescription LocalizedProductDescription LocalizedProductDescription Pointer )
            value.ScreenshotPath                            = GetString(new IntPtr(p + 0x030)); // 0x30 ScreenshotPath              ( ModelPrimitiveType string string string String )
            value.ApplePriceTier                            = GetInt32(new IntPtr(p + 0x038)); // 0x38 ApplePriceTier              ( ModelPrimitiveType int int int Int32 )
            value.GooglePrice                               = GetObject<Price>(new IntPtr(p + 0x040), ReversePrism.DataModels.Price.FromPointer); // 0x40 GooglePrice                 ( ModelClassType Price Price Price Pointer )
            value.PricingTemplateID                         = GetString(new IntPtr(p + 0x048)); // 0x48 PricingTemplateID           ( ModelPrimitiveType string string string String )
            value.Descriptions                              = GetObjectList<LocalizedProductDescription>(new IntPtr(p + 0x050), ReversePrism.DataModels.LocalizedProductDescription.FromPointer); // 0x50 Descriptions                ( ModelClassListType List`1<LocalizedProductDescription> List`1<LocalizedProductDescription> List<LocalizedProductDescription> Pointer )
            value.UdpPrice                                  = GetObject<Price>(new IntPtr(p + 0x058), ReversePrism.DataModels.Price.FromPointer); // 0x58 UdpPrice                    ( ModelClassType Price Price Price Pointer )
            value.Payouts                                   = GetObjectList<ProductCatalogPayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProductCatalogPayout.FromPointer); // 0x60 Payouts                     ( ModelClassListType List`1<ProductCatalogPayout> List`1<ProductCatalogPayout> List<ProductCatalogPayout> Pointer )

            return value;
        }
    }
}
