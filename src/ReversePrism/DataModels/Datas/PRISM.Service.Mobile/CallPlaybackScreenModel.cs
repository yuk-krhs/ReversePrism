using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  000186635D00 ModelClassType MobileService MobileService MobileService Pointer
    public partial class CallPlaybackScreenModel : DataModel
    {
        public MobileService?                           Service                                 { get; set; }

        public static CallPlaybackScreenModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallPlaybackScreenModel() { Pointer= p0 };

            value.Service                                   = GetObject<MobileService>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileService.FromPointer); // 0246668C1908 0x10 Service                     ( 000186635D00 ModelClassType MobileService MobileService MobileService Pointer )

            return value;
        }
    }
}
