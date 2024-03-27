using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 RecoveryTypeText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RecoveryAmountText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ExpireDateObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ExpireDateText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ItemAmountText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ItemAmountAfterText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 UseAmountText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ExpireRemineTimeObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ExpireRemineTimeText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ReplaceMeshTexts                         000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 080 UseMinusButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 UsePlusButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 UseAmountDisposable                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 098 ExpireDisposable                         0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StaminaRecoverySelectListItem
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

        public static StaminaRecoverySelectListItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoverySelectListItem();

            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D56288B0 0x20 ItemIcon                    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56288D0 0x28 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryTypeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56288F0 0x30 RecoveryTypeText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RecoveryAmountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5628910 0x38 RecoveryAmountText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireDateObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5628930 0x40 ExpireDateObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5628950 0x48 ExpireDateText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5628970 0x50 ItemAmountText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemAmountAfterText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5628990 0x58 ItemAmountAfterText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UseAmountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56289B0 0x60 UseAmountText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireRemineTimeObject                    = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D56289D0 0x68 ExpireRemineTimeObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireRemineTimeText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D56289F0 0x70 ExpireRemineTimeText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ReplaceMeshTexts                          = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5628A10 0x78 ReplaceMeshTexts            ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.UseMinusButton                            = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5628A30 0x80 UseMinusButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UsePlusButton                             = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5628A50 0x88 UsePlusButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UseAmountDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5628A70 0x90 UseAmountDisposable         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ExpireDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5628A90 0x98 ExpireDisposable            ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
