using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgNormal                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 GoNormalText                             ModelClassType GameObject GameObject GameObject Pointer
    // 038 CgMaxLv                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 AwakeningBtn                             ModelClassType UIButton UIButton UIButton Pointer
    // 048 HowToGetItemsBtn                         ModelClassType UIButton UIButton UIButton Pointer
    // 050 TxtRequiredMoney                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtMoney                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GoAlert                                  ModelClassType GameObject GameObject GameObject Pointer
    // 068 TxtAlert                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 AwakeningLvSelector                      ModelClassType AwakeningLvSelector AwakeningLvSelector AwakeningLvSelector Pointer
    // 078 ItemPager                                ModelClassType ItemPager ItemPager ItemPager Pointer
    // 080 IdolSkillListView                        ModelClassType IdolSkillListView IdolSkillListView IdolSkillListView Pointer
    // 088 onSkillDetail                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 090 exeAwakening                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 098 Vm                                       ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer
    public partial class ProduceIdolAwakeningView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public CanvasGroup?                             CgNormal                                { get; set; }
        public GameObject?                              GoNormalText                            { get; set; }
        public CanvasGroup?                             CgMaxLv                                 { get; set; }
        public UIButton?                                AwakeningBtn                            { get; set; }
        public UIButton?                                HowToGetItemsBtn                        { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredMoney                        { get; set; }
        public UITextMeshProUGUI?                       TxtMoney                                { get; set; }
        public GameObject?                              GoAlert                                 { get; set; }
        public UITextMeshProUGUI?                       TxtAlert                                { get; set; }
        public AwakeningLvSelector?                     AwakeningLvSelector                     { get; set; }
        public ItemPager?                               ItemPager                               { get; set; }
        public IdolSkillListView?                       IdolSkillListView                       { get; set; }
        public ProduceIdolAwakeningViewModel?           Vm                                      { get; set; }

        public static ProduceIdolAwakeningView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolAwakeningView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgNormal                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgNormal                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormalText                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoNormalText                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CgMaxLv                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CgMaxLv                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AwakeningBtn                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 AwakeningBtn                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToGetItemsBtn                          = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 HowToGetItemsBtn            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtRequiredMoney            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtMoney                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 GoAlert                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtAlert                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtAlert                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AwakeningLvSelector                       = GetObject<AwakeningLvSelector>(new IntPtr(p + 0x070), ReversePrism.DataModels.AwakeningLvSelector.FromPointer); // 0x70 AwakeningLvSelector         ( ModelClassType AwakeningLvSelector AwakeningLvSelector AwakeningLvSelector Pointer )
            value.ItemPager                                 = GetObject<ItemPager>(new IntPtr(p + 0x078), ReversePrism.DataModels.ItemPager.FromPointer); // 0x78 ItemPager                   ( ModelClassType ItemPager ItemPager ItemPager Pointer )
            value.IdolSkillListView                         = GetObject<IdolSkillListView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IdolSkillListView.FromPointer); // 0x80 IdolSkillListView           ( ModelClassType IdolSkillListView IdolSkillListView IdolSkillListView Pointer )
            value.Vm                                        = GetObject<ProduceIdolAwakeningViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceIdolAwakeningViewModel.FromPointer); // 0x98 Vm                          ( ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer )

            return value;
        }
    }
}
