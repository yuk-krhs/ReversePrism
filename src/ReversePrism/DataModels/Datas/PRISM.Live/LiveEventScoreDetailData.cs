using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScoreRank                                000186616A50 ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 014 Score                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 EventPointBaseScore                      0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MedalScore                               0001865F4260 ModelPrimitiveType int int int Int32
    // 020 EventBonusRate                           000186666CB0 ModelPrimitiveType float float float Single
    // 024 LbRate                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 RewardEventPoint                         0001865F4260 ModelPrimitiveType int int int Int32
    // 02C RewardMedal                              0001865F4260 ModelPrimitiveType int int int Int32
    // 030 <TotalEventPoint>k__BackingField         ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 038 <TotalMedal>k__BackingField              ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 040 EventPointProduct                        0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 048 MedalProduct                             0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    public partial class LiveEventScoreDetailData : DataModel
    {
        public ScoreRank                                ScoreRank                               { get; set; }
        public int                                      Score                                   { get; set; }
        public int                                      EventPointBaseScore                     { get; set; }
        public int                                      MedalScore                              { get; set; }
        public float                                    EventBonusRate                          { get; set; }
        public int                                      LbRate                                  { get; set; }
        public int                                      RewardEventPoint                        { get; set; }
        public int                                      RewardMedal                             { get; set; }
        public IProductStatus?                          EventPointProduct                       { get; set; }
        public IProductStatus?                          MedalProduct                            { get; set; }

        public static LiveEventScoreDetailData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventScoreDetailData() { Pointer= p0 };

            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x010)); // 024665152230 0x10 ScoreRank                   ( 000186616A50 ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x014)); // 024665152250 0x14 Score                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventPointBaseScore                       = GetInt32(new IntPtr(p + 0x018)); // 024665152270 0x18 EventPointBaseScore         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MedalScore                                = GetInt32(new IntPtr(p + 0x01C)); // 024665152290 0x1C MedalScore                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventBonusRate                            = GetSingle(new IntPtr(p + 0x020)); // 0246651522B0 0x20 EventBonusRate              ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.LbRate                                    = GetInt32(new IntPtr(p + 0x024)); // 0246651522D0 0x24 LbRate                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardEventPoint                          = GetInt32(new IntPtr(p + 0x028)); // 0246651522F0 0x28 RewardEventPoint            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardMedal                               = GetInt32(new IntPtr(p + 0x02C)); // 024665152310 0x2C RewardMedal                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventPointProduct                         = GetObject<IProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductStatus.FromPointer); // 024665152370 0x40 EventPointProduct           ( 0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.MedalProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProductStatus.FromPointer); // 024665152390 0x48 MedalProduct                ( 0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )

            return value;
        }
    }
}
