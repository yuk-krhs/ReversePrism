using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollerView                             0001866CD110 ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer
    // 028 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 030 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class TwestaDetailScreenView
    {
        public TwestaScrollerView?                      ScrollerView                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static TwestaDetailScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaDetailScreenView();

            value.ScrollerView                              = GetObject<TwestaScrollerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TwestaScrollerView.FromPointer); // 0270DB17E060 0x20 ScrollerView                ( 0001866CD110 ModelClassType TwestaScrollerView TwestaScrollerView TwestaScrollerView Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB17E080 0x28 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB17E0A0 0x30 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
