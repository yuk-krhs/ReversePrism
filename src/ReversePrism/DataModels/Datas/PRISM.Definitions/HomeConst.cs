using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HomeMainResourceTagName                  string IL2CPP_TYPE_STRING
    // 000 HomeRemindItemResourceTagName            string IL2CPP_TYPE_STRING
    // 000 HomeSettingsResourceTagName              string IL2CPP_TYPE_STRING
    // 000 HomeLoginBonusResourceTagName            string IL2CPP_TYPE_STRING
    // 000 ChallengeTourStageDetailTagName          string IL2CPP_TYPE_STRING
    // 000 HomeMotionPathFormat                     string IL2CPP_TYPE_STRING
    // 000 CacheTime                                int IL2CPP_TYPE_I4
    // 000 CharaMessageOpenMinTime                  float IL2CPP_TYPE_R4
    // 000 CharaMessageOpenMaxTime                  float IL2CPP_TYPE_R4
    // 000 CharaMessageCloseTime                    float IL2CPP_TYPE_R4
    // 000 CharaMessageLeaveActionTime              float IL2CPP_TYPE_R4
    // 000 FirstCharaMessageOpenTime                float IL2CPP_TYPE_R4
    public partial class HomeConst : DataModel
    {

        public static HomeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeConst() { Pointer= p0 };


            return value;
        }
    }
}
