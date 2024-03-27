using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventStatus                              00018651ED50 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 018 EffectStatus                             000186605610 ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer
    // 020 Rank                                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class LegacyPvpRankingParameter
    {
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public IPvpEventEffectStatus?                   EffectStatus                            { get; set; }
        public int                                      Rank                                    { get; set; }

        public static LegacyPvpRankingParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyPvpRankingParameter();

            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0270D5E3E968 0x10 EventStatus                 ( 00018651ED50 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.EffectStatus                              = GetObject<IPvpEventEffectStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPvpEventEffectStatus.FromPointer); // 0270D5E3E988 0x18 EffectStatus                ( 000186605610 ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D5E3E9A8 0x20 Rank                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
