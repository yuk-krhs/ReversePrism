using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtIdolLv                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 GoIdolLvMax                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 TxtIdolExp                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ImgIdolExpFillColor                      0001866CCDB0 ModelClassType Image Image Image Pointer
    // 048 BtnIdolLvRewardList                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 VoDaViMeView                             000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    // 058 TxtReliabilityLv                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GoReliabilityLvMax                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 TxtReliabilityExp                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ImgReliabilityExpFillColor               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 078 BtnReliabilityRewardList                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 TxtFan                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 onIdolLvRewardList                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onReliabilityRewardList                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class IdolBaseDetailStatusView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TxtIdolLv                               { get; set; }
        public GameObject?                              GoIdolLvMax                             { get; set; }
        public UITextMeshProUGUI?                       TxtIdolExp                              { get; set; }
        public Image?                                   ImgIdolExpFillColor                     { get; set; }
        public UIButton?                                BtnIdolLvRewardList                     { get; set; }
        public VoDaViMeView?                            VoDaViMeView                            { get; set; }
        public UITextMeshProUGUI?                       TxtReliabilityLv                        { get; set; }
        public GameObject?                              GoReliabilityLvMax                      { get; set; }
        public UITextMeshProUGUI?                       TxtReliabilityExp                       { get; set; }
        public Image?                                   ImgReliabilityExpFillColor              { get; set; }
        public UIButton?                                BtnReliabilityRewardList                { get; set; }
        public UITextMeshProUGUI?                       TxtFan                                  { get; set; }

        public static IdolBaseDetailStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailStatusView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2C0A40 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtIdolLv                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C0A60 0x28 TxtIdolLv                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoIdolLvMax                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2C0A80 0x30 GoIdolLvMax                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtIdolExp                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C0AA0 0x38 TxtIdolExp                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgIdolExpFillColor                       = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 02466A2C0AC0 0x40 ImgIdolExpFillColor         ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.BtnIdolLvRewardList                       = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C0AE0 0x48 BtnIdolLvRewardList         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 02466A2C0B00 0x50 VoDaViMeView                ( 000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )
            value.TxtReliabilityLv                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C0B20 0x58 TxtReliabilityLv            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoReliabilityLvMax                        = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2C0B40 0x60 GoReliabilityLvMax          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtReliabilityExp                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C0B60 0x68 TxtReliabilityExp           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgReliabilityExpFillColor                = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 02466A2C0B80 0x70 ImgReliabilityExpFillColor  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.BtnReliabilityRewardList                  = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C0BA0 0x78 BtnReliabilityRewardList    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtFan                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C0BC0 0x80 TxtFan                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
