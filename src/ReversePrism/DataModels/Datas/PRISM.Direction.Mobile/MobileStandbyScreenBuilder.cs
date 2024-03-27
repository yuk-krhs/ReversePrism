using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186636E50 ModelClassType MobileStandbyScreenView MobileStandbyScreenView MobileStandbyScreenView Pointer
    public partial class MobileStandbyScreenBuilder
    {
        public MobileStandbyScreenView?                 View                                    { get; set; }

        public static MobileStandbyScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileStandbyScreenBuilder();

            value.View                                      = GetObject<MobileStandbyScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileStandbyScreenView.FromPointer); // 0270DB647768 0x20 View                        ( 000186636E50 ModelClassType MobileStandbyScreenView MobileStandbyScreenView MobileStandbyScreenView Pointer )

            return value;
        }
    }
}
