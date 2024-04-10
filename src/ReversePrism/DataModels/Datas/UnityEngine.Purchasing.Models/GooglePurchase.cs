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

            value.JavaPurchase                              = GetObject<IAndroidJavaObjectWrapper>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAndroidJavaObjectWrapper.FromPointer); // 0245A68E8198 0x10 JavaPurchase                ( 0001866F4580 ModelClassType IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper IAndroidJavaObjectWrapper Pointer )
            value.PurchaseState                             = GetInt32(new IntPtr(p + 0x018)); // 0245A68E81B8 0x18 PurchaseState               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Skus                                      = GetStringList(new IntPtr(p + 0x020)); // 0245A68E81D8 0x20 Skus                        ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.OrderId                                   = GetString(new IntPtr(p + 0x028)); // 0245A68E81F8 0x28 OrderId                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Receipt                                   = GetString(new IntPtr(p + 0x030)); // 0245A68E8218 0x30 Receipt                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x038)); // 0245A68E8238 0x38 Signature                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.OriginalJson                              = GetString(new IntPtr(p + 0x040)); // 0245A68E8258 0x40 OriginalJson                ( 000186672F10 ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x048)); // 0245A68E8278 0x48 PurchaseToken               ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
