using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetProduceIdolList                       Method`2<IGetProduceIdolListArgs, IGetProduceIdolListReply> IL2CPP_TYPE_GENERICINST
    // 018 EvolveProduceIdol                        Method`2<IEvolveProduceIdolArgs, IEvolveProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 030 LimitBreakProduceIdol                    Method`2<ILimitBreakProduceIdolArgs, ILimitBreakProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 048 LevelUpIdolSkill                         Method`2<ILevelUpIdolSkillArgs, ILevelUpIdolSkillReply> IL2CPP_TYPE_GENERICINST
    // 060 MarkFavoriteProduceIdol                  Method`2<IMarkFavoriteProduceIdolArgs, IMarkFavoriteProduceIdolReply> IL2CPP_TYPE_GENERICINST
    // 078 SelectIdolSkill                          Method`2<ISelectIdolSkillArgs, ISelectIdolSkillReply> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolServiceMethods
    {

        public static ProduceIdolServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolServiceMethods();


            return value;
        }
    }
}
