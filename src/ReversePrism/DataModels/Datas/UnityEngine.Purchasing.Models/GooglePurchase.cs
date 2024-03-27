using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JavaPurchase                             0001866F4580 ModelClassType IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper Pointer
    // 018 PurchaseState                            0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Skus                                     000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 028 OrderId                                  000186672F10 ModelPrimitiveType string string string String
    // 030 Receipt                                  000186672F10 ModelPrimitiveType string string string String
    // 038 Signature                                000186672F10 ModelPrimitiveType string string string String
    // 040 OriginalJson                             000186672F10 ModelPrimitiveType string string string String
    // 048 PurchaseToken                            000186672F10 ModelPrimitiveType string string string String
    public partial class GooglePurchase
    {
        public IAndroidJavaObjectWrapper?               JavaPurchase                            { get; set; }
        public int                                      PurchaseState                           { get; set; }
        public List<string>?                            Skus                                    { get; set; }
        public string                                   OrderId                                 { get; set; }
        public string                                   Receipt                                 { get; set; }
        public string                                   Signature                               { get; set; }
        public string                                   OriginalJson                            { get; set; }
        public string                                   PurchaseToken                           { get; set; }

        public static GooglePurchase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePurchase();

            value.JavaPurchase                              = GetObject<IAndroidJavaObjectWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAndroidJavaObjectWrapper.FromPointer); // 0270069252C0 0x10 JavaPurchase                ( 0001866F4580 ModelClassType IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper Pointer )
            value.PurchaseState                             = GetInt32(new IntPtr(p + 0x018)); // 0270069252E0 0x18 PurchaseState               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Skus                                      = GetStringList(new IntPtr(p + 0x020)); // 027006925300 0x20 Skus                        ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.OrderId                                   = GetString(new IntPtr(p + 0x028)); // 027006925320 0x28 OrderId                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Receipt                                   = GetString(new IntPtr(p + 0x030)); // 027006925340 0x30 Receipt                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x038)); // 027006925360 0x38 Signature                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.OriginalJson                              = GetString(new IntPtr(p + 0x040)); // 027006925380 0x40 OriginalJson                ( 000186672F10 ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x048)); // 0270069253A0 0x48 PurchaseToken               ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
