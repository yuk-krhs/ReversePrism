using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 HeaderTabGroup                           00018662DD10 ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer
    // 030 ButtonParents                            000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 038 UserButtonPrefab                         000186530910 ModelClassType CallTopUserButton CallTopUserButton CallTopUserButton Pointer
    // 040 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 048 ScrollRects                              000185CA2DF8 ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer
    // 050 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 058 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 060 onClickUserButtonSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CallTopScreenView
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public MobileHeaderTabGroup?                    HeaderTabGroup                          { get; set; }
        public List<Transform>?                         ButtonParents                           { get; set; }
        public CallTopUserButton?                       UserButtonPrefab                        { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public List<ScrollRect>?                        ScrollRects                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static CallTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallTopScreenView();

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0270DB0E3AF8 0x20 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.HeaderTabGroup                            = GetObject<MobileHeaderTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileHeaderTabGroup.FromPointer); // 0270DB0E3B18 0x28 HeaderTabGroup              ( 00018662DD10 ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer )
            value.ButtonParents                             = GetObjectList<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DB0E3B38 0x30 ButtonParents               ( 000185CACE28 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.UserButtonPrefab                          = GetObject<CallTopUserButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.CallTopUserButton.FromPointer); // 0270DB0E3B58 0x38 UserButtonPrefab            ( 000186530910 ModelClassType CallTopUserButton CallTopUserButton CallTopUserButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB0E3B78 0x40 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ScrollRects                               = GetObjectList<ScrollRect>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270DB0E3B98 0x48 ScrollRects                 ( 000185CA2DF8 ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0270DB0E3BB8 0x50 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB0E3BD8 0x58 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
