using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ItemSetContainer                         00018675D620 ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer
    // 068 BonusSetContainer                        00018675D620 ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer
    // 070 TabPanel                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 080 CautionPanel                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 IsShowBonusContent                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ShopGoodsDetailPopupContent
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
            var value   = new ShopGoodsDetailPopupContent();

            value.ItemSetContainer                          = GetObject<ShopGoodsSetItemContainer>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopGoodsSetItemContainer.FromPointer); // 0270D5519C88 0x60 ItemSetContainer            ( 00018675D620 ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer )
            value.BonusSetContainer                         = GetObject<ShopGoodsSetItemContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopGoodsSetItemContainer.FromPointer); // 0270D5519CA8 0x68 BonusSetContainer           ( 00018675D620 ModelClassType ShopGoodsSetItemContainer ShopGoodsSetItemContainer ShopGoodsSetItemContainer Pointer )
            value.TabPanel                                  = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5519CC8 0x70 TabPanel                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270D5519CE8 0x78 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CautionPanel                              = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5519D08 0x80 CautionPanel                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5519D28 0x88 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IsShowBonusContent                        = GetBool(new IntPtr(p + 0x090)); // 0270D5519D48 0x90 IsShowBonusContent          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
