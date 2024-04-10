using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgNormal                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgMax                                    000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 IdolSkillLvSelector                      0001866BF1F0 ModelClassType IdolSkillLvSelector IdolSkillLvSelector IdolSkillLvSelector Pointer
    // 038 ItemPager                                000186740C40 ModelClassType ItemPager ItemPager ItemPager Pointer
    // 040 TxtRequiredMoney                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtMoney                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 GoAlert                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 TxtAlert                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 HowToGetItemsBtn                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 ExecuteBtn                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 RequiredMoney                            0001865F7700 ModelPrimitiveType long long long Int64
    // 078 Money                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 080 ItemIconViews                            000185D15388 ModelClassListType IReadOnlyList`1<RequiredItemIconView> IReadOnlyList`1<RequiredItemIconView> List<RequiredItemIconView> Pointer
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

            value.CgNormal                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3BF460 0x20 CgNormal                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgMax                                     = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3BF480 0x28 CgMax                       ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IdolSkillLvSelector                       = GetObject<IdolSkillLvSelector>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolSkillLvSelector.FromPointer); // 02466A3BF4A0 0x30 IdolSkillLvSelector         ( 0001866BF1F0 ModelClassType IdolSkillLvSelector IdolSkillLvSelector IdolSkillLvSelector Pointer )
            value.ItemPager                                 = GetObject<ItemPager>(new IntPtr(p + 0x038), ReversePrism.DataModels.ItemPager.FromPointer); // 02466A3BF4C0 0x38 ItemPager                   ( 000186740C40 ModelClassType ItemPager ItemPager ItemPager Pointer )
            value.TxtRequiredMoney                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3BF4E0 0x40 TxtRequiredMoney            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMoney                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3BF500 0x48 TxtMoney                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3BF520 0x50 GoAlert                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtAlert                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3BF540 0x58 TxtAlert                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HowToGetItemsBtn                          = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3BF560 0x60 HowToGetItemsBtn            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ExecuteBtn                                = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3BF580 0x68 ExecuteBtn                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RequiredMoney                             = GetInt64(new IntPtr(p + 0x070)); // 02466A3BF5A0 0x70 RequiredMoney               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt64(new IntPtr(p + 0x078)); // 02466A3BF5C0 0x78 Money                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ItemIconViews                             = GetObjectList<RequiredItemIconView>(new IntPtr(p + 0x080), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 02466A3BF5E0 0x80 ItemIconViews               ( 000185D15388 ModelClassListType IReadOnlyList`1<RequiredItemIconView> IReadOnlyList`1<RequiredItemIconView> List<RequiredItemIconView> Pointer )

            return value;
        }
    }
}
