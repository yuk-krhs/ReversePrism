using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186630D40 ModelClassType MobileNotificationView MobileNotificationView MobileNotificationView Pointer
    public partial class MobileNotificationBuilder
    {
        public MobileNotificationView?                  View                                    { get; set; }

        public static MobileNotificationBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationBuilder();

            value.View                                      = GetObject<MobileNotificationView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileNotificationView.FromPointer); // 027004F63288 0x20 View                        ( 000186630D40 ModelClassType MobileNotificationView MobileNotificationView MobileNotificationView Pointer )

            return value;
        }
    }
}
