using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Body                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 TwestaButton                             00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 030 ChainButton                              00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 038 PhoneButton                              00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 040 OurStreamButton                          00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    public partial class MobileMenu : DataModel
    {
        public GameObject?                              Body                                    { get; set; }
        public MobileCategoryButton?                    TwestaButton                            { get; set; }
        public MobileCategoryButton?                    ChainButton                             { get; set; }
        public MobileCategoryButton?                    PhoneButton                             { get; set; }
        public MobileCategoryButton?                    OurStreamButton                         { get; set; }

        public static MobileMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileMenu() { Pointer= p0 };

            value.Body                                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B17CCF0 0x20 Body                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TwestaButton                              = GetObject<MobileCategoryButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B17CD10 0x28 TwestaButton                ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.ChainButton                               = GetObject<MobileCategoryButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B17CD30 0x30 ChainButton                 ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.PhoneButton                               = GetObject<MobileCategoryButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B17CD50 0x38 PhoneButton                 ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.OurStreamButton                           = GetObject<MobileCategoryButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B17CD70 0x40 OurStreamButton             ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )

            return value;
        }
    }
}
