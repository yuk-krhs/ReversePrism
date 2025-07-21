using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeSkillLv                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AfterSkillLv                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TrItemParent                             ModelClassType Transform Transform Transform Pointer
    // 038 GoRequiredItemIconView                   ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer
    // 040 TxtRequiredMoney                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtMoney                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SkillListView                            ModelClassType ProduceIdolSkillListView ProduceIdolSkillListView ProduceIdolSkillListView Pointer
    // 058 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 onSkillKeyWord                           Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class IdolSkillLvUpExecutionConfirmedPopupView : DataModel
    {
        public UITextMeshProUGUI?                       BeforeSkillLv                           { get; set; }
        public UITextMeshProUGUI?                       AfterSkillLv                            { get; set; }
        public Transform?                               TrItemParent                            { get; set; }
        public RequiredItemIconView?                    GoRequiredItemIconView                  { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredMoney                        { get; set; }
        public UITextMeshProUGUI?                       TxtMoney                                { get; set; }
        public ProduceIdolSkillListView?                SkillListView                           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static IdolSkillLvUpExecutionConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvUpExecutionConfirmedPopupView() { Pointer= p0 };

            value.BeforeSkillLv                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 BeforeSkillLv               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterSkillLv                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 AfterSkillLv                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrItemParent                              = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 TrItemParent                ( ModelClassType Transform Transform Transform Pointer )
            value.GoRequiredItemIconView                    = GetObject<RequiredItemIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 0x38 GoRequiredItemIconView      ( ModelClassType RequiredItemIconView RequiredItemIconView RequiredItemIconView Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtRequiredMoney            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtMoney                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillListView                             = GetObject<ProduceIdolSkillListView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceIdolSkillListView.FromPointer); // 0x50 SkillListView               ( ModelClassType ProduceIdolSkillListView ProduceIdolSkillListView ProduceIdolSkillListView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
