using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetAnnounceList                          Method`2<IGetAnnounceListArgs, IGetAnnounceListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetAnnouncePopUp                         Method`2<IGetAnnouncePopUpArgs, IGetAnnouncePopUpReply> IL2CPP_TYPE_GENERICINST
    // 030 ConfirmedAnnounce                        Method`2<IConfirmedAnnounceArgs, IConfirmedAnnounceReply> IL2CPP_TYPE_GENERICINST
    // 048 GetAnnounceDetail                        Method`2<IGetAnnounceDetailArgs, IGetAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    public partial class AnnounceServiceMethods : DataModel
    {

        public static AnnounceServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
