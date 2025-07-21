using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventStatus                              ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 018 EffectStatus                             ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer
    // 020 Rank                                     ModelPrimitiveType int int int Int32
    public partial class PvpRankingArgument : DataModel
    {
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public IPvpEventEffectStatus?                   EffectStatus                            { get; set; }
        public int                                      Rank                                    { get; set; }

        public static PvpRankingArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingArgument() { Pointer= p0 };

            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0x10 EventStatus                 ( ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.EffectStatus                              = GetObject<IPvpEventEffectStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPvpEventEffectStatus.FromPointer); // 0x18 EffectStatus                ( ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Rank                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
