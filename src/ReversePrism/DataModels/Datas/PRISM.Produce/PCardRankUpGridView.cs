using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 RankUpIconBlinkDuration                  0001866656B0 ModelPrimitiveType float float float Single
    // 0AC RankUpIconBlinkValue                     0001866656B0 ModelPrimitiveType float float float Single
    // 0B0 rankUpIconBlinkTweener                   TweenerCore`3<float, float, FloatOptions> IL2CPP_TYPE_GENERICINST
    public partial class PCardRankUpGridView
    {
        public float                                    RankUpIconBlinkDuration                 { get; set; }
        public float                                    RankUpIconBlinkValue                    { get; set; }

        public static PCardRankUpGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpGridView();

            value.RankUpIconBlinkDuration                   = GetSingle(new IntPtr(p + 0x0A8)); // 0270D5CEA390 0xA8 RankUpIconBlinkDuration     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RankUpIconBlinkValue                      = GetSingle(new IntPtr(p + 0x0AC)); // 0270D5CEA3B0 0xAC RankUpIconBlinkValue        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
