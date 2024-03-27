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
    public partial class ShopLoginBonusPassRewardPopupViewModel
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
            var value   = new ShopLoginBonusPassRewardPopupViewModel();

            value.StartValidDateText                        = GetDateTime(new IntPtr(p + 0x010)); // 027003664A60 0x10 StartValidDateText          ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndValidDateText                          = GetDateTime(new IntPtr(p + 0x020)); // 027003664A80 0x20 EndValidDateText            ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.RewardItemProductAmount                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 027003664AA0 0x30 RewardItemProductAmount     ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.IsNotShowLoginPassReward                  = GetBool(new IntPtr(p + 0x038)); // 027003664AC0 0x38 IsNotShowLoginPassReward    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PassEffectEndPULastViewedDateTime         = GetDateTime(new IntPtr(p + 0x040)); // 027003664AE0 0x40 PassEffectEndPULastViewedDateTime ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ValidPeriodText                           = GetString(new IntPtr(p + 0x050)); // 027003664B00 0x50 ValidPeriodText             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
