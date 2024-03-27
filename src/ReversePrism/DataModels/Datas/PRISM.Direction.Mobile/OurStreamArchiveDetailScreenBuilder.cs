using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               0001866F1140 ModelClassType OurStreamArchiveDetailScreenView OurStreamArchiveDetailScreenView OurStreamArchiveDetailScreenView Pointer
    // 028 DetailPopupViewFactory                   0001866F42C0 ModelClassType OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory Pointer
    // 030 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class OurStreamArchiveDetailScreenBuilder
    {
        public OurStreamArchiveDetailScreenView?        ViewPrefab                              { get; set; }
        public OurStreamLiveContentDetailPopupViewFactory? DetailPopupViewFactory                  { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static OurStreamArchiveDetailScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailScreenBuilder();

            value.ViewPrefab                                = GetObject<OurStreamArchiveDetailScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamArchiveDetailScreenView.FromPointer); // 0270DB647888 0x20 ViewPrefab                  ( 0001866F1140 ModelClassType OurStreamArchiveDetailScreenView OurStreamArchiveDetailScreenView OurStreamArchiveDetailScreenView Pointer )
            value.DetailPopupViewFactory                    = GetObject<OurStreamLiveContentDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.OurStreamLiveContentDetailPopupViewFactory.FromPointer); // 0270DB6478A8 0x28 DetailPopupViewFactory      ( 0001866F42C0 ModelClassType OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory OurStreamLiveContentDetailPopupViewFactory Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DB6478C8 0x30 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
