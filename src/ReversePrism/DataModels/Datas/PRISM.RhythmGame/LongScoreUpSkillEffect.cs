using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreUpRate                              ModelPrimitiveType float float float Single
    public partial class LongScoreUpSkillEffect : DataModel
    {
        public float                                    ScoreUpRate                             { get; set; }

        public static LongScoreUpSkillEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LongScoreUpSkillEffect() { Pointer= p0 };

            value.ScoreUpRate                               = GetSingle(new IntPtr(p + 0x020)); // 0x20 ScoreUpRate                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
