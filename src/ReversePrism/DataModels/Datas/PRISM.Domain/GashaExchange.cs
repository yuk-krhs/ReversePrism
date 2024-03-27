using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GashaExchangeId                          000186671910 ModelPrimitiveType string string string String
    // 018 Point                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 RewardList                               000185CF9B88 ModelClassListType IReadOnlyList`1<IGashaExchangeRewardStatus> IReadOnlyList`1<IGashaExchangeRewardStatus> List<IGashaExchangeRewardStatus> Pointer
    public partial class GashaExchange
    {
        public string                                   GashaExchangeId                         { get; set; }
        public int                                      Point                                   { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public List<IGashaExchangeRewardStatus>?        RewardList                              { get; set; }

        public static GashaExchange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchange();

            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x010)); // 0270D530D030 0x10 GashaExchangeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D530D050 0x18 Point                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D530D070 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.RewardList                                = GetObjectList<IGashaExchangeRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IGashaExchangeRewardStatus.FromPointer); // 0270D530D090 0x30 RewardList                  ( 000185CF9B88 ModelClassListType IReadOnlyList`1<IGashaExchangeRewardStatus> IReadOnlyList`1<IGashaExchangeRewardStatus> List<IGashaExchangeRewardStatus> Pointer )

            return value;
        }
    }
}
