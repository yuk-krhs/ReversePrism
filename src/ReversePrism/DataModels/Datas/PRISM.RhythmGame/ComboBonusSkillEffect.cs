using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MinScoreUpRate                           ModelPrimitiveType float float float Single
    // 024 MaxScoreUpRate                           ModelPrimitiveType float float float Single
    // 028 ScoreUpRateStep                          ModelPrimitiveType float float float Single
    // 02C ComboStep                                ModelPrimitiveType int int int Int32
    public partial class ComboBonusSkillEffect : DataModel
    {
        public float                                    MinScoreUpRate                          { get; set; }
        public float                                    MaxScoreUpRate                          { get; set; }
        public float                                    ScoreUpRateStep                         { get; set; }
        public int                                      ComboStep                               { get; set; }

        public static ComboBonusSkillEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComboBonusSkillEffect() { Pointer= p0 };

            value.MinScoreUpRate                            = GetSingle(new IntPtr(p + 0x020)); // 0x20 MinScoreUpRate              ( ModelPrimitiveType float float float Single )
            value.MaxScoreUpRate                            = GetSingle(new IntPtr(p + 0x024)); // 0x24 MaxScoreUpRate              ( ModelPrimitiveType float float float Single )
            value.ScoreUpRateStep                           = GetSingle(new IntPtr(p + 0x028)); // 0x28 ScoreUpRateStep             ( ModelPrimitiveType float float float Single )
            value.ComboStep                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ComboStep                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
