using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreItemMstId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 CautionStr                               000186671910 ModelPrimitiveType string string string String
    public partial class ShopPassDetailPopupViewModel : DataModel
    {
        public int                                      StoreItemMstId                          { get; set; }
        public string                                   CautionStr                              { get; set; }

        public static ShopPassDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassDetailPopupViewModel() { Pointer= p0 };

            value.StoreItemMstId                            = GetInt32(new IntPtr(p + 0x010)); // 0246667AAE88 0x10 StoreItemMstId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CautionStr                                = GetString(new IntPtr(p + 0x018)); // 0246667AAEA8 0x18 CautionStr                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
