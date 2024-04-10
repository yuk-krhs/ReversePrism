using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkillBuffEffect                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 SkillBuffPerfectEffect                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TapSucceedEffect                         000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 038 HoldSucceedEffect                        000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 040 JudgeLineSprite                          000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 048 JudgeLineColor                           0001865AA8E0 ModelEnumType Color Color Color Int32
    // 058 IsHoldEffectPlaying                      000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.SkillBuffEffect                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665029AF0 0x20 SkillBuffEffect             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillBuffPerfectEffect                    = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665029B10 0x28 SkillBuffPerfectEffect      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TapSucceedEffect                          = GetObject<ParticleSystem>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParticleSystem.FromPointer); // 024665029B30 0x30 TapSucceedEffect            ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.HoldSucceedEffect                         = GetObject<ParticleSystem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ParticleSystem.FromPointer); // 024665029B50 0x38 HoldSucceedEffect           ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.JudgeLineSprite                           = GetObject<SpriteRenderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 024665029B70 0x40 JudgeLineSprite             ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.JudgeLineColor                            = (Color)GetInt32(new IntPtr(p + 0x048)); // 024665029B90 0x48 JudgeLineColor              ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.IsHoldEffectPlaying                       = GetBool(new IntPtr(p + 0x058)); // 024665029BB0 0x58 IsHoldEffectPlaying         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
