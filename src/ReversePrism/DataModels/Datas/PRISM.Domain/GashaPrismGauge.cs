using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrismGaugeId                             000186671910 ModelPrimitiveType string string string String
    // 018 Point                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 RewardList                               000185CFA918 ModelClassListType IReadOnlyList`1<IGashaPrismGaugeRewardStatus> IReadOnlyList`1<IGashaPrismGaugeRewardStatus> List<IGashaPrismGaugeRewardStatus> Pointer
    // 028 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class GashaPrismGauge
    {
        public string                                   PrismGaugeId                            { get; set; }
        public int                                      Point                                   { get; set; }
        public List<IGashaPrismGaugeRewardStatus>?      RewardList                              { get; set; }
        public DateTime                                 EndDate                                 { get; set; }

        public static GashaPrismGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPrismGauge();

            value.PrismGaugeId                              = GetString(new IntPtr(p + 0x010)); // 0270D530C5D8 0x10 PrismGaugeId                ( 000186671910 ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D530C5F8 0x18 Point                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<IGashaPrismGaugeRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGashaPrismGaugeRewardStatus.FromPointer); // 0270D530C618 0x20 RewardList                  ( 000185CFA918 ModelClassListType IReadOnlyList`1<IGashaPrismGaugeRewardStatus> IReadOnlyList`1<IGashaPrismGaugeRewardStatus> List<IGashaPrismGaugeRewardStatus> Pointer )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0270D530C638 0x28 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
