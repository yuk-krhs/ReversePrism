using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetShopItemJewelGroupReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 JewelGroupFieldNumber                    int IL2CPP_TYPE_I4
    // 018 JewelGroup                               00018675F2D0 ModelClassType ShopItemJewelGroupStatus ShopItemJewelGroupStatus ShopItemJewelGroupStatus Pointer
    // 000 TotalBillingAmountFieldNumber            int IL2CPP_TYPE_I4
    // 020 TotalBillingAmount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetShopItemJewelGroupReply : DataModel
    {
        public ShopItemJewelGroupStatus?                JewelGroup                              { get; set; }
        public int                                      TotalBillingAmount                      { get; set; }

        public static GetShopItemJewelGroupReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopItemJewelGroupReply() { Pointer= p0 };

            value.JewelGroup                                = GetObject<ShopItemJewelGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopItemJewelGroupStatus.FromPointer); // 024662743D40 0x18 JewelGroup                  ( 00018675F2D0 ModelClassType ShopItemJewelGroupStatus ShopItemJewelGroupStatus ShopItemJewelGroupStatus Pointer )
            value.TotalBillingAmount                        = GetInt32(new IntPtr(p + 0x020)); // 024662743D80 0x20 TotalBillingAmount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
