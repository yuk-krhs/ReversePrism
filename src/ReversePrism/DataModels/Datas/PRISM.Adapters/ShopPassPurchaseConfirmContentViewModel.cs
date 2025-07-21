using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ValidDayText                             ModelPrimitiveType string string string String
    // 018 ValidityText                             ModelPrimitiveType string string string String
    // 020 MstItemId                                ModelPrimitiveType int int int Int32
    // 028 CautionStr                               ModelPrimitiveType string string string String
    // 030 Price                                    ModelPrimitiveType int int int Int32
    // 038 StoreLocalPriceString                    ModelPrimitiveType string string string String
    // 040 StoreItem                                ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer
    // 048 ShopGroupTypeId                          ModelPrimitiveType int int int Int32
    // 050 Product                                  ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 058 IsExpireDate                             ModelPrimitiveType bool bool bool Bool
    public partial class ShopPassPurchaseConfirmContentViewModel : DataModel
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
            var value   = new ShopPassPurchaseConfirmContentViewModel() { Pointer= p0 };

            value.ValidDayText                              = GetString(new IntPtr(p + 0x010)); // 0x10 ValidDayText                ( ModelPrimitiveType string string string String )
            value.ValidityText                              = GetString(new IntPtr(p + 0x018)); // 0x18 ValidityText                ( ModelPrimitiveType string string string String )
            value.MstItemId                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstItemId                   ( ModelPrimitiveType int int int Int32 )
            value.CautionStr                                = GetString(new IntPtr(p + 0x028)); // 0x28 CautionStr                  ( ModelPrimitiveType string string string String )
            value.Price                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Price                       ( ModelPrimitiveType int int int Int32 )
            value.StoreLocalPriceString                     = GetString(new IntPtr(p + 0x038)); // 0x38 StoreLocalPriceString       ( ModelPrimitiveType string string string String )
            value.StoreItem                                 = GetObject<IStoreItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0x40 StoreItem                   ( ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer )
            value.ShopGroupTypeId                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 ShopGroupTypeId             ( ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<IProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x50 Product                     ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.IsExpireDate                              = GetBool(new IntPtr(p + 0x058)); // 0x58 IsExpireDate                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
