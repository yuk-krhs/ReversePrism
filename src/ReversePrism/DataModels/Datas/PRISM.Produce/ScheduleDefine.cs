using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RestScenarioIDSuffix                     string IL2CPP_TYPE_STRING
    // 000 AdviceScenarioIDSuffix                   string IL2CPP_TYPE_STRING
    // 000 VitalityGaugeDuration                    float IL2CPP_TYPE_R4
    // 000 MstProduceStrategyTitle                  string IL2CPP_TYPE_STRING
    // 000 MstProduceStrategyDescription            string IL2CPP_TYPE_STRING
    // 000 MstProduceStrategyDetail                 string IL2CPP_TYPE_STRING
    // 000 MstPotentialSupportSkillName             string IL2CPP_TYPE_STRING
    // 000 MstPotentialSupportSkillDescription      string IL2CPP_TYPE_STRING
    // 000 MstSupportSkillEffectName                string IL2CPP_TYPE_STRING
    // 000 MstSupportSkillEffectDescription         string IL2CPP_TYPE_STRING
    // 000 MstEpisodeTitle                          string IL2CPP_TYPE_STRING
    // 000 MstProduceIdolName                       string IL2CPP_TYPE_STRING
    // 000 OutGameMinDeckNum                        int IL2CPP_TYPE_I4
    // 000 CurrentVitality                          int IL2CPP_TYPE_I4
    // 004 TargetScheduleWeekIndex                  int IL2CPP_TYPE_I4
    // 008 <CacheProduceBaseInfo>k__BackingField    IProduceBaseInfoStatus IL2CPP_TYPE_CLASS
    // 010 CacheProduceNextOrderType                00018660CF70 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 014 IsResumeState                            000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class ScheduleDefine
    {
        public ProduceNextOrderType                     CacheProduceNextOrderType               { get; set; }
        public bool                                     IsResumeState                           { get; set; }

        public static ScheduleDefine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDefine();

            value.CacheProduceNextOrderType                 = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x010)); // 0270D5D09C00 0x10 CacheProduceNextOrderType   ( 00018660CF70 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.IsResumeState                             = GetBool(new IntPtr(p + 0x014)); // 0270D5D09C20 0x14 IsResumeState               ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
