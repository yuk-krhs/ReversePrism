using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkillBuffEffect                          ModelClassType GameObject GameObject GameObject Pointer
    // 028 SkillBuffPerfectEffect                   ModelClassType GameObject GameObject GameObject Pointer
    // 030 TapSucceedEffect                         ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 038 HoldSucceedEffect                        ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 040 JudgeLineSprite                          ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 048 JudgeLineColor                           ModelEnumType Color Color Color Int32
    // 058 IsHoldEffectPlaying                      ModelPrimitiveType bool bool bool Bool
    public partial class JudgeLine : DataModel
    {
        public GameObject?                              SkillBuffEffect                         { get; set; }
        public GameObject?                              SkillBuffPerfectEffect                  { get; set; }
        public ParticleSystem?                          TapSucceedEffect                        { get; set; }
        public ParticleSystem?                          HoldSucceedEffect                       { get; set; }
        public SpriteRenderer?                          JudgeLineSprite                         { get; set; }
        public Color                                    JudgeLineColor                          { get; set; }
        public bool                                     IsHoldEffectPlaying                     { get; set; }

        public static JudgeLine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgeLine() { Pointer= p0 };

            value.SkillBuffEffect                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 SkillBuffEffect             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillBuffPerfectEffect                    = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 SkillBuffPerfectEffect      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TapSucceedEffect                          = GetObject<ParticleSystem>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x30 TapSucceedEffect            ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.HoldSucceedEffect                         = GetObject<ParticleSystem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x38 HoldSucceedEffect           ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.JudgeLineSprite                           = GetObject<SpriteRenderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x40 JudgeLineSprite             ( ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.JudgeLineColor                            = (Color)GetInt32(new IntPtr(p + 0x048)); // 0x48 JudgeLineColor              ( ModelEnumType Color Color Color Int32 )
            value.IsHoldEffectPlaying                       = GetBool(new IntPtr(p + 0x058)); // 0x58 IsHoldEffectPlaying         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
