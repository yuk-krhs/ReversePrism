using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentPos                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 TwestaButton                             00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 030 ChainButton                              00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 038 PhoneButton                              00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 040 StreamingButton                          00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer
    // 048 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 050 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 058 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class MobileTopScreenView : DataModel
    {
        public GameObject?                              ContentPos                              { get; set; }
        public MobileCategoryButton?                    TwestaButton                            { get; set; }
        public MobileCategoryButton?                    ChainButton                             { get; set; }
        public MobileCategoryButton?                    PhoneButton                             { get; set; }
        public MobileCategoryButton?                    StreamingButton                         { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static MobileTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTopScreenView() { Pointer= p0 };

            value.ContentPos                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B195830 0x20 ContentPos                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TwestaButton                              = GetObject<MobileCategoryButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B195850 0x28 TwestaButton                ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.ChainButton                               = GetObject<MobileCategoryButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B195870 0x30 ChainButton                 ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.PhoneButton                               = GetObject<MobileCategoryButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B195890 0x38 PhoneButton                 ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.StreamingButton                           = GetObject<MobileCategoryButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileCategoryButton.FromPointer); // 02466B1958B0 0x40 StreamingButton             ( 00018662D090 ModelClassType MobileCategoryButton MobileCategoryButton MobileCategoryButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 02466B1958D0 0x48 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ResourceLoader.FromPointer); // 02466B1958F0 0x50 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B195910 0x58 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
