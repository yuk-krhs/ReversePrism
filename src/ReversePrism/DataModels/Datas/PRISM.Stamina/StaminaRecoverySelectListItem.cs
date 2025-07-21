using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ItemNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 RecoveryTypeText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RecoveryAmountText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ExpireDateObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 048 ExpireDateText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ItemAmountText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ItemAmountAfterText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 UseAmountText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ExpireRemineTimeObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 070 ExpireRemineTimeText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ReplaceMeshTexts                         ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 080 UseMinusButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 088 UsePlusButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 090 UseAmountDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 098 ExpireDisposable                         ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0A0 TimeRecoveryMaxDisposable                ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StaminaRecoverySelectListItem : DataModel
    {
        public RewardItem?                              ItemIcon                                { get; set; }
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

        public static StaminaRecoverySelectListItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectListItem() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 ItemIcon                    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ItemNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryTypeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 RecoveryTypeText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryAmountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 RecoveryAmountText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireDateObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ExpireDateObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 ExpireDateText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ItemAmountText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountAfterText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ItemAmountAfterText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UseAmountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 UseAmountText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireRemineTimeObject                    = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 ExpireRemineTimeObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireRemineTimeText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 ExpireRemineTimeText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplaceMeshTexts                          = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 ReplaceMeshTexts            ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.UseMinusButton                            = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 UseMinusButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UsePlusButton                             = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 UsePlusButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseAmountDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 0x90 UseAmountDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ExpireDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.IDisposable.FromPointer); // 0x98 ExpireDisposable            ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TimeRecoveryMaxDisposable                 = GetObject<IDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xA0 TimeRecoveryMaxDisposable   ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
