using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SpecialMissionMissionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstMissionIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 MstMissionId                             ModelPrimitiveType int int int Int32
    // 000 MstMissionProgressIdFieldNumber          int IL2CPP_TYPE_I4
    // 01C MstMissionProgressId                     ModelPrimitiveType int int int Int32
    // 000 RequiredValueFieldNumber                 int IL2CPP_TYPE_I4
    // 020 RequiredValue                            ModelPrimitiveType int int int Int32
    // 000 CurrentValueFieldNumber                  int IL2CPP_TYPE_I4
    // 024 CurrentValue                             ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardList                               ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 030 State                                    ModelEnumType MissionState MissionState MissionState Int32
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 034 SortId                                   ModelPrimitiveType int int int Int32
    // 000 FilterTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 038 FilterType                               ModelEnumType MissionFilterType MissionFilterType MissionFilterType Int32
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Jump                                     ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class SpecialMissionMissionStatus : DataModel
    {
        public int                                      MstMissionId                            { get; set; }
        public int                                      MstMissionProgressId                    { get; set; }
        public int                                      RequiredValue                           { get; set; }
        public int                                      CurrentValue                            { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public MissionState                             State                                   { get; set; }
        public int                                      SortId                                  { get; set; }
        public MissionFilterType                        FilterType                              { get; set; }
        public JumpStatus?                              Jump                                    { get; set; }

        public static SpecialMissionMissionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionMissionStatus() { Pointer= p0 };

            value.MstMissionId                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstMissionId                ( ModelPrimitiveType int int int Int32 )
            value.MstMissionProgressId                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstMissionProgressId        ( ModelPrimitiveType int int int Int32 )
            value.RequiredValue                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 RequiredValue               ( ModelPrimitiveType int int int Int32 )
            value.CurrentValue                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 CurrentValue                ( ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 RewardList                  ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x030)); // 0x30 State                       ( ModelEnumType MissionState MissionState MissionState Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.FilterType                                = (MissionFilterType)GetInt32(new IntPtr(p + 0x038)); // 0x38 FilterType                  ( ModelEnumType MissionFilterType MissionFilterType MissionFilterType Int32 )
            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.JumpStatus.FromPointer); // 0x40 Jump                        ( ModelClassType JumpStatus JumpStatus JumpStatus Pointer )

            return value;
        }
    }
}
