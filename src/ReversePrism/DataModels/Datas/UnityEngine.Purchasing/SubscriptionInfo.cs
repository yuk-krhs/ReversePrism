using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Is_subscribed                            ModelEnumType Result Result Result Int32
    // 014 Is_expired                               ModelEnumType Result Result Result Int32
    // 018 Is_cancelled                             ModelEnumType Result Result Result Int32
    // 01C Is_free_trial                            ModelEnumType Result Result Result Int32
    // 020 Is_auto_renewing                         ModelEnumType Result Result Result Int32
    // 024 Is_introductory_price_period             ModelEnumType Result Result Result Int32
    // 028 ProductId                                ModelPrimitiveType string string string String
    // 030 PurchaseDate                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 SubscriptionExpireDate                   ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 SubscriptionCancelDate                   ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 RemainedTime                             ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 050 Introductory_price                       ModelPrimitiveType string string string String
    // 058 Introductory_price_period                ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 060 Introductory_price_cycles                ModelPrimitiveType long long long Int64
    // 068 FreeTrialPeriod                          ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 070 SubscriptionPeriod                       ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 078 Free_trial_period_string                 ModelPrimitiveType string string string String
    // 080 Sku_details                              ModelPrimitiveType string string string String
    public partial class SubscriptionInfo : DataModel
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
            var value   = new SubscriptionInfo() { Pointer= p0 };

            value.Is_subscribed                             = (Result)GetInt32(new IntPtr(p + 0x010)); // 0x10 Is_subscribed               ( ModelEnumType Result Result Result Int32 )
            value.Is_expired                                = (Result)GetInt32(new IntPtr(p + 0x014)); // 0x14 Is_expired                  ( ModelEnumType Result Result Result Int32 )
            value.Is_cancelled                              = (Result)GetInt32(new IntPtr(p + 0x018)); // 0x18 Is_cancelled                ( ModelEnumType Result Result Result Int32 )
            value.Is_free_trial                             = (Result)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Is_free_trial               ( ModelEnumType Result Result Result Int32 )
            value.Is_auto_renewing                          = (Result)GetInt32(new IntPtr(p + 0x020)); // 0x20 Is_auto_renewing            ( ModelEnumType Result Result Result Int32 )
            value.Is_introductory_price_period              = (Result)GetInt32(new IntPtr(p + 0x024)); // 0x24 Is_introductory_price_period ( ModelEnumType Result Result Result Int32 )
            value.ProductId                                 = GetString(new IntPtr(p + 0x028)); // 0x28 ProductId                   ( ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 0x30 PurchaseDate                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionExpireDate                    = GetDateTime(new IntPtr(p + 0x038)); // 0x38 SubscriptionExpireDate      ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionCancelDate                    = GetDateTime(new IntPtr(p + 0x040)); // 0x40 SubscriptionCancelDate      ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.RemainedTime                              = (TimeSpan)GetInt32(new IntPtr(p + 0x048)); // 0x48 RemainedTime                ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Introductory_price                        = GetString(new IntPtr(p + 0x050)); // 0x50 Introductory_price          ( ModelPrimitiveType string string string String )
            value.Introductory_price_period                 = (TimeSpan)GetInt32(new IntPtr(p + 0x058)); // 0x58 Introductory_price_period   ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Introductory_price_cycles                 = GetInt64(new IntPtr(p + 0x060)); // 0x60 Introductory_price_cycles   ( ModelPrimitiveType long long long Int64 )
            value.FreeTrialPeriod                           = (TimeSpan)GetInt32(new IntPtr(p + 0x068)); // 0x68 FreeTrialPeriod             ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SubscriptionPeriod                        = (TimeSpan)GetInt32(new IntPtr(p + 0x070)); // 0x70 SubscriptionPeriod          ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Free_trial_period_string                  = GetString(new IntPtr(p + 0x078)); // 0x78 Free_trial_period_string    ( ModelPrimitiveType string string string String )
            value.Sku_details                               = GetString(new IntPtr(p + 0x080)); // 0x80 Sku_details                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
