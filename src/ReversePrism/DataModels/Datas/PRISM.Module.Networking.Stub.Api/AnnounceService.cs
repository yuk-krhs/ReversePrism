using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetAnnounceListArgs     Marshaller`1<GetAnnounceListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetAnnounceListReply    Marshaller`1<GetAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetAnnouncePopUpArgs    Marshaller`1<GetAnnouncePopUpArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetAnnouncePopUpReply   Marshaller`1<GetAnnouncePopUpReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ConfirmedAnnounceArgs   Marshaller`1<ConfirmedAnnounceArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ConfirmedAnnounceReply  Marshaller`1<ConfirmedAnnounceReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetAnnounceDetailArgs   Marshaller`1<GetAnnounceDetailArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetAnnounceDetailReply  Marshaller`1<GetAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetAnnounceList                 Method`2<GetAnnounceListArgs, GetAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_GetAnnouncePopUp                Method`2<GetAnnouncePopUpArgs, GetAnnouncePopUpReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_ConfirmedAnnounce               Method`2<ConfirmedAnnounceArgs, ConfirmedAnnounceReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetAnnounceDetail               Method`2<GetAnnounceDetailArgs, GetAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    public partial class AnnounceService
    {

        public static AnnounceService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceService();


            return value;
        }
    }
}
