using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DetermineProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 020 FesUnit                                  ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer
    // 000 TotalParameterValueFieldNumber           int IL2CPP_TYPE_I4
    // 028 TotalParameterValue                      ModelPrimitiveType int int int Int32
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<FesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 030 FesIdolList                              ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer
    // 000 IdolBaseRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_idolBaseRewardList_codec       FieldCodec`1<IdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 IdolBaseRewardList                       ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 040 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class DetermineProduceResultReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public FesUnitStatus?                           FesUnit                                 { get; set; }
        public int                                      TotalParameterValue                     { get; set; }
        public List<FesIdolStatus>?                     FesIdolList                             { get; set; }
        public List<IdolBaseRewardStatus>?              IdolBaseRewardList                      { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static DetermineProduceResultReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DetermineProduceResultReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.FesUnit                                   = GetObject<FesUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 0x20 FesUnit                     ( ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer )
            value.TotalParameterValue                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotalParameterValue         ( ModelPrimitiveType int int int Int32 )
            value.FesIdolList                               = GetObjectList<FesIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.FesIdolStatus.FromPointer); // 0x30 FesIdolList                 ( ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer )
            value.IdolBaseRewardList                        = GetObjectList<IdolBaseRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0x38 IdolBaseRewardList          ( ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x40 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
