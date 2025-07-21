using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderTabGroup                           ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer
    // 028 ButtonParents                            ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 030 ScrollRects                              ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer
    // 038 UserButtonPrefab                         ModelClassType ChainTopUserButton ChainTopUserButton ChainTopUserButton Pointer
    // 040 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 048 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 050 userButtons                              Dictionary`2<int, ChainTopUserButton> IL2CPP_TYPE_GENERICINST
    public partial class ChainTopScreenView : DataModel
    {
        public MobileHeaderTabGroup?                    HeaderTabGroup                          { get; set; }
        public List<Transform>?                         ButtonParents                           { get; set; }
        public List<ScrollRect>?                        ScrollRects                             { get; set; }
        public ChainTopUserButton?                      UserButtonPrefab                        { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTopScreenView() { Pointer= p0 };

            value.HeaderTabGroup                            = GetObject<MobileHeaderTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileHeaderTabGroup.FromPointer); // 0x20 HeaderTabGroup              ( ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer )
            value.ButtonParents                             = GetObjectList<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ButtonParents               ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.ScrollRects                               = GetObjectList<ScrollRect>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x30 ScrollRects                 ( ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer )
            value.UserButtonPrefab                          = GetObject<ChainTopUserButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTopUserButton.FromPointer); // 0x38 UserButtonPrefab            ( ModelClassType ChainTopUserButton ChainTopUserButton ChainTopUserButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x40 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x48 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
