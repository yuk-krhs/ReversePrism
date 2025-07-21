using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtRequiredMoney                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtMoney                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GoAlert                                  ModelClassType GameObject GameObject GameObject Pointer
    // 040 BtnExecute                               ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnReset                                 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnOmakase                               ModelClassType UIButton UIButton UIButton Pointer
    // 058 GoNormal                                 ModelClassType GameObject GameObject GameObject Pointer
    // 060 GoMax                                    ModelClassType GameObject GameObject GameObject Pointer
    // 068 TxtLvMaxSubText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TicketSelectorGroup                      ModelClassType TicketSelectorViewGroup TicketSelectorViewGroup TicketSelectorViewGroup Pointer
    // 078 SupportEffectView                        ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer
    // 080 Vm                                       ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer
    public partial class SupportCharaTrainingView : DataModel
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
            var value   = new SupportCharaTrainingView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtRequiredMoney            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtMoney                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 GoAlert                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExecute                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnExecute                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnReset                                  = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 BtnReset                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnOmakase                                = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 BtnOmakase                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GoNormal                                  = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoNormal                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 GoMax                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLvMaxSubText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtLvMaxSubText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TicketSelectorGroup                       = GetObject<TicketSelectorViewGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.TicketSelectorViewGroup.FromPointer); // 0x70 TicketSelectorGroup         ( ModelClassType TicketSelectorViewGroup TicketSelectorViewGroup TicketSelectorViewGroup Pointer )
            value.SupportEffectView                         = GetObject<SupportEffectView>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportEffectView.FromPointer); // 0x78 SupportEffectView           ( ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer )
            value.Vm                                        = GetObject<SupportCharaTrainingViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.SupportCharaTrainingViewModel.FromPointer); // 0x80 Vm                          ( ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer )

            return value;
        }
    }
}
