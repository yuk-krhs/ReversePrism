using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 onClickSubject                           Subject`1<IPvpOpponentStatus> IL2CPP_TYPE_GENERICINST
    // 070 onClickDetailSubject                     Subject`1<IPvpOpponentStatus> IL2CPP_TYPE_GENERICINST
    public partial class PvpUseListView
    {

        public static PvpUseListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUseListView();


            return value;
        }
    }
}
