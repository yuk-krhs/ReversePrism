using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 UserIconImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 ButtonParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 ButtonPrefab                             000186528630 ModelClassType CallHistoryButton CallHistoryButton CallHistoryButton Pointer
    // 050 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 058 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 060 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 068 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 070 onClickCallHistoryButtonSubject          Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CallHistoryScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UIImage?                                 UserIconImage                           { get; set; }
        public Transform?                               ButtonParent                            { get; set; }
        public CallHistoryButton?                       ButtonPrefab                            { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static CallHistoryScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallHistoryScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 02466B149A38 0x20 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B149A58 0x28 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B149A78 0x30 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 02466B149A98 0x38 UserIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ButtonParent                              = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466B149AB8 0x40 ButtonParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<CallHistoryButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.CallHistoryButton.FromPointer); // 02466B149AD8 0x48 ButtonPrefab                ( 000186528630 ModelClassType CallHistoryButton CallHistoryButton CallHistoryButton Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x050), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 02466B149AF8 0x50 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B149B18 0x58 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.ResourceLoader.FromPointer); // 02466B149B38 0x60 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B149B58 0x68 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
