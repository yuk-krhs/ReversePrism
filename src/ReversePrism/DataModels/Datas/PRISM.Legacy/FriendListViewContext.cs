using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 <OnLondPressPFIcon>k__BackingField       Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 040 <OnClickAchievement>k__BackingField      Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    public partial class FriendListViewContext : DataModel
    {

        public static FriendListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
