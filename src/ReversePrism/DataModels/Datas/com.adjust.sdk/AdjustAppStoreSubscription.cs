using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Price                                    000186671BA0 ModelPrimitiveType string string string String
    // 018 Currency                                 000186671BA0 ModelPrimitiveType string string string String
    // 020 TransactionId                            000186671BA0 ModelPrimitiveType string string string String
    // 028 Receipt                                  000186671BA0 ModelPrimitiveType string string string String
    // 030 BillingStore                             000186671BA0 ModelPrimitiveType string string string String
    // 038 TransactionDate                          000186671BA0 ModelPrimitiveType string string string String
    // 040 SalesRegion                              000186671BA0 ModelPrimitiveType string string string String
    // 048 PartnerList                              000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 050 CallbackList                             000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AdjustAppStoreSubscription
    {
        public string                                   Price                                   { get; set; }
        public string                                   Currency                                { get; set; }
        public string                                   TransactionId                           { get; set; }
        public string                                   Receipt                                 { get; set; }
        public string                                   BillingStore                            { get; set; }
        public string                                   TransactionDate                         { get; set; }
        public string                                   SalesRegion                             { get; set; }
        public List<string>?                            PartnerList                             { get; set; }
        public List<string>?                            CallbackList                            { get; set; }

        public static AdjustAppStoreSubscription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustAppStoreSubscription();

            value.Price                                     = GetString(new IntPtr(p + 0x010)); // 0270DBB0DC18 0x10 Price                       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Currency                                  = GetString(new IntPtr(p + 0x018)); // 0270DBB0DC38 0x18 Currency                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x020)); // 0270DBB0DC58 0x20 TransactionId               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Receipt                                   = GetString(new IntPtr(p + 0x028)); // 0270DBB0DC78 0x28 Receipt                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.BillingStore                              = GetString(new IntPtr(p + 0x030)); // 0270DBB0DC98 0x30 BillingStore                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TransactionDate                           = GetString(new IntPtr(p + 0x038)); // 0270DBB0DCB8 0x38 TransactionDate             ( 000186671BA0 ModelPrimitiveType string string string String )
            value.SalesRegion                               = GetString(new IntPtr(p + 0x040)); // 0270DBB0DCD8 0x40 SalesRegion                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x048)); // 0270DBB0DCF8 0x48 PartnerList                 ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x050)); // 0270DBB0DD18 0x50 CallbackList                ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
