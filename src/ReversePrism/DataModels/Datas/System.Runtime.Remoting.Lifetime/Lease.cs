using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 LeaseExpireTime                          ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 CurrentState                             ModelEnumType LeaseState LeaseState LeaseState Int32
    // 028 InitialLeaseTime                         ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 030 RenewOnCallTime                          ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 038 SponsorshipTimeout                       ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 040 Sponsors                                 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 RenewingSponsors                         ModelClassType Queue Queue Queue Pointer
    // 050 RenewalDelegate                          ModelClassType RenewalDelegate RenewalDelegate RenewalDelegate Pointer
    public partial class Lease : DataModel
    {
        public DateTime                                 LeaseExpireTime                         { get; set; }
        public LeaseState                               CurrentState                            { get; set; }
        public TimeSpan                                 InitialLeaseTime                        { get; set; }
        public TimeSpan                                 RenewOnCallTime                         { get; set; }
        public TimeSpan                                 SponsorshipTimeout                      { get; set; }
        public ArrayList?                               Sponsors                                { get; set; }
        public Queue?                                   RenewingSponsors                        { get; set; }
        public RenewalDelegate?                         RenewalDelegate                         { get; set; }

        public static Lease? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Lease() { Pointer= p0 };

            value.LeaseExpireTime                           = GetDateTime(new IntPtr(p + 0x018)); // 0x18 LeaseExpireTime             ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CurrentState                              = (LeaseState)GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentState                ( ModelEnumType LeaseState LeaseState LeaseState Int32 )
            value.InitialLeaseTime                          = (TimeSpan)GetInt32(new IntPtr(p + 0x028)); // 0x28 InitialLeaseTime            ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.RenewOnCallTime                           = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0x30 RenewOnCallTime             ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SponsorshipTimeout                        = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 0x38 SponsorshipTimeout          ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Sponsors                                  = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0x40 Sponsors                    ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.RenewingSponsors                          = GetObject<Queue>(new IntPtr(p + 0x048), ReversePrism.DataModels.Queue.FromPointer); // 0x48 RenewingSponsors            ( ModelClassType Queue Queue Queue Pointer )
            value.RenewalDelegate                           = GetObject<RenewalDelegate>(new IntPtr(p + 0x050), ReversePrism.DataModels.RenewalDelegate.FromPointer); // 0x50 RenewalDelegate             ( ModelClassType RenewalDelegate RenewalDelegate RenewalDelegate Pointer )

            return value;
        }
    }
}
