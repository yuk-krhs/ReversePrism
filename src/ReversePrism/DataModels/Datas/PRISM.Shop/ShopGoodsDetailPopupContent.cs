using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ItemSetContainer                         ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer
    // 068 BonusSetContainer                        ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer
    // 070 TabPanel                                 ModelClassType GameObject GameObject GameObject Pointer
    // 078 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 080 CautionPanel                             ModelClassType GameObject GameObject GameObject Pointer
    // 088 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 IsShowBonusContent                       ModelPrimitiveType bool bool bool Bool
    public partial class ShopGoodsDetailPopupContent : DataModel
    {
        public ShopGoodsSetItemContainer?               ItemSetContainer                        { get; set; }
        public ShopGoodsSetItemContainer?               BonusSetContainer                       { get; set; }
        public GameObject?                              TabPanel                                { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public GameObject?                              CautionPanel                            { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public bool                                     IsShowBonusContent                      { get; set; }

        public static ShopGoodsDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsDetailPopupContent() { Pointer= p0 };

            value.ItemSetContainer                          = GetObject<ShopGoodsSetItemContainer>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopGoodsSetItemContainer.FromPointer); // 0x60 ItemSetContainer            ( ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer )
            value.BonusSetContainer                         = GetObject<ShopGoodsSetItemContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopGoodsSetItemContainer.FromPointer); // 0x68 BonusSetContainer           ( ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer )
            value.TabPanel                                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 TabPanel                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x78 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CautionPanel                              = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 CautionPanel                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IsShowBonusContent                        = GetBool(new IntPtr(p + 0x090)); // 0x90 IsShowBonusContent          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
