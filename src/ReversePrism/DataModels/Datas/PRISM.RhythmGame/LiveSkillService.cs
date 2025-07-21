using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Skills                                   ModelClassListType RhythmGameLiveSkill[] RhythmGameLiveSkill[] List<RhythmGameLiveSkill> Pointer
    // 018 ValidSkills                              ModelClassListType RhythmGameLiveSkill[] RhythmGameLiveSkill[] List<RhythmGameLiveSkill> Pointer
    // 020 PooledEffectList                         ModelClassListType List`1<RhythmGameLiveSkillEffect> List`1<RhythmGameLiveSkillEffect> List<RhythmGameLiveSkillEffect> Pointer
    public partial class LiveSkillService : DataModel
    {
        public List<RhythmGameLiveSkill>?               Skills                                  { get; set; }
        public List<RhythmGameLiveSkill>?               ValidSkills                             { get; set; }
        public List<RhythmGameLiveSkillEffect>?         PooledEffectList                        { get; set; }

        public static LiveSkillService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillService() { Pointer= p0 };

            value.Skills                                    = GetObjectList<RhythmGameLiveSkill>(new IntPtr(p + 0x010), ReversePrism.DataModels.RhythmGameLiveSkill.FromPointer); // 0x10 Skills                      ( ModelClassListType RhythmGameLiveSkill[] RhythmGameLiveSkill[] List<RhythmGameLiveSkill> Pointer )
            value.ValidSkills                               = GetObjectList<RhythmGameLiveSkill>(new IntPtr(p + 0x018), ReversePrism.DataModels.RhythmGameLiveSkill.FromPointer); // 0x18 ValidSkills                 ( ModelClassListType RhythmGameLiveSkill[] RhythmGameLiveSkill[] List<RhythmGameLiveSkill> Pointer )
            value.PooledEffectList                          = GetObjectList<RhythmGameLiveSkillEffect>(new IntPtr(p + 0x020), ReversePrism.DataModels.RhythmGameLiveSkillEffect.FromPointer); // 0x20 PooledEffectList            ( ModelClassListType List`1<RhythmGameLiveSkillEffect> List`1<RhythmGameLiveSkillEffect> List<RhythmGameLiveSkillEffect> Pointer )

            return value;
        }
    }
}
