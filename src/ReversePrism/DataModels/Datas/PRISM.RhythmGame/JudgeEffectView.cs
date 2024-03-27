using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TapEffects                               000185B9AC50 ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer
    // 028 FlickEffects                             000185B9AC50 ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer
    // 030 KimeEffect                               000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 038 LongNotesEffect                          000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 040 JointNotesEffect                         000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 048 SkillNotesEffect                         000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 050 TapEffectPools                           000185B9AA50 ModelClassListType ParticlePool[] ParticlePool[] List<ParticlePool> Pointer
    // 058 FlickEffectPools                         000185B9AA50 ModelClassListType ParticlePool[] ParticlePool[] List<ParticlePool> Pointer
    // 060 KimeEffectPool                           000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer
    // 068 LongNotesEffectPool                      000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer
    // 070 JointNotesEffectPool                     000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer
    // 078 SkillNotesEffectPool                     000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer
    // 080 playingLongNotesEffectIds                Dictionary`2<int, ParticleSystem> IL2CPP_TYPE_GENERICINST
    public partial class JudgeEffectView
    {
        public List<ParticleSystem>?                    TapEffects                              { get; set; }
        public List<ParticleSystem>?                    FlickEffects                            { get; set; }
        public ParticleSystem?                          KimeEffect                              { get; set; }
        public ParticleSystem?                          LongNotesEffect                         { get; set; }
        public ParticleSystem?                          JointNotesEffect                        { get; set; }
        public ParticleSystem?                          SkillNotesEffect                        { get; set; }
        public List<ParticlePool>?                      TapEffectPools                          { get; set; }
        public List<ParticlePool>?                      FlickEffectPools                        { get; set; }
        public ParticlePool?                            KimeEffectPool                          { get; set; }
        public ParticlePool?                            LongNotesEffectPool                     { get; set; }
        public ParticlePool?                            JointNotesEffectPool                    { get; set; }
        public ParticlePool?                            SkillNotesEffectPool                    { get; set; }

        public static JudgeEffectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgeEffectView();

            value.TapEffects                                = GetObjectList<ParticleSystem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4FE1F48 0x20 TapEffects                  ( 000185B9AC50 ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer )
            value.FlickEffects                              = GetObjectList<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4FE1F68 0x28 FlickEffects                ( 000185B9AC50 ModelClassListType ParticleSystem[] ParticleSystem[] List<ParticleSystem> Pointer )
            value.KimeEffect                                = GetObject<ParticleSystem>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4FE1F88 0x30 KimeEffect                  ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.LongNotesEffect                           = GetObject<ParticleSystem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4FE1FA8 0x38 LongNotesEffect             ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.JointNotesEffect                          = GetObject<ParticleSystem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4FE1FC8 0x40 JointNotesEffect            ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.SkillNotesEffect                          = GetObject<ParticleSystem>(new IntPtr(p + 0x048), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D4FE1FE8 0x48 SkillNotesEffect            ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.TapEffectPools                            = GetObjectList<ParticlePool>(new IntPtr(p + 0x050), ReversePrism.DataModels.ParticlePool.FromPointer); // 0270D4FE2008 0x50 TapEffectPools              ( 000185B9AA50 ModelClassListType ParticlePool[] ParticlePool[] List<ParticlePool> Pointer )
            value.FlickEffectPools                          = GetObjectList<ParticlePool>(new IntPtr(p + 0x058), ReversePrism.DataModels.ParticlePool.FromPointer); // 0270D4FE2028 0x58 FlickEffectPools            ( 000185B9AA50 ModelClassListType ParticlePool[] ParticlePool[] List<ParticlePool> Pointer )
            value.KimeEffectPool                            = GetObject<ParticlePool>(new IntPtr(p + 0x060), ReversePrism.DataModels.ParticlePool.FromPointer); // 0270D4FE2048 0x60 KimeEffectPool              ( 000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer )
            value.LongNotesEffectPool                       = GetObject<ParticlePool>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParticlePool.FromPointer); // 0270D4FE2068 0x68 LongNotesEffectPool         ( 000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer )
            value.JointNotesEffectPool                      = GetObject<ParticlePool>(new IntPtr(p + 0x070), ReversePrism.DataModels.ParticlePool.FromPointer); // 0270D4FE2088 0x70 JointNotesEffectPool        ( 000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer )
            value.SkillNotesEffectPool                      = GetObject<ParticlePool>(new IntPtr(p + 0x078), ReversePrism.DataModels.ParticlePool.FromPointer); // 0270D4FE20A8 0x78 SkillNotesEffectPool        ( 000186723880 ModelClassType ParticlePool ParticlePool ParticlePool Pointer )

            return value;
        }
    }
}
