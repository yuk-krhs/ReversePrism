using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentPos                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 TwestaButton                             ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 030 ChainButton                              ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 038 PhoneButton                              ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 040 StreamingButton                          ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 048 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    public partial class MobileTopScreenView : DataModel
    {
        public GameObject?                              ContentPos                              { get; set; }
        public MobileCategoryButton?                    TwestaButton                            { get; set; }
        public MobileCategoryButton?                    ChainButton                             { get; set; }
        public MobileCategoryButton?                    PhoneButton                             { get; set; }
        public MobileCategoryButton?                    StreamingButton                         { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }

        public static MobileTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTopScreenView() { Pointer= p0 };

            value.ContentPos                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ContentPos                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TwestaButton                              = GetObject<MobileCategoryButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 0x28 TwestaButton                ( ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.ChainButton                               = GetObject<MobileCategoryButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 0x30 ChainButton                 ( ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.PhoneButton                               = GetObject<MobileCategoryButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 0x38 PhoneButton                 ( ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.StreamingButton                           = GetObject<MobileCategoryButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 0x40 StreamingButton             ( ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x48 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )

            return value;
        }
    }
}
