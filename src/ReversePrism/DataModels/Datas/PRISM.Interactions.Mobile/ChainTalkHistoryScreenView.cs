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
    // 040 ButtonsParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 ButtonPrefab                             000186560E00 ModelClassType ChainTalkHistoryButton ChainTalkHistoryButton ChainTalkHistoryButton Pointer
    // 050 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 058 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 060 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 068 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 070 onClickTalkHistoryButtonSubject          Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChainTalkHistoryScreenView
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UIImage?                                 UserIconImage                           { get; set; }
        public Transform?                               ButtonsParent                           { get; set; }
        public ChainTalkHistoryButton?                  ButtonPrefab                            { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChainTalkHistoryScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkHistoryScreenView();

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0270DB1152A8 0x20 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB1152C8 0x28 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB1152E8 0x30 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB115308 0x38 UserIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ButtonsParent                             = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0270DB115328 0x40 ButtonsParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<ChainTalkHistoryButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkHistoryButton.FromPointer); // 0270DB115348 0x48 ButtonPrefab                ( 000186560E00 ModelClassType ChainTalkHistoryButton ChainTalkHistoryButton ChainTalkHistoryButton Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270DB115368 0x50 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x058), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB115388 0x58 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0270DB1153A8 0x60 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB1153C8 0x68 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
