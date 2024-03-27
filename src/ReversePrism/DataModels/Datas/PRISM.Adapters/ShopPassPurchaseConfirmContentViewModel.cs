using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ValidDayText                             000186671910 ModelPrimitiveType string string string String
    // 018 ValidityText                             000186671910 ModelPrimitiveType string string string String
    // 020 MstItemId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 CautionStr                               000186671910 ModelPrimitiveType string string string String
    // 030 Price                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 StoreLocalPriceString                    000186671910 ModelPrimitiveType string string string String
    // 040 StoreItem                                00018665A9E0 ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer
    // 048 ShopGroupTypeId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 Product                                  0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 058 IsExpireDate                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ShopPassPurchaseConfirmContentViewModel
    {
        public string                                   ValidDayText                            { get; set; }
        public string                                   ValidityText                            { get; set; }
        public int                                      MstItemId                               { get; set; }
        public string                                   CautionStr                              { get; set; }
        public int                                      Price                                   { get; set; }
        public string                                   StoreLocalPriceString                   { get; set; }
        public IStoreItemStatus?                        StoreItem                               { get; set; }
        public int                                      ShopGroupTypeId                         { get; set; }
        public IProductStatus?                          Product                                 { get; set; }
        public bool                                     IsExpireDate                            { get; set; }

        public static ShopPassPurchaseConfirmContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassPurchaseConfirmContentViewModel();

            value.ValidDayText                              = GetString(new IntPtr(p + 0x010)); // 0270D673B118 0x10 ValidDayText                ( 000186671910 ModelPrimitiveType string string string String )
            value.ValidityText                              = GetString(new IntPtr(p + 0x018)); // 0270D673B138 0x18 ValidityText                ( 000186671910 ModelPrimitiveType string string string String )
            value.MstItemId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D673B158 0x20 MstItemId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CautionStr                                = GetString(new IntPtr(p + 0x028)); // 0270D673B178 0x28 CautionStr                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Price                                     = GetInt32(new IntPtr(p + 0x030)); // 0270D673B198 0x30 Price                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoreLocalPriceString                     = GetString(new IntPtr(p + 0x038)); // 0270D673B1B8 0x38 StoreLocalPriceString       ( 000186671910 ModelPrimitiveType string string string String )
            value.StoreItem                                 = GetObject<IStoreItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D673B1D8 0x40 StoreItem                   ( 00018665A9E0 ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer )
            value.ShopGroupTypeId                           = GetInt32(new IntPtr(p + 0x048)); // 0270D673B1F8 0x48 ShopGroupTypeId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<IProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductStatus.FromPointer); // 0270D673B218 0x50 Product                     ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.IsExpireDate                              = GetBool(new IntPtr(p + 0x058)); // 0270D673B238 0x58 IsExpireDate                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
