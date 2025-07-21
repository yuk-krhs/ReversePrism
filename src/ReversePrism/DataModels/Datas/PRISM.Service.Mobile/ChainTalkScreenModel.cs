using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType MobileService MobileService MobileService Pointer
    public partial class ChainTalkScreenModel : DataModel
    {
        public MobileService?                           Service                                 { get; set; }

        public static ChainTalkScreenModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkScreenModel() { Pointer= p0 };

            value.Service                                   = GetObject<MobileService>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileService.FromPointer); // 0x10 Service                     ( ModelClassType MobileService MobileService MobileService Pointer )

            return value;
        }
    }
}
