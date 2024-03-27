using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MissionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstMissionIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 MstMissionId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstMissionProgressIdFieldNumber          int IL2CPP_TYPE_I4
    // 01C MstMissionProgressId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RequiredValueFieldNumber                 int IL2CPP_TYPE_I4
    // 020 RequiredValue                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CurrentValueFieldNumber                  int IL2CPP_TYPE_I4
    // 024 CurrentValue                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 030 State                                    000186629C10 ModelEnumType MissionState MissionState MissionState Int32
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Period                                   000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 040 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FilterTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 044 FilterType                               000186621470 ModelEnumType MissionFilterType MissionFilterType MissionFilterType Int32
    // 000 GaugePointFieldNumber                    int IL2CPP_TYPE_I4
    // 048 GaugePoint                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Jump                                     000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class MissionStatus
    {
        public int                                      MstMissionId                            { get; set; }
        public int                                      MstMissionProgressId                    { get; set; }
        public int                                      RequiredValue                           { get; set; }
        public int                                      CurrentValue                            { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public MissionState                             State                                   { get; set; }
        public PeriodStatus?                            Period                                  { get; set; }
        public int                                      SortId                                  { get; set; }
        public MissionFilterType                        FilterType                              { get; set; }
        public int                                      GaugePoint                              { get; set; }
        public JumpStatus?                              Jump                                    { get; set; }

        public static MissionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionStatus();

            value.MstMissionId                              = GetInt32(new IntPtr(p + 0x018)); // 0270D22F5310 0x18 MstMissionId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstMissionProgressId                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D22F5350 0x1C MstMissionProgressId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RequiredValue                             = GetInt32(new IntPtr(p + 0x020)); // 0270D22F5390 0x20 RequiredValue               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentValue                              = GetInt32(new IntPtr(p + 0x024)); // 0270D22F53D0 0x24 CurrentValue                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D22F5430 0x28 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x030)); // 0270D22F5470 0x30 State                       ( 000186629C10 ModelEnumType MissionState MissionState MissionState Int32 )
            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0270D22F54B0 0x38 Period                      ( 000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x040)); // 0270D22F54F0 0x40 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FilterType                                = (MissionFilterType)GetInt32(new IntPtr(p + 0x044)); // 0270D22F5530 0x44 FilterType                  ( 000186621470 ModelEnumType MissionFilterType MissionFilterType MissionFilterType Int32 )
            value.GaugePoint                                = GetInt32(new IntPtr(p + 0x048)); // 0270D22F5570 0x48 GaugePoint                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.JumpStatus.FromPointer); // 0270D22F55B0 0x50 Jump                        ( 000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer )

            return value;
        }
    }
}
