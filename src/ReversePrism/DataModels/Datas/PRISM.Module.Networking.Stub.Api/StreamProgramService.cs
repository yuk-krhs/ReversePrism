using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetStreamProgramListArgs Marshaller`1<GetStreamProgramListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetStreamProgramListReply Marshaller`1<GetStreamProgramListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetStreamProgramInfoArgs Marshaller`1<GetStreamProgramInfoArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetStreamProgramInfoReply Marshaller`1<GetStreamProgramInfoReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetStreamProgramURLArgs Marshaller`1<GetStreamProgramURLArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetStreamProgramURLReply Marshaller`1<GetStreamProgramURLReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetStreamArchiveListArgs Marshaller`1<GetStreamArchiveListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetStreamArchiveListReply Marshaller`1<GetStreamArchiveListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetStreamArchiveLiveURLArgs Marshaller`1<GetStreamArchiveLiveURLArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetStreamArchiveLiveURLReply Marshaller`1<GetStreamArchiveLiveURLReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_ToggleArchiveFavoriteArgs Marshaller`1<ToggleArchiveFavoriteArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_ToggleArchiveFavoriteReply Marshaller`1<ToggleArchiveFavoriteReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_GetStreamProgramList            Method`2<GetStreamProgramListArgs, GetStreamProgramListReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_GetStreamProgramInfo            Method`2<GetStreamProgramInfoArgs, GetStreamProgramInfoReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_GetStreamProgramURL             Method`2<GetStreamProgramURLArgs, GetStreamProgramURLReply> IL2CPP_TYPE_GENERICINST
    // 080 __Method_GetStreamArchiveList            Method`2<GetStreamArchiveListArgs, GetStreamArchiveListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_GetStreamArchiveLiveURL         Method`2<GetStreamArchiveLiveURLArgs, GetStreamArchiveLiveURLReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_ToggleArchiveFavorite           Method`2<ToggleArchiveFavoriteArgs, ToggleArchiveFavoriteReply> IL2CPP_TYPE_GENERICINST
    public partial class StreamProgramService
    {

        public static StreamProgramService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamProgramService();


            return value;
        }
    }
}
