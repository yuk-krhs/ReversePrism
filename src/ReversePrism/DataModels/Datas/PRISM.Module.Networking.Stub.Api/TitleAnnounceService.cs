using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetTitleAnnounceListArgs Marshaller`1<GetTitleAnnounceListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetTitleAnnounceListReply Marshaller`1<GetTitleAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetTitleAnnounceDetailArgs Marshaller`1<GetTitleAnnounceDetailArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetTitleAnnounceDetailReply Marshaller`1<GetTitleAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetTitleAnnounceList            Method`2<GetTitleAnnounceListArgs, GetTitleAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_GetTitleAnnounceDetail          Method`2<GetTitleAnnounceDetailArgs, GetTitleAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    public partial class TitleAnnounceService
    {

        public static TitleAnnounceService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleAnnounceService();


            return value;
        }
    }
}
