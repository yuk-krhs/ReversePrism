using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgNormal                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgMax                                    ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 IdolSkillLvSelector                      ModelClassType IdolSkillLvSelector IdolSkillLvSelector IdolSkillLvSelector Pointer
    // 038 ItemPager                                ModelClassType ItemPager ItemPager ItemPager Pointer
    // 040 TxtRequiredMoney                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtMoney                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 GoAlert                                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 TxtAlert                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 HowToGetItemsBtn                         ModelClassType UIButton UIButton UIButton Pointer
    // 068 ExecuteBtn                               ModelClassType UIButton UIButton UIButton Pointer
    // 070 RequiredMoney                            ModelPrimitiveType long long long Int64
    // 078 Money                                    ModelPrimitiveType long long long Int64
    // 080 ItemIconViews                            ModelClassListType IReadOnlyList`1<RequiredItemIconView> IReadOnlyList`1<RequiredItemIconView> List<RequiredItemIconView> Pointer
    // 088 onHowToGetItems                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onExecute                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolSkillLvUpView : DataModel
    {
        public CanvasGroup?                             CgNormal                                { get; set; }
        public CanvasGroup?                             CgMax                                   { get; set; }
        public IdolSkillLvSelector?                     IdolSkillLvSelector                     { get; set; }
        public ItemPager?                               ItemPager                               { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredMoney                        { get; set; }
        public UITextMeshProUGUI?                       TxtMoney                                { get; set; }
        public GameObject?                              GoAlert                                 { get; set; }
        public UITextMeshProUGUI?                       TxtAlert                                { get; set; }
        public UIButton?                                HowToGetItemsBtn                        { get; set; }
        public UIButton?                                ExecuteBtn                              { get; set; }
        public long                                     RequiredMoney                           { get; set; }
        public long                                     Money                                   { get; set; }
        public List<RequiredItemIconView>?              ItemIconViews                           { get; set; }

        public static ProduceIdolSkillLvUpView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSkillLvUpView() { Pointer= p0 };

            value.CgNormal                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CgNormal                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgMax                                     = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgMax                       ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IdolSkillLvSelector                       = GetObject<IdolSkillLvSelector>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolSkillLvSelector.FromPointer); // 0x30 IdolSkillLvSelector         ( ModelClassType IdolSkillLvSelector IdolSkillLvSelector IdolSkillLvSelector Pointer )
            value.ItemPager                                 = GetObject<ItemPager>(new IntPtr(p + 0x038), ReversePrism.DataModels.ItemPager.FromPointer); // 0x38 ItemPager                   ( ModelClassType ItemPager ItemPager ItemPager Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtRequiredMoney            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtMoney                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoAlert                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtAlert                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtAlert                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HowToGetItemsBtn                          = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 HowToGetItemsBtn            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ExecuteBtn                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 ExecuteBtn                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RequiredMoney                             = GetInt64(new IntPtr(p + 0x070)); // 0x70 RequiredMoney               ( ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt64(new IntPtr(p + 0x078)); // 0x78 Money                       ( ModelPrimitiveType long long long Int64 )
            value.ItemIconViews                             = GetObjectList<RequiredItemIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 0x80 ItemIconViews               ( ModelClassListType IReadOnlyList`1<RequiredItemIconView> IReadOnlyList`1<RequiredItemIconView> List<RequiredItemIconView> Pointer )

            return value;
        }
    }
}
