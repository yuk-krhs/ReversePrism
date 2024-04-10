using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgCategory                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 TxtCategory                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtTime                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TxtUpdateTime                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtUpdateName                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 XMLPanel                                 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 060 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 FrameParameter                           000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 070 ViewModel                                0001866BEEE0 ModelClassType AnnounceDetailPopupViewModel AnnounceDetailPopupViewModel AnnounceDetailPopupViewModel Pointer
    // 078 onClosed                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AnnounceDetailPopupView : DataModel
    {
        public Image?                                   ImgCategory                             { get; set; }
        public UITextMeshProUGUI?                       TxtCategory                             { get; set; }
        public UITextMeshProUGUI?                       TxtTime                                 { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public UITextMeshProUGUI?                       TxtUpdateTime                           { get; set; }
        public UITextMeshProUGUI?                       TxtUpdateName                           { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public XMLPanel?                                XMLPanel                                { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public PopupFrameParameter?                     FrameParameter                          { get; set; }
        public AnnounceDetailPopupViewModel?            ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static AnnounceDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceDetailPopupView() { Pointer= p0 };

            value.ImgCategory                               = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 02466BE612B0 0x20 ImgCategory                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtCategory                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE612D0 0x28 TxtCategory                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTime                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE612F0 0x30 TxtTime                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466BE61310 0x38 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtUpdateTime                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61330 0x40 TxtUpdateTime               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtUpdateName                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61350 0x48 TxtUpdateName               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BE61370 0x50 TxtTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.XMLPanel                                  = GetObject<XMLPanel>(new IntPtr(p + 0x058), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466BE61390 0x58 XMLPanel                    ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466BE613B0 0x60 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 02466BE613D0 0x68 FrameParameter              ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.ViewModel                                 = GetObject<AnnounceDetailPopupViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnnounceDetailPopupViewModel.FromPointer); // 02466BE613F0 0x70 ViewModel                   ( 0001866BEEE0 ModelClassType AnnounceDetailPopupViewModel AnnounceDetailPopupViewModel AnnounceDetailPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BE61430 0x80 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
