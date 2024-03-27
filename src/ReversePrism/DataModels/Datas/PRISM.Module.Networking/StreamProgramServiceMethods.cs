using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetStreamProgramList                     Method`2<IGetStreamProgramListArgs, IGetStreamProgramListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetStreamProgramInfo                     Method`2<IGetStreamProgramInfoArgs, IGetStreamProgramInfoReply> IL2CPP_TYPE_GENERICINST
    // 030 GetStreamProgramURL                      Method`2<IGetStreamProgramURLArgs, IGetStreamProgramURLReply> IL2CPP_TYPE_GENERICINST
    // 048 GetStreamArchiveList                     Method`2<IGetStreamArchiveListArgs, IGetStreamArchiveListReply> IL2CPP_TYPE_GENERICINST
    // 060 GetStreamArchiveLiveURL                  Method`2<IGetStreamArchiveLiveURLArgs, IGetStreamArchiveLiveURLReply> IL2CPP_TYPE_GENERICINST
    // 078 ToggleArchiveFavorite                    Method`2<IToggleArchiveFavoriteArgs, IToggleArchiveFavoriteReply> IL2CPP_TYPE_GENERICINST
    public partial class StreamProgramServiceMethods
    {

        public static StreamProgramServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamProgramServiceMethods();


            return value;
        }
    }
}
