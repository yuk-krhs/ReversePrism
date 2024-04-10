using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetAchievementList                       Method`2<IGetAchievementListArgs, IGetAchievementListReply> IL2CPP_TYPE_GENERICINST
    public partial class AchievementServiceMethods : DataModel
    {

        public static AchievementServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
