using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetAmountBadgeList                       Method`2<IGetAmountBadgeListArgs, IGetAmountBadgeListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetLastUpdateDateList                    Method`2<IGetLastUpdateDateListArgs, IGetLastUpdateDateListReply> IL2CPP_TYPE_GENERICINST
    // 030 GetCampaignIconList                      Method`2<IGetCampaignIconListArgs, IGetCampaignIconListReply> IL2CPP_TYPE_GENERICINST
    // 048 GetMenuUnlockList                        Method`2<IGetMenuUnlockListArgs, IGetMenuUnlockListReply> IL2CPP_TYPE_GENERICINST
    public partial class BadgeServiceMethods
    {

        public static BadgeServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeServiceMethods();


            return value;
        }
    }
}
