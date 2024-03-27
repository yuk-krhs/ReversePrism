using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastUpdateDateList                       00018653E690 ModelClassType IGetLastUpdateDateListReply IGetLastUpdateDateListReply IGetLastUpdateDateListReply Pointer
    // 018 CampaignIconList                         00018652DE50 ModelClassType IGetCampaignIconListReply IGetCampaignIconListReply IGetCampaignIconListReply Pointer
    public partial class BadgeCache
    {
        public IGetLastUpdateDateListReply?             LastUpdateDateList                      { get; set; }
        public IGetCampaignIconListReply?               CampaignIconList                        { get; set; }

        public static BadgeCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeCache();

            value.LastUpdateDateList                        = GetObject<IGetLastUpdateDateListReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGetLastUpdateDateListReply.FromPointer); // 027004A857F8 0x10 LastUpdateDateList          ( 00018653E690 ModelClassType IGetLastUpdateDateListReply IGetLastUpdateDateListReply IGetLastUpdateDateListReply Pointer )
            value.CampaignIconList                          = GetObject<IGetCampaignIconListReply>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGetCampaignIconListReply.FromPointer); // 027004A85818 0x18 CampaignIconList            ( 00018652DE50 ModelClassType IGetCampaignIconListReply IGetCampaignIconListReply IGetCampaignIconListReply Pointer )

            return value;
        }
    }
}
