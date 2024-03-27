using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 Type                                     0001865A6600 ModelEnumType ProductType ProductType ProductType Int32
    // 020 StoreIDs                                 000185D0CFC8 ModelClassListType List`1<StoreID> List`1<StoreID> List<StoreID> Pointer
    // 028 DefaultDescription                       0001865A81D0 ModelClassType LocalizedProductDescription LocalizedProductDescription LocalizedProductDescription Pointer
    // 030 ScreenshotPath                           0001866722E0 ModelPrimitiveType string string string String
    // 038 ApplePriceTier                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 GooglePrice                              0001865119E0 ModelClassType Price Price Price Pointer
    // 048 PricingTemplateID                        0001866722E0 ModelPrimitiveType string string string String
    // 050 Descriptions                             000185CF0DC8 ModelClassListType List`1<LocalizedProductDescription> List`1<LocalizedProductDescription> List<LocalizedProductDescription> Pointer
    // 058 UdpPrice                                 0001865119E0 ModelClassType Price Price Price Pointer
    // 060 Payouts                                  000185CFDBD8 ModelClassListType List`1<ProductCatalogPayout> List`1<ProductCatalogPayout> List<ProductCatalogPayout> Pointer
    public partial class ProductCatalogItem
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
            var value   = new ProductCatalogItem();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 02700691B190 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Type                                      = (ProductType)GetInt32(new IntPtr(p + 0x018)); // 02700691B1B0 0x18 Type                        ( 0001865A6600 ModelEnumType ProductType ProductType ProductType Int32 )
            value.StoreIDs                                  = GetObjectList<StoreID>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoreID.FromPointer); // 02700691B1D0 0x20 StoreIDs                    ( 000185D0CFC8 ModelClassListType List`1<StoreID> List`1<StoreID> List<StoreID> Pointer )
            value.DefaultDescription                        = GetObject<LocalizedProductDescription>(new IntPtr(p + 0x028), ReversePrism.DataModels.LocalizedProductDescription.FromPointer); // 02700691B1F0 0x28 DefaultDescription          ( 0001865A81D0 ModelClassType LocalizedProductDescription LocalizedProductDescription LocalizedProductDescription Pointer )
            value.ScreenshotPath                            = GetString(new IntPtr(p + 0x030)); // 02700691B210 0x30 ScreenshotPath              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ApplePriceTier                            = GetInt32(new IntPtr(p + 0x038)); // 02700691B230 0x38 ApplePriceTier              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GooglePrice                               = GetObject<Price>(new IntPtr(p + 0x040), ReversePrism.DataModels.Price.FromPointer); // 02700691B250 0x40 GooglePrice                 ( 0001865119E0 ModelClassType Price Price Price Pointer )
            value.PricingTemplateID                         = GetString(new IntPtr(p + 0x048)); // 02700691B270 0x48 PricingTemplateID           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Descriptions                              = GetObjectList<LocalizedProductDescription>(new IntPtr(p + 0x050), ReversePrism.DataModels.LocalizedProductDescription.FromPointer); // 02700691B290 0x50 Descriptions                ( 000185CF0DC8 ModelClassListType List`1<LocalizedProductDescription> List`1<LocalizedProductDescription> List<LocalizedProductDescription> Pointer )
            value.UdpPrice                                  = GetObject<Price>(new IntPtr(p + 0x058), ReversePrism.DataModels.Price.FromPointer); // 02700691B2B0 0x58 UdpPrice                    ( 0001865119E0 ModelClassType Price Price Price Pointer )
            value.Payouts                                   = GetObjectList<ProductCatalogPayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProductCatalogPayout.FromPointer); // 02700691B2D0 0x60 Payouts                     ( 000185CFDBD8 ModelClassListType List`1<ProductCatalogPayout> List`1<ProductCatalogPayout> List<ProductCatalogPayout> Pointer )

            return value;
        }
    }
}
