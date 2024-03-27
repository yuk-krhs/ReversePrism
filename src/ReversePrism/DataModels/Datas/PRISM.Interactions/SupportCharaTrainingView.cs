using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtRequiredMoney                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtMoney                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GoAlert                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 BtnExecute                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnReset                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnOmakase                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 GoNormal                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 GoMax                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 TxtLvMaxSubText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TicketSelectorGroup                      0001866635A0 ModelClassType TicketSelectorViewGroup TicketSelectorViewGroup TicketSelectorViewGroup Pointer
    // 078 SupportEffectView                        0001865F25A0 ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer
    // 080 Vm                                       0001865E58C0 ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer
    public partial class SupportCharaTrainingView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredMoney                        { get; set; }
        public UITextMeshProUGUI?                       TxtMoney                                { get; set; }
        public GameObject?                              GoAlert                                 { get; set; }
        public UIButton?                                BtnExecute                              { get; set; }
        public UIButton?                                BtnReset                                { get; set; }
        public UIButton?                                BtnOmakase                              { get; set; }
        public GameObject?                              GoNormal                                { get; set; }
        public GameObject?                              GoMax                                   { get; set; }
        public UITextMeshProUGUI?                       TxtLvMaxSubText                         { get; set; }
        public TicketSelectorViewGroup?                 TicketSelectorGroup                     { get; set; }
        public SupportEffectView?                       SupportEffectView                       { get; set; }
        public SupportCharaTrainingViewModel?           Vm                                      { get; set; }

        public static SupportCharaTrainingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaTrainingView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA37A760 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA37A780 0x28 TxtRequiredMoney            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA37A7A0 0x30 TxtMoney                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA37A7C0 0x38 GoAlert                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExecute                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA37A7E0 0x40 BtnExecute                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnReset                                  = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA37A800 0x48 BtnReset                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnOmakase                                = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA37A820 0x50 BtnOmakase                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GoNormal                                  = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA37A840 0x58 GoNormal                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA37A860 0x60 GoMax                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLvMaxSubText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA37A880 0x68 TxtLvMaxSubText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TicketSelectorGroup                       = GetObject<TicketSelectorViewGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.TicketSelectorViewGroup.FromPointer); // 0270DA37A8A0 0x70 TicketSelectorGroup         ( 0001866635A0 ModelClassType TicketSelectorViewGroup TicketSelectorViewGroup TicketSelectorViewGroup Pointer )
            value.SupportEffectView                         = GetObject<SupportEffectView>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportEffectView.FromPointer); // 0270DA37A8C0 0x78 SupportEffectView           ( 0001865F25A0 ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer )
            value.Vm                                        = GetObject<SupportCharaTrainingViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.SupportCharaTrainingViewModel.FromPointer); // 0270DA37A8E0 0x80 Vm                          ( 0001865E58C0 ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer )

            return value;
        }
    }
}
