using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderTabGroup                           00018662DD10 ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer
    // 028 ButtonParents                            000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 030 ScrollRects                              000185CA2DF8 ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer
    // 038 UserButtonPrefab                         00018656A940 ModelClassType ChainTopUserButton ChainTopUserButton ChainTopUserButton Pointer
    // 040 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 048 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 050 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 058 userButtons                              Dictionary`2<int, ChainTopUserButton> IL2CPP_TYPE_GENERICINST
    public partial class ChainTopScreenView : DataModel
    {
        public MobileHeaderTabGroup?                    HeaderTabGroup                          { get; set; }
        public List<Transform>?                         ButtonParents                           { get; set; }
        public List<ScrollRect>?                        ScrollRects                             { get; set; }
        public ChainTopUserButton?                      UserButtonPrefab                        { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChainTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTopScreenView() { Pointer= p0 };

            value.HeaderTabGroup                            = GetObject<MobileHeaderTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileHeaderTabGroup.FromPointer); // 02466B176CB0 0x20 HeaderTabGroup              ( 00018662DD10 ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer )
            value.ButtonParents                             = GetObjectList<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B176CD0 0x28 ButtonParents               ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.ScrollRects                               = GetObjectList<ScrollRect>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B176CF0 0x30 ScrollRects                 ( 000185CA2DF8 ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer )
            value.UserButtonPrefab                          = GetObject<ChainTopUserButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTopUserButton.FromPointer); // 02466B176D10 0x38 UserButtonPrefab            ( 00018656A940 ModelClassType ChainTopUserButton ChainTopUserButton ChainTopUserButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 02466B176D30 0x40 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.ResourceLoader.FromPointer); // 02466B176D50 0x48 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B176D70 0x50 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
