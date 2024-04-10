using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetShopItemCostumeGroupReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumeGroupFieldNumber                  int IL2CPP_TYPE_I4
    // 018 CostumeGroup                             00018675E4A0 ModelClassType ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus Pointer
    // 000 TotalBillingAmountFieldNumber            int IL2CPP_TYPE_I4
    // 020 TotalBillingAmount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetShopItemCostumeGroupReply : DataModel
    {
        public ShopItemCostumeGroupStatus?              CostumeGroup                            { get; set; }
        public int                                      TotalBillingAmount                      { get; set; }

        public static GetShopItemCostumeGroupReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopItemCostumeGroupReply() { Pointer= p0 };

            value.CostumeGroup                              = GetObject<ShopItemCostumeGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopItemCostumeGroupStatus.FromPointer); // 0246627353D0 0x18 CostumeGroup                ( 00018675E4A0 ModelClassType ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus Pointer )
            value.TotalBillingAmount                        = GetInt32(new IntPtr(p + 0x020)); // 024662735410 0x20 TotalBillingAmount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
