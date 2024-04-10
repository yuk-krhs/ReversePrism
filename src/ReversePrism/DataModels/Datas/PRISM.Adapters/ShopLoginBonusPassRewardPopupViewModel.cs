using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartValidDateText                       000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndValidDateText                         000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 RewardItemProductAmount                  0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 038 IsNotShowLoginPassReward                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 PassEffectEndPULastViewedDateTime        000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 050 ValidPeriodText                          000186671910 ModelPrimitiveType string string string String
    public partial class ShopLoginBonusPassRewardPopupViewModel : DataModel
    {
        public DateTime                                 StartValidDateText                      { get; set; }
        public DateTime                                 EndValidDateText                        { get; set; }
        public IProductWithAmountStatus?                RewardItemProductAmount                 { get; set; }
        public bool                                     IsNotShowLoginPassReward                { get; set; }
        public DateTime                                 PassEffectEndPULastViewedDateTime       { get; set; }
        public string                                   ValidPeriodText                         { get; set; }

        public static ShopLoginBonusPassRewardPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLoginBonusPassRewardPopupViewModel() { Pointer= p0 };

            value.StartValidDateText                        = GetDateTime(new IntPtr(p + 0x010)); // 0245A5B53500 0x10 StartValidDateText          ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndValidDateText                          = GetDateTime(new IntPtr(p + 0x020)); // 0245A5B53520 0x20 EndValidDateText            ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.RewardItemProductAmount                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0245A5B53540 0x30 RewardItemProductAmount     ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.IsNotShowLoginPassReward                  = GetBool(new IntPtr(p + 0x038)); // 0245A5B53560 0x38 IsNotShowLoginPassReward    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PassEffectEndPULastViewedDateTime         = GetDateTime(new IntPtr(p + 0x040)); // 0245A5B53580 0x40 PassEffectEndPULastViewedDateTime ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ValidPeriodText                           = GetString(new IntPtr(p + 0x050)); // 0245A5B535A0 0x50 ValidPeriodText             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
