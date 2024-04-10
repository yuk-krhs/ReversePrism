using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IntroductionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IntroductionTypeFieldNumber              int IL2CPP_TYPE_I4
    // 018 IntroductionType                         00018672C7F0 ModelEnumType IntroductionType IntroductionType IntroductionType Int32
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 030 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IntroductionStatus : DataModel
    {
        public IntroductionType                         IntroductionType                        { get; set; }
        public string                                   ResourceId                              { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public int                                      MstUnitId                               { get; set; }

        public static IntroductionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionStatus() { Pointer= p0 };

            value.IntroductionType                          = (IntroductionType)GetInt32(new IntPtr(p + 0x018)); // 024662115648 0x18 IntroductionType            ( 00018672C7F0 ModelEnumType IntroductionType IntroductionType IntroductionType Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 024662115688 0x20 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0246621156E8 0x28 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x030)); // 024662115728 0x30 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
