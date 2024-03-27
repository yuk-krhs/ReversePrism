using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 detailContentProductList                 IReadOnlyCollection`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 018 detailBonusProductList                   IReadOnlyCollection`1<IProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 CurrentTabTypeId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 024 MstStoreItemId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 028 ItemName                                 000186672F10 ModelPrimitiveType string string string String
    // 030 PaidJewel                                0001865F4260 ModelPrimitiveType int int int Int32
    // 034 FreeJewel                                0001865F4260 ModelPrimitiveType int int int Int32
    // 038 Price                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 040 ContentProductList                       000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 048 BonusProductList                         000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 050 PurchaseAmount                           0001865F4260 ModelPrimitiveType int int int Int32
    // 058 PurchaseDate                             0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ShopPurchaseHistoryListItemViewModel
    {
        public int                                      CurrentTabTypeId                        { get; set; }
        public int                                      MstStoreItemId                          { get; set; }
        public string                                   ItemName                                { get; set; }
        public int                                      PaidJewel                               { get; set; }
        public int                                      FreeJewel                               { get; set; }
        public int                                      Price                                   { get; set; }
        public List<IProductWithAmountStatus>?          ContentProductList                      { get; set; }
        public List<IProductWithAmountStatus>?          BonusProductList                        { get; set; }
        public int                                      PurchaseAmount                          { get; set; }
        public DateTime                                 PurchaseDate                            { get; set; }

        public static ShopPurchaseHistoryListItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseHistoryListItemViewModel();

            value.CurrentTabTypeId                          = GetInt32(new IntPtr(p + 0x020)); // 0270D6718928 0x20 CurrentTabTypeId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstStoreItemId                            = GetInt32(new IntPtr(p + 0x024)); // 0270D6718948 0x24 MstStoreItemId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ItemName                                  = GetString(new IntPtr(p + 0x028)); // 0270D6718968 0x28 ItemName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.PaidJewel                                 = GetInt32(new IntPtr(p + 0x030)); // 0270D6718988 0x30 PaidJewel                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FreeJewel                                 = GetInt32(new IntPtr(p + 0x034)); // 0270D67189A8 0x34 FreeJewel                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Price                                     = GetInt32(new IntPtr(p + 0x038)); // 0270D67189C8 0x38 Price                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ContentProductList                        = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D67189E8 0x40 ContentProductList          ( 000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.BonusProductList                          = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D6718A08 0x48 BonusProductList            ( 000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.PurchaseAmount                            = GetInt32(new IntPtr(p + 0x050)); // 0270D6718A28 0x50 PurchaseAmount              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x058)); // 0270D6718A48 0x58 PurchaseDate                ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
