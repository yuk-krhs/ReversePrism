using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgNormal                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 GoNormalText                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 CgMaxLv                                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 AwakeningBtn                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 HowToGetItemsBtn                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 TxtRequiredMoney                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtMoney                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GoAlert                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 TxtAlert                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 AwakeningLvSelector                      00018672E3B0 ModelClassType AwakeningLvSelector AwakeningLvSelector AwakeningLvSelector Pointer
    // 078 ItemPager                                000186740C40 ModelClassType ItemPager ItemPager ItemPager Pointer
    // 080 IdolSkillListView                        0001866BE5F0 ModelClassType IdolSkillListView IdolSkillListView IdolSkillListView Pointer
    // 088 onSkillDetail                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 090 onHowToGetItems                          Subject`1<List`1<ValueTuple`3<ProductKey, long, long>>> IL2CPP_TYPE_GENERICINST
    // 098 exeAwakening                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 Vm                                       000186547710 ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer
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

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3BC890 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgNormal                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3BC8B0 0x28 CgNormal                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormalText                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3BC8D0 0x30 GoNormalText                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CgMaxLv                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3BC8F0 0x38 CgMaxLv                     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.AwakeningBtn                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3BC910 0x40 AwakeningBtn                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToGetItemsBtn                          = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3BC930 0x48 HowToGetItemsBtn            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3BC950 0x50 TxtRequiredMoney            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3BC970 0x58 TxtMoney                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3BC990 0x60 GoAlert                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtAlert                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3BC9B0 0x68 TxtAlert                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AwakeningLvSelector                       = GetObject<AwakeningLvSelector>(new IntPtr(p + 0x070), ReversePrism.DataModels.AwakeningLvSelector.FromPointer); // 02466A3BC9D0 0x70 AwakeningLvSelector         ( 00018672E3B0 ModelClassType AwakeningLvSelector AwakeningLvSelector AwakeningLvSelector Pointer )
            value.ItemPager                                 = GetObject<ItemPager>(new IntPtr(p + 0x078), ReversePrism.DataModels.ItemPager.FromPointer); // 02466A3BC9F0 0x78 ItemPager                   ( 000186740C40 ModelClassType ItemPager ItemPager ItemPager Pointer )
            value.IdolSkillListView                         = GetObject<IdolSkillListView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IdolSkillListView.FromPointer); // 02466A3BCA10 0x80 IdolSkillListView           ( 0001866BE5F0 ModelClassType IdolSkillListView IdolSkillListView IdolSkillListView Pointer )
            value.Vm                                        = GetObject<ProduceIdolAwakeningViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProduceIdolAwakeningViewModel.FromPointer); // 02466A3BCA90 0xA0 Vm                          ( 000186547710 ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer )

            return value;
        }
    }
}
