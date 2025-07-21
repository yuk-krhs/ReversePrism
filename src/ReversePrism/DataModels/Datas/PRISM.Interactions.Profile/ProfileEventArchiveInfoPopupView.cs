using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventTitleText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 EventSpriteImage                         ModelClassType Image Image Image Pointer
    // 030 ExpiryDate                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TourList                                 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TourEventInfo                            ModelClassType ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView Pointer
    // 048 TourScroller                             ModelClassType Scroller Scroller Scroller Pointer
    // 050 LiveEventInfo                            ModelClassType ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileEventArchiveInfoPopupView : DataModel
    {
        public UITextMeshProUGUI?                       EventTitleText                          { get; set; }
        public Image?                                   EventSpriteImage                        { get; set; }
        public UITextMeshProUGUI?                       ExpiryDate                              { get; set; }
        public GameObject?                              TourList                                { get; set; }
        public ProfileEventArchiveInfoTourPopupView?    TourEventInfo                           { get; set; }
        public Scroller?                                TourScroller                            { get; set; }
        public ProfileEventArchiveInfoLivePopupView?    LiveEventInfo                           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileEventArchiveInfoPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveInfoPopupView() { Pointer= p0 };

            value.EventTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 EventTitleText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventSpriteImage                          = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 EventSpriteImage            ( ModelClassType Image Image Image Pointer )
            value.ExpiryDate                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ExpiryDate                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TourList                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 TourList                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TourEventInfo                             = GetObject<ProfileEventArchiveInfoTourPopupView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileEventArchiveInfoTourPopupView.FromPointer); // 0x40 TourEventInfo               ( ModelClassType ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView Pointer )
            value.TourScroller                              = GetObject<Scroller>(new IntPtr(p + 0x048), ReversePrism.DataModels.Scroller.FromPointer); // 0x48 TourScroller                ( ModelClassType Scroller Scroller Scroller Pointer )
            value.LiveEventInfo                             = GetObject<ProfileEventArchiveInfoLivePopupView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileEventArchiveInfoLivePopupView.FromPointer); // 0x50 LiveEventInfo               ( ModelClassType ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
