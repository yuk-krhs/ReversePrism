using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 RankUpIconBlinkDuration                  ModelPrimitiveType float float float Single
    // 0AC RankUpIconBlinkValue                     ModelPrimitiveType float float float Single
    // 0B0 rankUpIconBlinkTweener                   TweenerCore`3<float, float, FloatOptions> IL2CPP_TYPE_GENERICINST
    public partial class PCardRankUpGridView : DataModel
    {
        public float                                    RankUpIconBlinkDuration                 { get; set; }
        public float                                    RankUpIconBlinkValue                    { get; set; }

        public static PCardRankUpGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpGridView() { Pointer= p0 };

            value.RankUpIconBlinkDuration                   = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 RankUpIconBlinkDuration     ( ModelPrimitiveType float float float Single )
            value.RankUpIconBlinkValue                      = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC RankUpIconBlinkValue        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
