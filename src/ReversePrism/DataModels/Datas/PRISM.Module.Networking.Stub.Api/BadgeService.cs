using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetAmountBadgeListArgs  Marshaller`1<GetAmountBadgeListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetAmountBadgeListReply Marshaller`1<GetAmountBadgeListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetLastUpdateDateListArgs Marshaller`1<GetLastUpdateDateListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetLastUpdateDateListReply Marshaller`1<GetLastUpdateDateListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetCampaignIconListArgs Marshaller`1<GetCampaignIconListArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetCampaignIconListReply Marshaller`1<GetCampaignIconListReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetMenuUnlockListArgs   Marshaller`1<GetMenuUnlockListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetMenuUnlockListReply  Marshaller`1<GetMenuUnlockListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetAmountBadgeList              Method`2<GetAmountBadgeListArgs, GetAmountBadgeListReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_GetLastUpdateDateList           Method`2<GetLastUpdateDateListArgs, GetLastUpdateDateListReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetCampaignIconList             Method`2<GetCampaignIconListArgs, GetCampaignIconListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetMenuUnlockList               Method`2<GetMenuUnlockListArgs, GetMenuUnlockListReply> IL2CPP_TYPE_GENERICINST
    public partial class BadgeService : DataModel
    {

        public static BadgeService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeService() { Pointer= p0 };


            return value;
        }
    }
}
