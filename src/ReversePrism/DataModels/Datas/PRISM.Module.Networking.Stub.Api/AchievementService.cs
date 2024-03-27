using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetAchievementListArgs  Marshaller`1<GetAchievementListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetAchievementListReply Marshaller`1<GetAchievementListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_GetAchievementList              Method`2<GetAchievementListArgs, GetAchievementListReply> IL2CPP_TYPE_GENERICINST
    public partial class AchievementService
    {

        public static AchievementService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementService();


            return value;
        }
    }
}
