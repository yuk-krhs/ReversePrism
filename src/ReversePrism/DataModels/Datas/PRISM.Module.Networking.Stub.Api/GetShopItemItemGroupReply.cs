using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetShopItemItemGroupReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ItemGroupFieldNumber                     int IL2CPP_TYPE_I4
    // 018 ItemGroup                                00018675EBC0 ModelClassType ShopItemItemGroupStatus ShopItemItemGroupStatus ShopItemItemGroupStatus Pointer
    // 000 TotalBillingAmountFieldNumber            int IL2CPP_TYPE_I4
    // 020 TotalBillingAmount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetShopItemItemGroupReply
    {
        public ShopItemItemGroupStatus?                 ItemGroup                               { get; set; }
        public int                                      TotalBillingAmount                      { get; set; }

        public static GetShopItemItemGroupReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopItemItemGroupReply();

            value.ItemGroup                                 = GetObject<ShopItemItemGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopItemItemGroupStatus.FromPointer); // 0270D27E26F0 0x18 ItemGroup                   ( 00018675EBC0 ModelClassType ShopItemItemGroupStatus ShopItemItemGroupStatus ShopItemItemGroupStatus Pointer )
            value.TotalBillingAmount                        = GetInt32(new IntPtr(p + 0x020)); // 0270D27E2730 0x20 TotalBillingAmount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
