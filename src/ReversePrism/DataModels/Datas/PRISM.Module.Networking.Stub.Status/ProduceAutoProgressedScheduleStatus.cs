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
    // 018 Week                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScheduleTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 01C ScheduleType                             0001866E4270 ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 020 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 024 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsRecommendFieldNumber                   int IL2CPP_TYPE_I4
    // 028 IsRecommend                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 029 IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 SupportCharacterIconListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_supportCharacterIconList_codec FieldCodec`1<SupportCharacterIconStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportCharacterIconList                 000185CF4048 ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer
    public partial class ProduceAutoProgressedScheduleStatus : DataModel
    {
        public int                                      Week                                    { get; set; }
        public ScheduleType                             ScheduleType                            { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public bool                                     IsRecommend                             { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }
        public List<SupportCharacterIconStatus>?        SupportCharacterIconList                { get; set; }

        public static ProduceAutoProgressedScheduleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoProgressedScheduleStatus() { Pointer= p0 };

            value.Week                                      = GetInt32(new IntPtr(p + 0x018)); // 024661092718 0x18 Week                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x01C)); // 024661092758 0x1C ScheduleType                ( 0001866E4270 ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x020)); // 024661092798 0x20 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x024)); // 0246610927D8 0x24 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRecommend                               = GetBool(new IntPtr(p + 0x028)); // 024661092818 0x28 IsRecommend                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x029)); // 024661092858 0x29 IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportCharacterIconList                  = GetObjectList<SupportCharacterIconStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharacterIconStatus.FromPointer); // 0246610928B8 0x30 SupportCharacterIconList    ( 000185CF4048 ModelClassListType RepeatedField`1<SupportCharacterIconStatus> RepeatedField`1<SupportCharacterIconStatus> List<SupportCharacterIconStatus> Pointer )

            return value;
        }
    }
}
