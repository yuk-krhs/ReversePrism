using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PaymentId                                0001866722E0 ModelPrimitiveType string string string String
    // 018 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 020 UserId                                   0001866722E0 ModelPrimitiveType string string string String
    // 028 Status                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 TransactionUrl                           0001866722E0 ModelPrimitiveType string string string String
    // 038 Message                                  0001866722E0 ModelPrimitiveType string string string String
    // 040 PaymentItems                             000185CF8738 ModelClassListType List`1<PaymentItem> List`1<PaymentItem> List<PaymentItem> Pointer
    // 048 OrderedTime                              0001866722E0 ModelPrimitiveType string string string String
    // 050 ExecutedTime                             0001866722E0 ModelPrimitiveType string string string String
    public partial class PaymentResult
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
            var value   = new PaymentResult();

            value.PaymentId                                 = GetString(new IntPtr(p + 0x010)); // 0270DB4C1828 0x10 PaymentId                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x018)); // 0270DB4C1848 0x18 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0270DB4C1868 0x20 UserId                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Status                                    = GetInt32(new IntPtr(p + 0x028)); // 0270DB4C1888 0x28 Status                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TransactionUrl                            = GetString(new IntPtr(p + 0x030)); // 0270DB4C18A8 0x30 TransactionUrl              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x038)); // 0270DB4C18C8 0x38 Message                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PaymentItems                              = GetObjectList<PaymentItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.PaymentItem.FromPointer); // 0270DB4C18E8 0x40 PaymentItems                ( 000185CF8738 ModelClassListType List`1<PaymentItem> List`1<PaymentItem> List<PaymentItem> Pointer )
            value.OrderedTime                               = GetString(new IntPtr(p + 0x048)); // 0270DB4C1908 0x48 OrderedTime                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ExecutedTime                              = GetString(new IntPtr(p + 0x050)); // 0270DB4C1928 0x50 ExecutedTime                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
