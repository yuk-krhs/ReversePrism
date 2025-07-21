using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JavaPurchase                             ModelClassType IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper Pointer
    // 018 PurchaseState                            ModelPrimitiveType int int int Int32
    // 020 Skus                                     ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 028 OrderId                                  ModelPrimitiveType string string string String
    // 030 Receipt                                  ModelPrimitiveType string string string String
    // 038 Signature                                ModelPrimitiveType string string string String
    // 040 OriginalJson                             ModelPrimitiveType string string string String
    // 048 PurchaseToken                            ModelPrimitiveType string string string String
    public partial class GooglePurchase : DataModel
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
            var value   = new GooglePurchase() { Pointer= p0 };

            value.JavaPurchase                              = GetObject<IAndroidJavaObjectWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAndroidJavaObjectWrapper.FromPointer); // 0x10 JavaPurchase                ( ModelClassType IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper Pointer )
            value.PurchaseState                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 PurchaseState               ( ModelPrimitiveType int int int Int32 )
            value.Skus                                      = GetStringList(new IntPtr(p + 0x020)); // 0x20 Skus                        ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.OrderId                                   = GetString(new IntPtr(p + 0x028)); // 0x28 OrderId                     ( ModelPrimitiveType string string string String )
            value.Receipt                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Receipt                     ( ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x038)); // 0x38 Signature                   ( ModelPrimitiveType string string string String )
            value.OriginalJson                              = GetString(new IntPtr(p + 0x040)); // 0x40 OriginalJson                ( ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x048)); // 0x48 PurchaseToken               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
