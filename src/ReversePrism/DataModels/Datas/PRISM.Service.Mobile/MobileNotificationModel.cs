using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  000186635D00 ModelClassType MobileService MobileService MobileService Pointer
    // 018 newestTwestaArticles                     IEnumerable`1<ITwestaArticleStatus> IL2CPP_TYPE_GENERICINST
    public partial class MobileNotificationModel
    {
        public MobileService?                           Service                                 { get; set; }

        public static MobileNotificationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationModel();

            value.Service                                   = GetObject<MobileService>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileService.FromPointer); // 027003669C78 0x10 Service                     ( 000186635D00 ModelClassType MobileService MobileService MobileService Pointer )

            return value;
        }
    }
}
