using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  000186635D00 ModelClassType MobileService MobileService MobileService Pointer
    // 018 unreadTwestaExistenceChecker             Func`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class MobileTopScreenModel
    {
        public MobileService?                           Service                                 { get; set; }

        public static MobileTopScreenModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTopScreenModel();

            value.Service                                   = GetObject<MobileService>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileService.FromPointer); // 0270D689EB58 0x10 Service                     ( 000186635D00 ModelClassType MobileService MobileService MobileService Pointer )

            return value;
        }
    }
}
