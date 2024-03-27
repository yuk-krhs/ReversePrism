using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetProduceIdolListArgs  Marshaller`1<GetProduceIdolListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetProduceIdolListReply Marshaller`1<GetProduceIdolListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_EvolveProduceIdolArgs   Marshaller`1<EvolveProduceIdolArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_EvolveProduceIdolReply  Marshaller`1<EvolveProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_LimitBreakProduceIdolArgs Marshaller`1<LimitBreakProduceIdolArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_LimitBreakProduceIdolReply Marshaller`1<LimitBreakProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_LevelUpIdolSkillArgs    Marshaller`1<LevelUpIdolSkillArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_LevelUpIdolSkillReply   Marshaller`1<LevelUpIdolSkillReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_MarkFavoriteProduceIdolArgs Marshaller`1<MarkFavoriteProduceIdolArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_MarkFavoriteProduceIdolReply Marshaller`1<MarkFavoriteProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_SelectIdolSkillArgs     Marshaller`1<SelectIdolSkillArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_SelectIdolSkillReply    Marshaller`1<SelectIdolSkillReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_GetProduceIdolList              Method`2<GetProduceIdolListArgs, GetProduceIdolListReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_EvolveProduceIdol               Method`2<EvolveProduceIdolArgs, EvolveProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_LimitBreakProduceIdol           Method`2<LimitBreakProduceIdolArgs, LimitBreakProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_LevelUpIdolSkill                Method`2<LevelUpIdolSkillArgs, LevelUpIdolSkillReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_MarkFavoriteProduceIdol         Method`2<MarkFavoriteProduceIdolArgs, MarkFavoriteProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_SelectIdolSkill                 Method`2<SelectIdolSkillArgs, SelectIdolSkillReply> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolService
    {

        public static ProduceIdolService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolService();


            return value;
        }
    }
}
