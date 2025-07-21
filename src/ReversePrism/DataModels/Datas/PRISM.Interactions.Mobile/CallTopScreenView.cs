using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 HeaderTabGroup                           ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer
    // 030 ButtonParents                            ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 038 UserButtonPrefab                         ModelClassType CallTopUserButton CallTopUserButton CallTopUserButton Pointer
    // 040 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 048 ScrollRects                              ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 058 onClickUserButtonSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CallTopScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public MobileHeaderTabGroup?                    HeaderTabGroup                          { get; set; }
        public List<Transform>?                         ButtonParents                           { get; set; }
        public CallTopUserButton?                       UserButtonPrefab                        { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public List<ScrollRect>?                        ScrollRects                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static CallTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallTopScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0x20 Header                      ( ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.HeaderTabGroup                            = GetObject<MobileHeaderTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileHeaderTabGroup.FromPointer); // 0x28 HeaderTabGroup              ( ModelClassType MobileHeaderTabGroup MobileHeaderTabGroup MobileHeaderTabGroup Pointer )
            value.ButtonParents                             = GetObjectList<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 ButtonParents               ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.UserButtonPrefab                          = GetObject<CallTopUserButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.CallTopUserButton.FromPointer); // 0x38 UserButtonPrefab            ( ModelClassType CallTopUserButton CallTopUserButton CallTopUserButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x040), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x40 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ScrollRects                               = GetObjectList<ScrollRect>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x48 ScrollRects                 ( ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
