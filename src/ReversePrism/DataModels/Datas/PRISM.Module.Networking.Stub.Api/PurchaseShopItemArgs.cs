using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseShopItemArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstShopItemIdFieldNumber                 int IL2CPP_TYPE_I4
    // 018 MstShopItemId                            ModelPrimitiveType int int int Int32
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Amount                                   ModelPrimitiveType int int int Int32
    public partial class PurchaseShopItemArgs : DataModel
    {
        public int                                      MstShopItemId                           { get; set; }
        public int                                      Amount                                  { get; set; }

        public static PurchaseShopItemArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseShopItemArgs() { Pointer= p0 };

            value.MstShopItemId                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstShopItemId               ( ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Amount                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
