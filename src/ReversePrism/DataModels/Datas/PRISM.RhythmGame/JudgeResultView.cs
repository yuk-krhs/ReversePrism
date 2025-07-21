using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 JudgeRenderer                            ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 FastSlowView                             ModelClassType JudgeFastSlowView JudgeFastSlowView JudgeFastSlowView Pointer
    // 030 SkillBoostedBadge                        ModelClassType GameObject GameObject GameObject Pointer
    // 038 Sprites                                  ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 040 Sequence                                 ModelClassType Sequence Sequence Sequence Pointer
    // 048 LastJudgeTime                            ModelPrimitiveType float float float Single
    // 050 Clone                                    ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer
    public partial class JudgeResultView : DataModel
    {
        public SpriteRenderer?                          JudgeRenderer                           { get; set; }
        public JudgeFastSlowView?                       FastSlowView                            { get; set; }
        public GameObject?                              SkillBoostedBadge                       { get; set; }
        public List<Sprite>?                            Sprites                                 { get; set; }
        public Sequence?                                Sequence                                { get; set; }
        public float                                    LastJudgeTime                           { get; set; }
        public JudgeResultView?                         Clone                                   { get; set; }

        public static JudgeResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgeResultView() { Pointer= p0 };

            value.JudgeRenderer                             = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x20 JudgeRenderer               ( ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.FastSlowView                              = GetObject<JudgeFastSlowView>(new IntPtr(p + 0x028), ReversePrism.DataModels.JudgeFastSlowView.FromPointer); // 0x28 FastSlowView                ( ModelClassType JudgeFastSlowView JudgeFastSlowView JudgeFastSlowView Pointer )
            value.SkillBoostedBadge                         = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SkillBoostedBadge           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Sprites                                   = GetObjectList<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0x38 Sprites                     ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sequence.FromPointer); // 0x40 Sequence                    ( ModelClassType Sequence Sequence Sequence Pointer )
            value.LastJudgeTime                             = GetSingle(new IntPtr(p + 0x048)); // 0x48 LastJudgeTime               ( ModelPrimitiveType float float float Single )
            value.Clone                                     = GetObject<JudgeResultView>(new IntPtr(p + 0x050), ReversePrism.DataModels.JudgeResultView.FromPointer); // 0x50 Clone                       ( ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer )

            return value;
        }
    }
}
