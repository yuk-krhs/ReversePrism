using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 028 ScrollerView                             ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer
    // 030 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 038 onClickFavoriteButtonSubject             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class TwestaTopScreenView : DataModel
    {
        public UIButton?                                FavoriteButton                          { get; set; }
        public TwestaScrollerView?                      ScrollerView                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }

        public static TwestaTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaTopScreenView() { Pointer= p0 };

            value.FavoriteButton                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 FavoriteButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ScrollerView                              = GetObject<TwestaScrollerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaScrollerView.FromPointer); // 0x28 ScrollerView                ( ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x30 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )

            return value;
        }
    }
}
