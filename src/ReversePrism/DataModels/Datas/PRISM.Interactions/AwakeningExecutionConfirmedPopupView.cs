using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeAwakeningLv                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AfterAwakeningLv                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TrSkillParent                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 GoIdolSkillContentView                   0001866B93E0 ModelClassType IdolSkillContentView IdolSkillContentView IdolSkillContentView Pointer
    // 040 TrItemParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 GoRequiredItemIconView                   00018666B4B0 ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer
    // 050 TxtRequiredMoney                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtMoney                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 068 onSkillDetailSubject                     Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class AwakeningExecutionConfirmedPopupView : DataModel
    {
        public UITextMeshProUGUI?                       BeforeAwakeningLv                       { get; set; }
        public UITextMeshProUGUI?                       AfterAwakeningLv                        { get; set; }
        public RectTransform?                           TrSkillParent                           { get; set; }
        public IdolSkillContentView?                    GoIdolSkillContentView                  { get; set; }
        public Transform?                               TrItemParent                            { get; set; }
        public RequiredItemIconView?                    GoRequiredItemIconView                  { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredMoney                        { get; set; }
        public UITextMeshProUGUI?                       TxtMoney                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static AwakeningExecutionConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningExecutionConfirmedPopupView() { Pointer= p0 };

            value.BeforeAwakeningLv                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E48B8 0x20 BeforeAwakeningLv           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterAwakeningLv                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E48D8 0x28 AfterAwakeningLv            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrSkillParent                             = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2E48F8 0x30 TrSkillParent               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GoIdolSkillContentView                    = GetObject<IdolSkillContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolSkillContentView.FromPointer); // 02466A2E4918 0x38 GoIdolSkillContentView      ( 0001866B93E0 ModelClassType IdolSkillContentView IdolSkillContentView IdolSkillContentView Pointer )
            value.TrItemParent                              = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466A2E4938 0x40 TrItemParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoRequiredItemIconView                    = GetObject<RequiredItemIconView>(new IntPtr(p + 0x048), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 02466A2E4958 0x48 GoRequiredItemIconView      ( 00018666B4B0 ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E4978 0x50 TxtRequiredMoney            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E4998 0x58 TxtMoney                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A2E49F8 0x70 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
