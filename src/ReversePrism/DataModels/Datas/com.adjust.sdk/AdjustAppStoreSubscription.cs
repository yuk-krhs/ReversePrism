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
    // 020 TransactionId                            ModelPrimitiveType string string string String
    // 028 Receipt                                  ModelPrimitiveType string string string String
    // 030 BillingStore                             ModelPrimitiveType string string string String
    // 038 TransactionDate                          ModelPrimitiveType string string string String
    // 040 SalesRegion                              ModelPrimitiveType string string string String
    // 048 PartnerList                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 050 CallbackList                             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AdjustAppStoreSubscription : DataModel
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
            var value   = new AdjustAppStoreSubscription() { Pointer= p0 };

            value.Price                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Price                       ( ModelPrimitiveType string string string String )
            value.Currency                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Currency                    ( ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x020)); // 0x20 TransactionId               ( ModelPrimitiveType string string string String )
            value.Receipt                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Receipt                     ( ModelPrimitiveType string string string String )
            value.BillingStore                              = GetString(new IntPtr(p + 0x030)); // 0x30 BillingStore                ( ModelPrimitiveType string string string String )
            value.TransactionDate                           = GetString(new IntPtr(p + 0x038)); // 0x38 TransactionDate             ( ModelPrimitiveType string string string String )
            value.SalesRegion                               = GetString(new IntPtr(p + 0x040)); // 0x40 SalesRegion                 ( ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x048)); // 0x48 PartnerList                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x050)); // 0x50 CallbackList                ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
