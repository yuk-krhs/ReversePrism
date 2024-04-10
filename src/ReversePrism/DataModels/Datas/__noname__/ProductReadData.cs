using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShopItemType                             00018661A910 ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 014 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 IsRead                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 EndDate                                  000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class ProductReadData : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public int                                      Id                                      { get; set; }
        public bool                                     IsRead                                  { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static ProductReadData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductReadData() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x010)); // 0245A3AA3508 0x10 ShopItemType                ( 00018661A910 ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x014)); // 0245A3AA3528 0x14 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsRead                                    = GetBool(new IntPtr(p + 0x018)); // 0245A3AA3548 0x18 IsRead                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0245A3AA3568 0x20 EndDate                     ( 000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
