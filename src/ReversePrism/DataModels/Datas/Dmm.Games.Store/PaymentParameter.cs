using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Method                                   0001866722E0 ModelPrimitiveType string string string String
    // 030 Guid                                     0001866722E0 ModelPrimitiveType string string string String
    // 038 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 040 PaymentId                                0001866722E0 ModelPrimitiveType string string string String
    // 048 Selector                                 0001866722E0 ModelPrimitiveType string string string String
    // 050 Message                                  0001866722E0 ModelPrimitiveType string string string String
    // 058 CallbackUrl                              0001866722E0 ModelPrimitiveType string string string String
    // 060 Items                                    000185CF8738 ModelClassListType List`1<PaymentItem> List`1<PaymentItem> List<PaymentItem> Pointer
    public partial class PaymentParameter : DataModel
    {
        public string                                   Method                                  { get; set; }
        public string                                   Guid                                    { get; set; }
        public string                                   AppId                                   { get; set; }
        public string                                   PaymentId                               { get; set; }
        public string                                   Selector                                { get; set; }
        public string                                   Message                                 { get; set; }
        public string                                   CallbackUrl                             { get; set; }
        public List<PaymentItem>?                       Items                                   { get; set; }

        public static PaymentParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PaymentParameter() { Pointer= p0 };

            value.Method                                    = GetString(new IntPtr(p + 0x028)); // 02466B517630 0x28 Method                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Guid                                      = GetString(new IntPtr(p + 0x030)); // 02466B517650 0x30 Guid                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x038)); // 02466B517670 0x38 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PaymentId                                 = GetString(new IntPtr(p + 0x040)); // 02466B517690 0x40 PaymentId                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x048)); // 02466B5176B0 0x48 Selector                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x050)); // 02466B5176D0 0x50 Message                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CallbackUrl                               = GetString(new IntPtr(p + 0x058)); // 02466B5176F0 0x58 CallbackUrl                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Items                                     = GetObjectList<PaymentItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.PaymentItem.FromPointer); // 02466B517710 0x60 Items                       ( 000185CF8738 ModelClassListType List`1<PaymentItem> List`1<PaymentItem> List<PaymentItem> Pointer )

            return value;
        }
    }
}
