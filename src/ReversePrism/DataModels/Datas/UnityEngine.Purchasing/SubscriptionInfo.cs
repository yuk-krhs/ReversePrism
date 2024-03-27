using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Is_subscribed                            0001866753D0 ModelEnumType Result Result Result Int32
    // 014 Is_expired                               0001866753D0 ModelEnumType Result Result Result Int32
    // 018 Is_cancelled                             0001866753D0 ModelEnumType Result Result Result Int32
    // 01C Is_free_trial                            0001866753D0 ModelEnumType Result Result Result Int32
    // 020 Is_auto_renewing                         0001866753D0 ModelEnumType Result Result Result Int32
    // 024 Is_introductory_price_period             0001866753D0 ModelEnumType Result Result Result Int32
    // 028 ProductId                                000186672F10 ModelPrimitiveType string string string String
    // 030 PurchaseDate                             0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 SubscriptionExpireDate                   0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 SubscriptionCancelDate                   0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 RemainedTime                             00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 050 Introductory_price                       000186672F10 ModelPrimitiveType string string string String
    // 058 Introductory_price_period                00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 060 Introductory_price_cycles                0001865F8300 ModelPrimitiveType long long long Int64
    // 068 FreeTrialPeriod                          00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 070 SubscriptionPeriod                       00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 078 Free_trial_period_string                 000186672F10 ModelPrimitiveType string string string String
    // 080 Sku_details                              000186672F10 ModelPrimitiveType string string string String
    public partial class SubscriptionInfo
    {
        public Result                                   Is_subscribed                           { get; set; }
        public Result                                   Is_expired                              { get; set; }
        public Result                                   Is_cancelled                            { get; set; }
        public Result                                   Is_free_trial                           { get; set; }
        public Result                                   Is_auto_renewing                        { get; set; }
        public Result                                   Is_introductory_price_period            { get; set; }
        public string                                   ProductId                               { get; set; }
        public DateTime                                 PurchaseDate                            { get; set; }
        public DateTime                                 SubscriptionExpireDate                  { get; set; }
        public DateTime                                 SubscriptionCancelDate                  { get; set; }
        public TimeSpan                                 RemainedTime                            { get; set; }
        public string                                   Introductory_price                      { get; set; }
        public TimeSpan                                 Introductory_price_period               { get; set; }
        public long                                     Introductory_price_cycles               { get; set; }
        public TimeSpan                                 FreeTrialPeriod                         { get; set; }
        public TimeSpan                                 SubscriptionPeriod                      { get; set; }
        public string                                   Free_trial_period_string                { get; set; }
        public string                                   Sku_details                             { get; set; }

        public static SubscriptionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubscriptionInfo();

            value.Is_subscribed                             = (Result)GetInt32(new IntPtr(p + 0x010)); // 02700691DD28 0x10 Is_subscribed               ( 0001866753D0 ModelEnumType Result Result Result Int32 )
            value.Is_expired                                = (Result)GetInt32(new IntPtr(p + 0x014)); // 02700691DD48 0x14 Is_expired                  ( 0001866753D0 ModelEnumType Result Result Result Int32 )
            value.Is_cancelled                              = (Result)GetInt32(new IntPtr(p + 0x018)); // 02700691DD68 0x18 Is_cancelled                ( 0001866753D0 ModelEnumType Result Result Result Int32 )
            value.Is_free_trial                             = (Result)GetInt32(new IntPtr(p + 0x01C)); // 02700691DD88 0x1C Is_free_trial               ( 0001866753D0 ModelEnumType Result Result Result Int32 )
            value.Is_auto_renewing                          = (Result)GetInt32(new IntPtr(p + 0x020)); // 02700691DDA8 0x20 Is_auto_renewing            ( 0001866753D0 ModelEnumType Result Result Result Int32 )
            value.Is_introductory_price_period              = (Result)GetInt32(new IntPtr(p + 0x024)); // 02700691DDC8 0x24 Is_introductory_price_period ( 0001866753D0 ModelEnumType Result Result Result Int32 )
            value.ProductId                                 = GetString(new IntPtr(p + 0x028)); // 02700691DDE8 0x28 ProductId                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 02700691DE08 0x30 PurchaseDate                ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionExpireDate                    = GetDateTime(new IntPtr(p + 0x038)); // 02700691DE28 0x38 SubscriptionExpireDate      ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionCancelDate                    = GetDateTime(new IntPtr(p + 0x040)); // 02700691DE48 0x40 SubscriptionCancelDate      ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.RemainedTime                              = (TimeSpan)GetInt32(new IntPtr(p + 0x048)); // 02700691DE68 0x48 RemainedTime                ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Introductory_price                        = GetString(new IntPtr(p + 0x050)); // 02700691DE88 0x50 Introductory_price          ( 000186672F10 ModelPrimitiveType string string string String )
            value.Introductory_price_period                 = (TimeSpan)GetInt32(new IntPtr(p + 0x058)); // 02700691DEA8 0x58 Introductory_price_period   ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Introductory_price_cycles                 = GetInt64(new IntPtr(p + 0x060)); // 02700691DEC8 0x60 Introductory_price_cycles   ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.FreeTrialPeriod                           = (TimeSpan)GetInt32(new IntPtr(p + 0x068)); // 02700691DEE8 0x68 FreeTrialPeriod             ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SubscriptionPeriod                        = (TimeSpan)GetInt32(new IntPtr(p + 0x070)); // 02700691DF08 0x70 SubscriptionPeriod          ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Free_trial_period_string                  = GetString(new IntPtr(p + 0x078)); // 02700691DF28 0x78 Free_trial_period_string    ( 000186672F10 ModelPrimitiveType string string string String )
            value.Sku_details                               = GetString(new IntPtr(p + 0x080)); // 02700691DF48 0x80 Sku_details                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
