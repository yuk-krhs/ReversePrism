using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 048 ItemNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 RecoveryTypeText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 RecoveryAmountText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ExpireDateObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 068 ExpireDateText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ItemAmountText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ItemAmountAfterText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 UseAmountText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ExpireRemineTimeObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 090 ExpireRemineTimeText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 ReplaceMeshTexts                         ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0A0 UseMinusButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 UsePlusButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 UseAmountDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B8 ExpireDisposable                         ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0C0 TimeRecoveryMaxDisposable                ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0C8 PlusButtonEnableDisposable               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StaminaRecoverySelectItemListViewCell : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UITextMeshProUGUI?                       RecoveryTypeText                        { get; set; }
        public UITextMeshProUGUI?                       RecoveryAmountText                      { get; set; }
        public GameObject?                              ExpireDateObject                        { get; set; }
        public UITextMeshProUGUI?                       ExpireDateText                          { get; set; }
        public UITextMeshProUGUI?                       ItemAmountText                          { get; set; }
        public UITextMeshProUGUI?                       ItemAmountAfterText                     { get; set; }
        public UITextMeshProUGUI?                       UseAmountText                           { get; set; }
        public GameObject?                              ExpireRemineTimeObject                  { get; set; }
        public UITextMeshProUGUI?                       ExpireRemineTimeText                    { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceMeshTexts                        { get; set; }
        public UIButton?                                UseMinusButton                          { get; set; }
        public UIButton?                                UsePlusButton                           { get; set; }
        public IDisposable?                             UseAmountDisposable                     { get; set; }
        public IDisposable?                             ExpireDisposable                        { get; set; }
        public IDisposable?                             TimeRecoveryMaxDisposable               { get; set; }
        public IDisposable?                             PlusButtonEnableDisposable              { get; set; }

        public static StaminaRecoverySelectItemListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectItemListViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x40 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 ItemNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryTypeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 RecoveryTypeText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryAmountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 RecoveryAmountText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireDateObject                          = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 ExpireDateObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 ExpireDateText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 ItemAmountText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountAfterText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 ItemAmountAfterText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UseAmountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 UseAmountText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireRemineTimeObject                    = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 ExpireRemineTimeObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireRemineTimeText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 ExpireRemineTimeText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplaceMeshTexts                          = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 ReplaceMeshTexts            ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.UseMinusButton                            = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0xA0 UseMinusButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UsePlusButton                             = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0xA8 UsePlusButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseAmountDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB0 UseAmountDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ExpireDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB8 ExpireDisposable            ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TimeRecoveryMaxDisposable                 = GetObject<IDisposable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xC0 TimeRecoveryMaxDisposable   ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.PlusButtonEnableDisposable                = GetObject<IDisposable>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xC8 PlusButtonEnableDisposable  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
