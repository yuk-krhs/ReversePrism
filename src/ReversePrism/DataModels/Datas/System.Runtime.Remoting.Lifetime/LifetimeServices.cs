using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _leaseManagerPollTime                    TimeSpan IL2CPP_TYPE_VALUETYPE
    // 008 _leaseTime                               TimeSpan IL2CPP_TYPE_VALUETYPE
    // 010 RenewOnCallTime                          00018668B250 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 018 SponsorshipTimeout                       00018668B250 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 020 LeaseManager                             000186512AC0 ModelClassType LeaseManager LeaseManager LeaseManager Pointer
    public partial class LifetimeServices
    {
        public TimeSpan                                 RenewOnCallTime                         { get; set; }
        public TimeSpan                                 SponsorshipTimeout                      { get; set; }
        public LeaseManager?                            LeaseManager                            { get; set; }

        public static LifetimeServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LifetimeServices();

            value.RenewOnCallTime                           = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0270D6BBE438 0x10 RenewOnCallTime             ( 00018668B250 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SponsorshipTimeout                        = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0270D6BBE458 0x18 SponsorshipTimeout          ( 00018668B250 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.LeaseManager                              = GetObject<LeaseManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.LeaseManager.FromPointer); // 0270D6BBE478 0x20 LeaseManager                ( 000186512AC0 ModelClassType LeaseManager LeaseManager LeaseManager Pointer )

            return value;
        }
    }
}
