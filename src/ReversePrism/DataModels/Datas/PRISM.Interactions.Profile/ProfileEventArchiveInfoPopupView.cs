using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventTitleText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 EventSpriteImage                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 ExpiryDate                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TourList                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TourEventInfo                            0001865B0E50 ModelClassType ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView Pointer
    // 048 TourScroller                             0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer
    // 050 LiveEventInfo                            0001865AF830 ModelClassType ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.EventTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B7BA8B8 0x20 EventTitleText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventSpriteImage                          = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 02466B7BA8D8 0x28 EventSpriteImage            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ExpiryDate                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B7BA8F8 0x30 ExpiryDate                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TourList                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466B7BA918 0x38 TourList                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TourEventInfo                             = GetObject<ProfileEventArchiveInfoTourPopupView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileEventArchiveInfoTourPopupView.FromPointer); // 02466B7BA938 0x40 TourEventInfo               ( 0001865B0E50 ModelClassType ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView ProfileEventArchiveInfoTourPopupView Pointer )
            value.TourScroller                              = GetObject<Scroller>(new IntPtr(p + 0x048), ReversePrism.DataModels.Scroller.FromPointer); // 02466B7BA958 0x48 TourScroller                ( 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer )
            value.LiveEventInfo                             = GetObject<ProfileEventArchiveInfoLivePopupView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileEventArchiveInfoLivePopupView.FromPointer); // 02466B7BA978 0x50 LiveEventInfo               ( 0001865AF830 ModelClassType ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView ProfileEventArchiveInfoLivePopupView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B7BA9B8 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
