using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TapEffects                               ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer
    // 028 FlickEffects                             ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer
    // 030 KimeEffect                               ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 038 LongNotesEffect                          ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 040 JointNotesEffect                         ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 048 SkillNotesEffect                         ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 050 tapEffectPools                           ObjectPool`1<ParticleSystem>[] IL2CPP_TYPE_SZARRAY
    // 058 flickEffectPools                         ObjectPool`1<ParticleSystem>[] IL2CPP_TYPE_SZARRAY
    // 060 kimeEffectPool                           ObjectPool`1<ParticleSystem> IL2CPP_TYPE_GENERICINST
    // 068 longNotesEffectPool                      ObjectPool`1<ParticleSystem> IL2CPP_TYPE_GENERICINST
    // 070 jointNotesEffectPool                     ObjectPool`1<ParticleSystem> IL2CPP_TYPE_GENERICINST
    // 078 skillNotesEffectPool                     ObjectPool`1<ParticleSystem> IL2CPP_TYPE_GENERICINST
    // 080 playingLongNotesEffectIds                Dictionary`2<int, ParticleSystem> IL2CPP_TYPE_GENERICINST
    public partial class JudgeEffectView : DataModel
    {
        public List<ParticleSystem>?                    TapEffects                              { get; set; }
        public List<ParticleSystem>?                    FlickEffects                            { get; set; }
        public ParticleSystem?                          KimeEffect                              { get; set; }
        public ParticleSystem?                          LongNotesEffect                         { get; set; }
        public ParticleSystem?                          JointNotesEffect                        { get; set; }
        public ParticleSystem?                          SkillNotesEffect                        { get; set; }

        public static JudgeEffectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgeEffectView() { Pointer= p0 };

            value.TapEffects                                = GetObjectList<ParticleSystem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x20 TapEffects                  ( ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer )
            value.FlickEffects                              = GetObjectList<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x28 FlickEffects                ( ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer )
            value.KimeEffect                                = GetObject<ParticleSystem>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x30 KimeEffect                  ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.LongNotesEffect                           = GetObject<ParticleSystem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x38 LongNotesEffect             ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.JointNotesEffect                          = GetObject<ParticleSystem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x40 JointNotesEffect            ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.SkillNotesEffect                          = GetObject<ParticleSystem>(new IntPtr(p + 0x048), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x48 SkillNotesEffect            ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )

            return value;
        }
    }
}
