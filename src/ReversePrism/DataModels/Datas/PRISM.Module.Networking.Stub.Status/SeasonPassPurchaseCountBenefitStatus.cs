using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SeasonPassPurchaseCountBenefitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StepProductListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_stepProductList_codec          FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 018 StepProductList                          000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 NextStepFieldNumber                      int IL2CPP_TYPE_I4
    // 020 NextStep                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SeasonPassPurchaseCountBenefitStatus
    {
        public List<ProductWithAmountStatus>?           StepProductList                         { get; set; }
        public int                                      NextStep                                { get; set; }

        public static SeasonPassPurchaseCountBenefitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonPassPurchaseCountBenefitStatus();

            value.StepProductList                           = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D27FFD28 0x18 StepProductList             ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.NextStep                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D27FFD68 0x20 NextStep                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
