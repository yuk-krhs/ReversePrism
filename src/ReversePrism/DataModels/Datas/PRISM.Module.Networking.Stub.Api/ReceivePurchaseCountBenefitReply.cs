using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceivePurchaseCountBenefitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LoginBonusPassPurchaseCountBenefitFieldNumber int IL2CPP_TYPE_I4
    // 018 LoginBonusPassPurchaseCountBenefit       ModelClassType LoginBonusPassPurchaseCountBenefitStatus LoginBonusPassPurchaseCountBenefitStatus LoginBonusPassPurchaseCountBenefitStatus Pointer
    // 000 ReceivedLoginBonusPassProductListFieldNumber int IL2CPP_TYPE_I4
    // 008 _repeated_receivedLoginBonusPassProductList_codec FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 ReceivedLoginBonusPassProductList        ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 SeasonPassPurchaseCountBenefitFieldNumber int IL2CPP_TYPE_I4
    // 028 SeasonPassPurchaseCountBenefit           ModelClassType SeasonPassPurchaseCountBenefitStatus SeasonPassPurchaseCountBenefitStatus SeasonPassPurchaseCountBenefitStatus Pointer
    // 000 ReceivedSeasonPassProductListFieldNumber int IL2CPP_TYPE_I4
    // 010 _repeated_receivedSeasonPassProductList_codec FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 030 ReceivedSeasonPassProductList            ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class ReceivePurchaseCountBenefitReply : DataModel
    {
        public LoginBonusPassPurchaseCountBenefitStatus? LoginBonusPassPurchaseCountBenefit      { get; set; }
        public List<ProductWithAmountStatus>?           ReceivedLoginBonusPassProductList       { get; set; }
        public SeasonPassPurchaseCountBenefitStatus?    SeasonPassPurchaseCountBenefit          { get; set; }
        public List<ProductWithAmountStatus>?           ReceivedSeasonPassProductList           { get; set; }

        public static ReceivePurchaseCountBenefitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceivePurchaseCountBenefitReply() { Pointer= p0 };

            value.LoginBonusPassPurchaseCountBenefit        = GetObject<LoginBonusPassPurchaseCountBenefitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginBonusPassPurchaseCountBenefitStatus.FromPointer); // 0x18 LoginBonusPassPurchaseCountBenefit ( ModelClassType LoginBonusPassPurchaseCountBenefitStatus LoginBonusPassPurchaseCountBenefitStatus LoginBonusPassPurchaseCountBenefitStatus Pointer )
            value.ReceivedLoginBonusPassProductList         = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x20 ReceivedLoginBonusPassProductList ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.SeasonPassPurchaseCountBenefit            = GetObject<SeasonPassPurchaseCountBenefitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SeasonPassPurchaseCountBenefitStatus.FromPointer); // 0x28 SeasonPassPurchaseCountBenefit ( ModelClassType SeasonPassPurchaseCountBenefitStatus SeasonPassPurchaseCountBenefitStatus SeasonPassPurchaseCountBenefitStatus Pointer )
            value.ReceivedSeasonPassProductList             = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x30 ReceivedSeasonPassProductList ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
