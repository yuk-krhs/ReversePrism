using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScoreRank                                ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 014 Score                                    ModelPrimitiveType int int int Int32
    // 018 EventPointBaseScore                      ModelPrimitiveType int int int Int32
    // 01C MedalScore                               ModelPrimitiveType int int int Int32
    // 020 EventBonusRate                           ModelPrimitiveType float float float Single
    // 024 LbRate                                   ModelPrimitiveType int int int Int32
    // 028 RewardEventPoint                         ModelPrimitiveType int int int Int32
    // 02C RewardMedal                              ModelPrimitiveType int int int Int32
    // 030 <TotalEventPoint>k__BackingField         ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 038 <TotalMedal>k__BackingField              ValueTuple`2<int, int> IL2CPP_TYPE_GENERICINST
    // 040 EventPointProduct                        ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 048 MedalProduct                             ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 050 EventMaster                              ModelClassType MstEvent MstEvent MstEvent Pointer
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
        public MstEvent?                                EventMaster                             { get; set; }

        public static LiveEventScoreDetailData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventScoreDetailData() { Pointer= p0 };

            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScoreRank                   ( ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Score                       ( ModelPrimitiveType int int int Int32 )
            value.EventPointBaseScore                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 EventPointBaseScore         ( ModelPrimitiveType int int int Int32 )
            value.MedalScore                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MedalScore                  ( ModelPrimitiveType int int int Int32 )
            value.EventBonusRate                            = GetSingle(new IntPtr(p + 0x020)); // 0x20 EventBonusRate              ( ModelPrimitiveType float float float Single )
            value.LbRate                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 LbRate                      ( ModelPrimitiveType int int int Int32 )
            value.RewardEventPoint                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 RewardEventPoint            ( ModelPrimitiveType int int int Int32 )
            value.RewardMedal                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C RewardMedal                 ( ModelPrimitiveType int int int Int32 )
            value.EventPointProduct                         = GetObject<IProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x40 EventPointProduct           ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.MedalProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x48 MedalProduct                ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.EventMaster                               = GetObject<MstEvent>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstEvent.FromPointer); // 0x50 EventMaster                 ( ModelClassType MstEvent MstEvent MstEvent Pointer )

            return value;
        }
    }
}
