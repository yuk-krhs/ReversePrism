using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollerView                             ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer
    // 028 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    public partial class TwestaDetailScreenView : DataModel
    {
        public TwestaScrollerView?                      ScrollerView                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }

        public static TwestaDetailScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaDetailScreenView() { Pointer= p0 };

            value.ScrollerView                              = GetObject<TwestaScrollerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaScrollerView.FromPointer); // 0x20 ScrollerView                ( ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x28 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )

            return value;
        }
    }
}
