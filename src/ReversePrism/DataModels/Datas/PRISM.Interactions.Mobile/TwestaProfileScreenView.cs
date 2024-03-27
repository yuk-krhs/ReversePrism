using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 ScrollerView                             0001866CD110 ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer
    // 030 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 038 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class TwestaProfileScreenView
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public TwestaScrollerView?                      ScrollerView                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static TwestaProfileScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaProfileScreenView();

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0270DB17E470 0x20 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.ScrollerView                              = GetObject<TwestaScrollerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaScrollerView.FromPointer); // 0270DB17E490 0x28 ScrollerView                ( 0001866CD110 ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB17E4B0 0x30 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB17E4D0 0x38 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
