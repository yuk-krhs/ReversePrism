using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAutoProgressedScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 WeekFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Week                                     ModelPrimitiveType int int int Int32
    // 000 ScheduleTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 01C ScheduleType                             ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 020 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 024 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 000 IsRecommendFieldNumber                   int IL2CPP_TYPE_I4
    // 028 IsRecommend                              ModelPrimitiveType bool bool bool Bool
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 029 IsSupportBonus                           ModelPrimitiveType bool bool bool Bool
    // 000 SupportCharacterIconListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_supportCharacterIconList_codec FieldCodec`1<SupportCharacterIconStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportCharacterIconList                 ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer
    // 000 IsSpecifiedByPassiveEffectFieldNumber    int IL2CPP_TYPE_I4
    // 038 IsSpecifiedByPassiveEffect               ModelPrimitiveType bool bool bool Bool
    public partial class ProduceAutoProgressedScheduleStatus : DataModel
    {
        public int                                      Week                                    { get; set; }
        public ScheduleType                             ScheduleType                            { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public bool                                     IsRecommend                             { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public List<SupportCharacterIconStatus>?        SupportCharacterIconList                { get; set; }
        public bool                                     IsSpecifiedByPassiveEffect              { get; set; }

        public static ProduceAutoProgressedScheduleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoProgressedScheduleStatus() { Pointer= p0 };

            value.Week                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Week                        ( ModelPrimitiveType int int int Int32 )
            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ScheduleType                ( ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.IsRecommend                               = GetBool(new IntPtr(p + 0x028)); // 0x28 IsRecommend                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x029)); // 0x29 IsSupportBonus              ( ModelPrimitiveType bool bool bool Bool )
            value.SupportCharacterIconList                  = GetObjectList<SupportCharacterIconStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharacterIconStatus.FromPointer); // 0x30 SupportCharacterIconList    ( ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer )
            value.IsSpecifiedByPassiveEffect                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsSpecifiedByPassiveEffect  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
