using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ScrollerView                             0001866CD110 ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer
    // 030 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 038 onClickFavoriteButtonSubject             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class TwestaTopScreenView
    {
        public UIButton?                                FavoriteButton                          { get; set; }
        public TwestaScrollerView?                      ScrollerView                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static TwestaTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaTopScreenView();

            value.FavoriteButton                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB1854D0 0x20 FavoriteButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ScrollerView                              = GetObject<TwestaScrollerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaScrollerView.FromPointer); // 0270DB1854F0 0x28 ScrollerView                ( 0001866CD110 ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB185510 0x30 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB185550 0x40 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
