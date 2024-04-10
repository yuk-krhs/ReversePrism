using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstItemId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Product                                  0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 020 ProductName                              000186672F10 ModelPrimitiveType string string string String
    // 028 ProductNameMultiLine                     000186672F10 ModelPrimitiveType string string string String
    // 030 CautionText                              000186672F10 ModelPrimitiveType string string string String
    // 038 MessageText                              000186672F10 ModelPrimitiveType string string string String
    // 040 IsMultiProduct                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ShopPassPurchaseCompletePopupViewModel : DataModel
    {
        public int                                      MstItemId                               { get; set; }
        public IProductStatus?                          Product                                 { get; set; }
        public string                                   ProductName                             { get; set; }
        public string                                   ProductNameMultiLine                    { get; set; }
        public string                                   CautionText                             { get; set; }
        public string                                   MessageText                             { get; set; }
        public bool                                     IsMultiProduct                          { get; set; }

        public static ShopPassPurchaseCompletePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassPurchaseCompletePopupViewModel() { Pointer= p0 };

            value.MstItemId                                 = GetInt32(new IntPtr(p + 0x010)); // 0246667892C8 0x10 MstItemId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0246667892E8 0x18 Product                     ( 0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ProductName                               = GetString(new IntPtr(p + 0x020)); // 024666789308 0x20 ProductName                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.ProductNameMultiLine                      = GetString(new IntPtr(p + 0x028)); // 024666789328 0x28 ProductNameMultiLine        ( 000186672F10 ModelPrimitiveType string string string String )
            value.CautionText                               = GetString(new IntPtr(p + 0x030)); // 024666789348 0x30 CautionText                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.MessageText                               = GetString(new IntPtr(p + 0x038)); // 024666789368 0x38 MessageText                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsMultiProduct                            = GetBool(new IntPtr(p + 0x040)); // 024666789388 0x40 IsMultiProduct              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
