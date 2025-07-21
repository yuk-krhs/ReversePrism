using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SeasonMissionMissionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSeasonMissionMissionIdFieldNumber     int IL2CPP_TYPE_I4
    // 018 MstSeasonMissionMissionId                ModelPrimitiveType int int int Int32
    // 000 MstMissionProgressIdFieldNumber          int IL2CPP_TYPE_I4
    // 01C MstMissionProgressId                     ModelPrimitiveType int int int Int32
    // 000 RequiredValueFieldNumber                 int IL2CPP_TYPE_I4
    // 020 RequiredValue                            ModelPrimitiveType int int int Int32
    // 000 CurrentValueFieldNumber                  int IL2CPP_TYPE_I4
    // 024 CurrentValue                             ModelPrimitiveType int int int Int32
    // 000 ExpFieldNumber                           int IL2CPP_TYPE_I4
    // 028 Exp                                      ModelPrimitiveType int int int Int32
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 02C State                                    ModelEnumType MissionState MissionState MissionState Int32
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Period                                   ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 038 SortId                                   ModelPrimitiveType int int int Int32
    // 000 FilterTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 03C FilterType                               ModelEnumType MissionFilterType MissionFilterType MissionFilterType Int32
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Jump                                     ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class SeasonMissionMissionStatus : DataModel
    {
        public int                                      MstSeasonMissionMissionId               { get; set; }
        public int                                      MstMissionProgressId                    { get; set; }
        public int                                      RequiredValue                           { get; set; }
        public int                                      CurrentValue                            { get; set; }
        public int                                      Exp                                     { get; set; }
        public MissionState                             State                                   { get; set; }
        public PeriodStatus?                            Period                                  { get; set; }
        public int                                      SortId                                  { get; set; }
        public MissionFilterType                        FilterType                              { get; set; }
        public JumpStatus?                              Jump                                    { get; set; }

        public static SeasonMissionMissionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionMissionStatus() { Pointer= p0 };

            value.MstSeasonMissionMissionId                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSeasonMissionMissionId   ( ModelPrimitiveType int int int Int32 )
            value.MstMissionProgressId                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstMissionProgressId        ( ModelPrimitiveType int int int Int32 )
            value.RequiredValue                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 RequiredValue               ( ModelPrimitiveType int int int Int32 )
            value.CurrentValue                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 CurrentValue                ( ModelPrimitiveType int int int Int32 )
            value.Exp                                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 Exp                         ( ModelPrimitiveType int int int Int32 )
            value.State                                     = (MissionState)GetInt32(new IntPtr(p + 0x02C)); // 0x2C State                       ( ModelEnumType MissionState MissionState MissionState Int32 )
            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x30 Period                      ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.FilterType                                = (MissionFilterType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C FilterType                  ( ModelEnumType MissionFilterType MissionFilterType MissionFilterType Int32 )
            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.JumpStatus.FromPointer); // 0x40 Jump                        ( ModelClassType JumpStatus JumpStatus JumpStatus Pointer )

            return value;
        }
    }
}
