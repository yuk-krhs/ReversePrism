using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 030 EmptyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 UserIconImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 040 ButtonsParent                            ModelClassType Transform Transform Transform Pointer
    // 048 ButtonPrefab                             ModelClassType ChainTalkHistoryButton ChainTalkHistoryButton ChainTalkHistoryButton Pointer
    // 050 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 058 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 060 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 068 onClickTalkHistoryButtonSubject          Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChainTalkHistoryScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UIImage?                                 UserIconImage                           { get; set; }
        public Transform?                               ButtonsParent                           { get; set; }
        public ChainTalkHistoryButton?                  ButtonPrefab                            { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainTalkHistoryScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkHistoryScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0x20 Header                      ( ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 EmptyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 UserIconImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ButtonsParent                             = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 ButtonsParent               ( ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<ChainTalkHistoryButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkHistoryButton.FromPointer); // 0x48 ButtonPrefab                ( ModelClassType ChainTalkHistoryButton ChainTalkHistoryButton ChainTalkHistoryButton Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x50 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x058), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x58 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x60 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
