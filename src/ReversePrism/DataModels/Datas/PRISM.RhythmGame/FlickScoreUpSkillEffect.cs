using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreUpRate                              0001866656B0 ModelPrimitiveType float float float Single
    public partial class FlickScoreUpSkillEffect
    {
        public float                                    ScoreUpRate                             { get; set; }

        public static FlickScoreUpSkillEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FlickScoreUpSkillEffect();

            value.ScoreUpRate                               = GetSingle(new IntPtr(p + 0x020)); // 0270D4F8A2B8 0x20 ScoreUpRate                 ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
