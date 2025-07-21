using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PaymentId                                ModelPrimitiveType string string string String
    // 018 AppId                                    ModelPrimitiveType string string string String
    // 020 UserId                                   ModelPrimitiveType string string string String
    // 028 Status                                   ModelPrimitiveType int int int Int32
    // 030 TransactionUrl                           ModelPrimitiveType string string string String
    // 038 Message                                  ModelPrimitiveType string string string String
    // 040 PaymentItems                             ModelClassListType List`1<PaymentItem> List`1<PaymentItem> List<PaymentItem> Pointer
    // 048 OrderedTime                              ModelPrimitiveType string string string String
    // 050 ExecutedTime                             ModelPrimitiveType string string string String
    public partial class PaymentResult : DataModel
    {
        public string                                   PaymentId                               { get; set; }
        public string                                   AppId                                   { get; set; }
        public string                                   UserId                                  { get; set; }
        public int                                      Status                                  { get; set; }
        public string                                   TransactionUrl                          { get; set; }
        public string                                   Message                                 { get; set; }
        public List<PaymentItem>?                       PaymentItems                            { get; set; }
        public string                                   OrderedTime                             { get; set; }
        public string                                   ExecutedTime                            { get; set; }

        public static PaymentResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PaymentResult() { Pointer= p0 };

            value.PaymentId                                 = GetString(new IntPtr(p + 0x010)); // 0x10 PaymentId                   ( ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 0x18 AppId                       ( ModelPrimitiveType string string string String )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0x20 UserId                      ( ModelPrimitiveType string string string String )
            value.Status                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Status                      ( ModelPrimitiveType int int int Int32 )
            value.TransactionUrl                            = GetString(new IntPtr(p + 0x030)); // 0x30 TransactionUrl              ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x038)); // 0x38 Message                     ( ModelPrimitiveType string string string String )
            value.PaymentItems                              = GetObjectList<PaymentItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.PaymentItem.FromPointer); // 0x40 PaymentItems                ( ModelClassListType List`1<PaymentItem> List`1<PaymentItem> List<PaymentItem> Pointer )
            value.OrderedTime                               = GetString(new IntPtr(p + 0x048)); // 0x48 OrderedTime                 ( ModelPrimitiveType string string string String )
            value.ExecutedTime                              = GetString(new IntPtr(p + 0x050)); // 0x50 ExecutedTime                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
