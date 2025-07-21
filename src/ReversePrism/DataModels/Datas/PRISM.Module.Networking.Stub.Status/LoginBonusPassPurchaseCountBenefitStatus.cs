using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LoginBonusPassPurchaseCountBenefitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StepProductListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_stepProductList_codec          FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 018 StepProductList                          ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 NextStepFieldNumber                      int IL2CPP_TYPE_I4
    // 020 NextStep                                 ModelPrimitiveType int int int Int32
    public partial class LoginBonusPassPurchaseCountBenefitStatus : DataModel
    {
        public List<ProductWithAmountStatus>?           StepProductList                         { get; set; }
        public int                                      NextStep                                { get; set; }

        public static LoginBonusPassPurchaseCountBenefitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusPassPurchaseCountBenefitStatus() { Pointer= p0 };

            value.StepProductList                           = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x18 StepProductList             ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.NextStep                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 NextStep                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
