using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetShopItemLoginBonusPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LoginBonusPassGroupFieldNumber           int IL2CPP_TYPE_I4
    // 018 LoginBonusPassGroup                      ModelClassType ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus Pointer
    // 000 TotalBillingAmountFieldNumber            int IL2CPP_TYPE_I4
    // 020 TotalBillingAmount                       ModelPrimitiveType int int int Int32
    public partial class GetShopItemLoginBonusPassGroupReply : DataModel
    {
        public ShopItemLoginBonusPassGroupStatus?       LoginBonusPassGroup                     { get; set; }
        public int                                      TotalBillingAmount                      { get; set; }

        public static GetShopItemLoginBonusPassGroupReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopItemLoginBonusPassGroupReply() { Pointer= p0 };

            value.LoginBonusPassGroup                       = GetObject<ShopItemLoginBonusPassGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopItemLoginBonusPassGroupStatus.FromPointer); // 0x18 LoginBonusPassGroup         ( ModelClassType ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus Pointer )
            value.TotalBillingAmount                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalBillingAmount          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
