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
    // 020 Sku                                      000186671BA0 ModelPrimitiveType string string string String
    // 028 OrderId                                  000186671BA0 ModelPrimitiveType string string string String
    // 030 Signature                                000186671BA0 ModelPrimitiveType string string string String
    // 038 PurchaseToken                            000186671BA0 ModelPrimitiveType string string string String
    // 040 BillingStore                             000186671BA0 ModelPrimitiveType string string string String
    // 048 PurchaseTime                             000186671BA0 ModelPrimitiveType string string string String
    // 050 PartnerList                              000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 058 CallbackList                             000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AdjustPlayStoreSubscription
    {
        public string                                   Price                                   { get; set; }
        public string                                   Currency                                { get; set; }
        public string                                   Sku                                     { get; set; }
        public string                                   OrderId                                 { get; set; }
        public string                                   Signature                               { get; set; }
        public string                                   PurchaseToken                           { get; set; }
        public string                                   BillingStore                            { get; set; }
        public string                                   PurchaseTime                            { get; set; }
        public List<string>?                            PartnerList                             { get; set; }
        public List<string>?                            CallbackList                            { get; set; }

        public static AdjustPlayStoreSubscription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustPlayStoreSubscription();

            value.Price                                     = GetString(new IntPtr(p + 0x010)); // 0270DBB0DF10 0x10 Price                       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Currency                                  = GetString(new IntPtr(p + 0x018)); // 0270DBB0DF30 0x18 Currency                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Sku                                       = GetString(new IntPtr(p + 0x020)); // 0270DBB0DF50 0x20 Sku                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.OrderId                                   = GetString(new IntPtr(p + 0x028)); // 0270DBB0DF70 0x28 OrderId                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x030)); // 0270DBB0DF90 0x30 Signature                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x038)); // 0270DBB0DFB0 0x38 PurchaseToken               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.BillingStore                              = GetString(new IntPtr(p + 0x040)); // 0270DBB0DFD0 0x40 BillingStore                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PurchaseTime                              = GetString(new IntPtr(p + 0x048)); // 0270DBB0DFF0 0x48 PurchaseTime                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x050)); // 0270DBB0E010 0x50 PartnerList                 ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x058)); // 0270DBB0E030 0x58 CallbackList                ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
