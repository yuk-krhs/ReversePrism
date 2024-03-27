using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UseButtonKey                             string IL2CPP_TYPE_STRING
    // 020 InfoObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ItemIcon                                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 ItemName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ItemDescription                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ExpireText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ExpireButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 UseButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 UseButtonText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 Product                                  000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 068 UseAction                                0001866792B0 ModelClassType Action Action Action Pointer
    // 070 IsJump                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 useJumpSubject                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 expiredSubject                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 staminaRecoverySubject                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ItemListInfo
    {
        public GameObject?                              InfoObject                              { get; set; }
        public RewardItem?                              ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       ItemName                                { get; set; }
        public UITextMeshProUGUI?                       ItemDescription                         { get; set; }
        public UITextMeshProUGUI?                       ExpireText                              { get; set; }
        public UIButton?                                ExpireButton                            { get; set; }
        public UIButton?                                UseButton                               { get; set; }
        public UITextMeshProUGUI?                       UseButtonText                           { get; set; }
        public IHavingProductStatus?                    Product                                 { get; set; }
        public Action?                                  UseAction                               { get; set; }
        public bool                                     IsJump                                  { get; set; }

        public static ItemListInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListInfo();

            value.InfoObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BC1490 0x20 InfoObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D4BC14B0 0x28 ItemIcon                    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ItemName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BC14D0 0x30 ItemName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemDescription                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BC14F0 0x38 ItemDescription             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BC1510 0x40 ExpireText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireButton                              = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270D4BC1530 0x48 ExpireButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UseButton                                 = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270D4BC1550 0x50 UseButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UseButtonText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4BC1570 0x58 UseButtonText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Product                                   = GetObject<IHavingProductStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270D4BC1590 0x60 Product                     ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.UseAction                                 = GetObject<Action>(new IntPtr(p + 0x068), ReversePrism.DataModels.Action.FromPointer); // 0270D4BC15B0 0x68 UseAction                   ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.IsJump                                    = GetBool(new IntPtr(p + 0x070)); // 0270D4BC15D0 0x70 IsJump                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
