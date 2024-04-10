using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 LeaseExpireTime                          0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 CurrentState                             0001865131F0 ModelEnumType LeaseState LeaseState LeaseState Int32
    // 028 InitialLeaseTime                         00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 030 RenewOnCallTime                          00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 038 SponsorshipTimeout                       00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 040 Sponsors                                 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 RenewingSponsors                         0001865FFF70 ModelClassType Queue Queue Queue Pointer
    // 050 RenewalDelegate                          00018667E610 ModelClassType RenewalDelegate RenewalDelegate RenewalDelegate Pointer
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

            value.LeaseExpireTime                           = GetDateTime(new IntPtr(p + 0x018)); // 024666C30CA8 0x18 LeaseExpireTime             ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CurrentState                              = (LeaseState)GetInt32(new IntPtr(p + 0x020)); // 024666C30CC8 0x20 CurrentState                ( 0001865131F0 ModelEnumType LeaseState LeaseState LeaseState Int32 )
            value.InitialLeaseTime                          = (TimeSpan)GetInt32(new IntPtr(p + 0x028)); // 024666C30CE8 0x28 InitialLeaseTime            ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.RenewOnCallTime                           = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 024666C30D08 0x30 RenewOnCallTime             ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SponsorshipTimeout                        = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 024666C30D28 0x38 SponsorshipTimeout          ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Sponsors                                  = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 024666C30D48 0x40 Sponsors                    ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.RenewingSponsors                          = GetObject<Queue>(new IntPtr(p + 0x048), ReversePrism.DataModels.Queue.FromPointer); // 024666C30D68 0x48 RenewingSponsors            ( 0001865FFF70 ModelClassType Queue Queue Queue Pointer )
            value.RenewalDelegate                           = GetObject<RenewalDelegate>(new IntPtr(p + 0x050), ReversePrism.DataModels.RenewalDelegate.FromPointer); // 024666C30D88 0x50 RenewalDelegate             ( 00018667E610 ModelClassType RenewalDelegate RenewalDelegate RenewalDelegate Pointer )

            return value;
        }
    }
}
