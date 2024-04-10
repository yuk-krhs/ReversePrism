using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MinScoreUpRate                           0001866656B0 ModelPrimitiveType float float float Single
    // 024 MaxScoreUpRate                           0001866656B0 ModelPrimitiveType float float float Single
    // 028 ScoreUpRateStep                          0001866656B0 ModelPrimitiveType float float float Single
    // 02C ComboStep                                0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.MinScoreUpRate                            = GetSingle(new IntPtr(p + 0x020)); // 024665011980 0x20 MinScoreUpRate              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxScoreUpRate                            = GetSingle(new IntPtr(p + 0x024)); // 0246650119A0 0x24 MaxScoreUpRate              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScoreUpRateStep                           = GetSingle(new IntPtr(p + 0x028)); // 0246650119C0 0x28 ScoreUpRateStep             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ComboStep                                 = GetInt32(new IntPtr(p + 0x02C)); // 0246650119E0 0x2C ComboStep                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
