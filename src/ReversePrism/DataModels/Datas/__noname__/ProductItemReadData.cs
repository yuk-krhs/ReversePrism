using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 014 ItemMasterType                           ModelEnumType ItemMasterType ItemMasterType ItemMasterType Int32
    // 018 Id                                       ModelPrimitiveType int int int Int32
    // 01C IsRead                                   ModelPrimitiveType bool bool bool Bool
    // 020 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class ProductItemReadData : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public ItemMasterType                           ItemMasterType                          { get; set; }
        public int                                      Id                                      { get; set; }
        public bool                                     IsRead                                  { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static ProductItemReadData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductItemReadData() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.ItemMasterType                            = (ItemMasterType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ItemMasterType              ( ModelEnumType ItemMasterType ItemMasterType ItemMasterType Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType int int int Int32 )
            value.IsRead                                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsRead                      ( ModelPrimitiveType bool bool bool Bool )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
