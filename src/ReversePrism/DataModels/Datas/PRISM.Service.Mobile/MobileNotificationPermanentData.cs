using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NotifiedTwestaIdList                     ModelClassType NotifiedMobileIdList NotifiedMobileIdList NotifiedMobileIdList Pointer
    // 018 NotifiedChainIdList                      ModelClassType NotifiedMobileIdList NotifiedMobileIdList NotifiedMobileIdList Pointer
    // 020 NotifiedPhoneIdList                      ModelClassType NotifiedMobileIdList NotifiedMobileIdList NotifiedMobileIdList Pointer
    public partial class MobileNotificationPermanentData : DataModel
    {
        public NotifiedMobileIdList?                    NotifiedTwestaIdList                    { get; set; }
        public NotifiedMobileIdList?                    NotifiedChainIdList                     { get; set; }
        public NotifiedMobileIdList?                    NotifiedPhoneIdList                     { get; set; }

        public static MobileNotificationPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationPermanentData() { Pointer= p0 };

            value.NotifiedTwestaIdList                      = GetObject<NotifiedMobileIdList>(new IntPtr(p + 0x010), ReversePrism.DataModels.NotifiedMobileIdList.FromPointer); // 0x10 NotifiedTwestaIdList        ( ModelClassType NotifiedMobileIdList NotifiedMobileIdList NotifiedMobileIdList Pointer )
            value.NotifiedChainIdList                       = GetObject<NotifiedMobileIdList>(new IntPtr(p + 0x018), ReversePrism.DataModels.NotifiedMobileIdList.FromPointer); // 0x18 NotifiedChainIdList         ( ModelClassType NotifiedMobileIdList NotifiedMobileIdList NotifiedMobileIdList Pointer )
            value.NotifiedPhoneIdList                       = GetObject<NotifiedMobileIdList>(new IntPtr(p + 0x020), ReversePrism.DataModels.NotifiedMobileIdList.FromPointer); // 0x20 NotifiedPhoneIdList         ( ModelClassType NotifiedMobileIdList NotifiedMobileIdList NotifiedMobileIdList Pointer )

            return value;
        }
    }
}
