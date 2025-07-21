using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onShowSCharaDetailPopup                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProduceFriendSupportListViewContext : DataModel
    {

        public static ProduceFriendSupportListViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportListViewContext() { Pointer= p0 };


            return value;
        }
    }
}
