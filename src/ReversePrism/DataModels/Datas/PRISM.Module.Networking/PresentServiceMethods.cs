using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetPresentList                           Method`2<IGetPresentListArgs, IGetPresentListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetPresentHistoryList                    Method`2<IGetPresentHistoryListArgs, IGetPresentHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 030 ReceivePresent                           Method`2<IReceivePresentArgs, IReceivePresentReply> IL2CPP_TYPE_GENERICINST
    public partial class PresentServiceMethods
    {

        public static PresentServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentServiceMethods();


            return value;
        }
    }
}
