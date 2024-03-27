using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Name                                     string IL2CPP_TYPE_STRING
    // 060 M_Biller                                 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 068 M_PurchasedProducts                      000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 070 PurchaseCalled                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 071 RestoreCalled                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 078 UnavailableProductId                     000186671910 ModelPrimitiveType string string string String
    // 080 UIMode                                   000186552330 ModelEnumType FakeStoreUIMode FakeStoreUIMode FakeStoreUIMode Int32
    public partial class FakeStore
    {
        public IStoreCallback?                          M_Biller                                { get; set; }
        public List<string>?                            M_PurchasedProducts                     { get; set; }
        public bool                                     PurchaseCalled                          { get; set; }
        public bool                                     RestoreCalled                           { get; set; }
        public string                                   UnavailableProductId                    { get; set; }
        public FakeStoreUIMode                          UIMode                                  { get; set; }

        public static FakeStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FakeStore();

            value.M_Biller                                  = GetObject<IStoreCallback>(new IntPtr(p + 0x060), ReversePrism.DataModels.IStoreCallback.FromPointer); // 027006918968 0x60 M_Biller                    ( 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_PurchasedProducts                       = GetStringList(new IntPtr(p + 0x068)); // 027006918988 0x68 M_PurchasedProducts         ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.PurchaseCalled                            = GetBool(new IntPtr(p + 0x070)); // 0270069189A8 0x70 PurchaseCalled              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RestoreCalled                             = GetBool(new IntPtr(p + 0x071)); // 0270069189C8 0x71 RestoreCalled               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UnavailableProductId                      = GetString(new IntPtr(p + 0x078)); // 0270069189E8 0x78 UnavailableProductId        ( 000186671910 ModelPrimitiveType string string string String )
            value.UIMode                                    = (FakeStoreUIMode)GetInt32(new IntPtr(p + 0x080)); // 027006918A08 0x80 UIMode                      ( 000186552330 ModelEnumType FakeStoreUIMode FakeStoreUIMode FakeStoreUIMode Int32 )

            return value;
        }
    }
}
