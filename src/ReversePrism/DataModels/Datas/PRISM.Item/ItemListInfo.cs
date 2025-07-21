using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UseButtonKey                             string IL2CPP_TYPE_STRING
    // 020 InfoObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 ItemIcon                                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 ItemName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ItemDescription                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ExpireText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ExpireButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 050 UseButton                                ModelClassType UIButton UIButton UIButton Pointer
    // 058 UseButtonText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 StaminaRecoveryPopupCaller               ModelClassType StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller Pointer
    // 068 Product                                  ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 070 UseAction                                ModelClassType Action Action Action Pointer
    // 078 IsJump                                   ModelPrimitiveType bool bool bool Bool
    // 080 useJumpSubject                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 expiredSubject                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 staminaRecoverySubject                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ItemListInfo : DataModel
    {
        public GameObject?                              InfoObject                              { get; set; }
        public RewardItem?                              ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       ItemName                                { get; set; }
        public UITextMeshProUGUI?                       ItemDescription                         { get; set; }
        public UITextMeshProUGUI?                       ExpireText                              { get; set; }
        public UIButton?                                ExpireButton                            { get; set; }
        public UIButton?                                UseButton                               { get; set; }
        public UITextMeshProUGUI?                       UseButtonText                           { get; set; }
        public StaminaRecoveryPopupCaller?              StaminaRecoveryPopupCaller              { get; set; }
        public IHavingProductStatus?                    Product                                 { get; set; }
        public Action?                                  UseAction                               { get; set; }
        public bool                                     IsJump                                  { get; set; }

        public static ItemListInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListInfo() { Pointer= p0 };

            value.InfoObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 InfoObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0x28 ItemIcon                    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ItemName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ItemName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemDescription                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ItemDescription             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ExpireText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireButton                              = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 ExpireButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseButton                                 = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 UseButton                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseButtonText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 UseButtonText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaRecoveryPopupCaller                = GetObject<StaminaRecoveryPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.StaminaRecoveryPopupCaller.FromPointer); // 0x60 StaminaRecoveryPopupCaller  ( ModelClassType StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller Pointer )
            value.Product                                   = GetObject<IHavingProductStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x68 Product                     ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.UseAction                                 = GetObject<Action>(new IntPtr(p + 0x070), ReversePrism.DataModels.Action.FromPointer); // 0x70 UseAction                   ( ModelClassType Action Action Action Pointer )
            value.IsJump                                    = GetBool(new IntPtr(p + 0x078)); // 0x78 IsJump                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
