using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItem                               00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 AmountText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SpaceLine                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 onPassDetailSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopGoodsSetItem
    {
        public RewardItem?                              RewardItem                              { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UITextMeshProUGUI?                       AmountText                              { get; set; }
        public GameObject?                              SpaceLine                               { get; set; }

        public static ShopGoodsSetItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsSetItem();

            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D551C9F0 0x20 RewardItem                  ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D551CA10 0x28 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AmountText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D551CA30 0x30 AmountText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpaceLine                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D551CA50 0x38 SpaceLine                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
