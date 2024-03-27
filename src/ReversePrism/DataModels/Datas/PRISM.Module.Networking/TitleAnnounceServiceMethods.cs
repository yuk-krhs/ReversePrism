using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetTitleAnnounceList                     Method`2<IGetTitleAnnounceListArgs, IGetTitleAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetTitleAnnounceDetail                   Method`2<IGetTitleAnnounceDetailArgs, IGetTitleAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    public partial class TitleAnnounceServiceMethods
    {

        public static TitleAnnounceServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleAnnounceServiceMethods();


            return value;
        }
    }
}
