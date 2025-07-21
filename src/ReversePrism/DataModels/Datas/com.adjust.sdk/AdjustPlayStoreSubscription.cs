using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Price                                    ModelPrimitiveType string string string String
    // 018 Currency                                 ModelPrimitiveType string string string String
    // 020 Sku                                      ModelPrimitiveType string string string String
    // 028 OrderId                                  ModelPrimitiveType string string string String
    // 030 Signature                                ModelPrimitiveType string string string String
    // 038 PurchaseToken                            ModelPrimitiveType string string string String
    // 040 BillingStore                             ModelPrimitiveType string string string String
    // 048 PurchaseTime                             ModelPrimitiveType string string string String
    // 050 PartnerList                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 058 CallbackList                             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AdjustPlayStoreSubscription : DataModel
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
            var value   = new AdjustPlayStoreSubscription() { Pointer= p0 };

            value.Price                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Price                       ( ModelPrimitiveType string string string String )
            value.Currency                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Currency                    ( ModelPrimitiveType string string string String )
            value.Sku                                       = GetString(new IntPtr(p + 0x020)); // 0x20 Sku                         ( ModelPrimitiveType string string string String )
            value.OrderId                                   = GetString(new IntPtr(p + 0x028)); // 0x28 OrderId                     ( ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x030)); // 0x30 Signature                   ( ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x038)); // 0x38 PurchaseToken               ( ModelPrimitiveType string string string String )
            value.BillingStore                              = GetString(new IntPtr(p + 0x040)); // 0x40 BillingStore                ( ModelPrimitiveType string string string String )
            value.PurchaseTime                              = GetString(new IntPtr(p + 0x048)); // 0x48 PurchaseTime                ( ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x050)); // 0x50 PartnerList                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x058)); // 0x58 CallbackList                ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
