using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeLv                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AfterLv                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TrainingTicketsTotalExp                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ImgFillColorCurrent                      ModelClassType Image Image Image Pointer
    // 040 ImgFillColorNext                         ModelClassType Image Image Image Pointer
    // 048 SupportEffectView                        ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer
    // 050 TrItemParent                             ModelClassType Transform Transform Transform Pointer
    // 058 GoRequiredItemIconView                   ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer
    // 060 TxtRequiredMoney                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtMoney                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SCTrainingExecutionConfirmedPopupView : DataModel
    {
        public UITextMeshProUGUI?                       BeforeLv                                { get; set; }
        public UITextMeshProUGUI?                       AfterLv                                 { get; set; }
        public UITextMeshProUGUI?                       TrainingTicketsTotalExp                 { get; set; }
        public Image?                                   ImgFillColorCurrent                     { get; set; }
        public Image?                                   ImgFillColorNext                        { get; set; }
        public SupportEffectView?                       SupportEffectView                       { get; set; }
        public Transform?                               TrItemParent                            { get; set; }
        public RequiredItemIconView?                    GoRequiredItemIconView                  { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredMoney                        { get; set; }
        public UITextMeshProUGUI?                       TxtMoney                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SCTrainingExecutionConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCTrainingExecutionConfirmedPopupView() { Pointer= p0 };

            value.BeforeLv                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 BeforeLv                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterLv                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 AfterLv                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrainingTicketsTotalExp                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TrainingTicketsTotalExp     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFillColorCurrent                       = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 ImgFillColorCurrent         ( ModelClassType Image Image Image Pointer )
            value.ImgFillColorNext                          = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 ImgFillColorNext            ( ModelClassType Image Image Image Pointer )
            value.SupportEffectView                         = GetObject<SupportEffectView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectView.FromPointer); // 0x48 SupportEffectView           ( ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer )
            value.TrItemParent                              = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 TrItemParent                ( ModelClassType Transform Transform Transform Pointer )
            value.GoRequiredItemIconView                    = GetObject<RequiredItemIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 0x58 GoRequiredItemIconView      ( ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtRequiredMoney            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtMoney                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x78 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
