using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 JudgeRenderer                            000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 FastSlowView                             000186765610 ModelClassType JudgeFastSlowView JudgeFastSlowView JudgeFastSlowView Pointer
    // 030 Sprites                                  000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 038 Sequence                                 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer
    // 040 LastJudgeTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 048 Clone                                    000186765FA0 ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer
    public partial class JudgeResultView : DataModel
    {
        public SpriteRenderer?                          JudgeRenderer                           { get; set; }
        public JudgeFastSlowView?                       FastSlowView                            { get; set; }
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

            value.JudgeRenderer                             = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0246650A3518 0x20 JudgeRenderer               ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.FastSlowView                              = GetObject<JudgeFastSlowView>(new IntPtr(p + 0x028), ReversePrism.DataModels.JudgeFastSlowView.FromPointer); // 0246650A3538 0x28 FastSlowView                ( 000186765610 ModelClassType JudgeFastSlowView JudgeFastSlowView JudgeFastSlowView Pointer )
            value.Sprites                                   = GetObjectList<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0246650A3558 0x30 Sprites                     ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sequence.FromPointer); // 0246650A3578 0x38 Sequence                    ( 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer )
            value.LastJudgeTime                             = GetSingle(new IntPtr(p + 0x040)); // 0246650A3598 0x40 LastJudgeTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Clone                                     = GetObject<JudgeResultView>(new IntPtr(p + 0x048), ReversePrism.DataModels.JudgeResultView.FromPointer); // 0246650A35B8 0x48 Clone                       ( 000186765FA0 ModelClassType JudgeResultView JudgeResultView JudgeResultView Pointer )

            return value;
        }
    }
}
