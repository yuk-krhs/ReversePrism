using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetBannerListArgs       Marshaller`1<GetBannerListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetBannerListReply      Marshaller`1<GetBannerListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_GetBannerList                   Method`2<GetBannerListArgs, GetBannerListReply> IL2CPP_TYPE_GENERICINST
    public partial class BannerService : DataModel
    {

        public static BannerService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BannerService() { Pointer= p0 };


            return value;
        }
    }
}
