using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LoginBonusStepStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NumFieldNumber                           int IL2CPP_TYPE_I4
    // 018 Num                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 01C State                                    0001865BA410 ModelEnumType LoginBonusStepState LoginBonusStepState LoginBonusStepState Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class LoginBonusStepStatus : DataModel
    {
        public int                                      Num                                     { get; set; }
        public LoginBonusStepState                      State                                   { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }

        public static LoginBonusStepStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusStepStatus() { Pointer= p0 };

            value.Num                                       = GetInt32(new IntPtr(p + 0x018)); // 02466218B518 0x18 Num                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (LoginBonusStepState)GetInt32(new IntPtr(p + 0x01C)); // 02466218B558 0x1C State                       ( 0001865BA410 ModelEnumType LoginBonusStepState LoginBonusStepState LoginBonusStepState Int32 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 02466218B5B8 0x20 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
