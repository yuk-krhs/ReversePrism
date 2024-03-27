using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetIdolBaseList                          Method`2<IGetIdolBaseListArgs, IGetIdolBaseListReply> IL2CPP_TYPE_GENERICINST
    // 018 SetIdolBaseCostume                       Method`2<ISetIdolBaseCostumeArgs, ISetIdolBaseCostumeReply> IL2CPP_TYPE_GENERICINST
    // 030 GetIdolLevelRewardList                   Method`2<IGetIdolLevelRewardListArgs, IGetIdolLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    // 048 GetDearnessLevelRewardList               Method`2<IGetDearnessLevelRewardListArgs, IGetDearnessLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    public partial class IdolServiceMethods
    {

        public static IdolServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolServiceMethods();


            return value;
        }
    }
}
