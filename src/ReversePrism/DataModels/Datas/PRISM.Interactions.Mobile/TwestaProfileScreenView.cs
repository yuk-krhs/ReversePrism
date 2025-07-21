using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 ScrollerView                             ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer
    // 030 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    public partial class TwestaProfileScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public TwestaScrollerView?                      ScrollerView                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }

        public static TwestaProfileScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaProfileScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0x20 Header                      ( ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.ScrollerView                              = GetObject<TwestaScrollerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaScrollerView.FromPointer); // 0x28 ScrollerView                ( ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x30 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )

            return value;
        }
    }
}
