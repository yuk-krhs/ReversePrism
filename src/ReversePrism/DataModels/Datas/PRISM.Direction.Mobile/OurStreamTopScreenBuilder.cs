using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866FA0B0 ModelClassType OurStreamTopScreenView OurStreamTopScreenView OurStreamTopScreenView Pointer
    // 028 DetailPopupViewFactory                   0001866F42C0 ModelClassType OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory Pointer
    // 030 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class OurStreamTopScreenBuilder
    {
        public OurStreamTopScreenView?                  ViewPrefab                              { get; set; }
        public OurStreamLiveContentDetailPopupViewFactory? DetailPopupViewFactory                  { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static OurStreamTopScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTopScreenBuilder();

            value.ViewPrefab                                = GetObject<OurStreamTopScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamTopScreenView.FromPointer); // 0270DB651768 0x20 ViewPrefab                  ( 0001866FA0B0 ModelClassType OurStreamTopScreenView OurStreamTopScreenView OurStreamTopScreenView Pointer )
            value.DetailPopupViewFactory                    = GetObject<OurStreamLiveContentDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.OurStreamLiveContentDetailPopupViewFactory.FromPointer); // 0270DB651788 0x28 DetailPopupViewFactory      ( 0001866F42C0 ModelClassType OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DB6517A8 0x30 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
