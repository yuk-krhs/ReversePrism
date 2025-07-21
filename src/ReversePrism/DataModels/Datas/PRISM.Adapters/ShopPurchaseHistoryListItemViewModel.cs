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
    // 020 CurrentTabTypeId                         ModelPrimitiveType int int int Int32
    // 024 MstStoreItemId                           ModelPrimitiveType int int int Int32
    // 028 ItemName                                 ModelPrimitiveType string string string String
    // 030 PaidJewel                                ModelPrimitiveType int int int Int32
    // 034 FreeJewel                                ModelPrimitiveType int int int Int32
    // 038 Price                                    ModelPrimitiveType int int int Int32
    // 040 ContentProductList                       ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 048 BonusProductList                         ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 050 PurchaseAmount                           ModelPrimitiveType int int int Int32
    // 058 PurchaseDate                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ShopPurchaseHistoryListItemViewModel : DataModel
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
            var value   = new ShopPurchaseHistoryListItemViewModel() { Pointer= p0 };

            value.CurrentTabTypeId                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentTabTypeId            ( ModelPrimitiveType int int int Int32 )
            value.MstStoreItemId                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstStoreItemId              ( ModelPrimitiveType int int int Int32 )
            value.ItemName                                  = GetString(new IntPtr(p + 0x028)); // 0x28 ItemName                    ( ModelPrimitiveType string string string String )
            value.PaidJewel                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 PaidJewel                   ( ModelPrimitiveType int int int Int32 )
            value.FreeJewel                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 FreeJewel                   ( ModelPrimitiveType int int int Int32 )
            value.Price                                     = GetInt32(new IntPtr(p + 0x038)); // 0x38 Price                       ( ModelPrimitiveType int int int Int32 )
            value.ContentProductList                        = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x40 ContentProductList          ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.BonusProductList                          = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x48 BonusProductList            ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.PurchaseAmount                            = GetInt32(new IntPtr(p + 0x050)); // 0x50 PurchaseAmount              ( ModelPrimitiveType int int int Int32 )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x058)); // 0x58 PurchaseDate                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
