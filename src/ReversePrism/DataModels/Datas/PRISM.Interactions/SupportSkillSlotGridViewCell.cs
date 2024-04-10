using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SlotObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 SlotNumberText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 SlotBlankObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 SlotBlankNumberText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 SkillSlotBaseObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 SkillSlotEffectNameText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 SkillSlotEffectDescriptionText           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 SkillSlotIconImage                       0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 InheritanceObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 SkillSlotBaseBlankObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SupportSkillSlotGridViewCell : DataModel
    {
        public GameObject?                              SlotObject                              { get; set; }
        public UITextMeshProUGUI?                       SlotNumberText                          { get; set; }
        public GameObject?                              SlotBlankObject                         { get; set; }
        public UITextMeshProUGUI?                       SlotBlankNumberText                     { get; set; }
        public GameObject?                              SkillSlotBaseObject                     { get; set; }
        public UITextMeshProUGUI?                       SkillSlotEffectNameText                 { get; set; }
        public UITextMeshProUGUI?                       SkillSlotEffectDescriptionText          { get; set; }
        public UIRawImage?                              SkillSlotIconImage                      { get; set; }
        public GameObject?                              InheritanceObject                       { get; set; }
        public GameObject?                              SkillSlotBaseBlankObject                { get; set; }

        public static SupportSkillSlotGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillSlotGridViewCell() { Pointer= p0 };

            value.SlotObject                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A158250 0x40 SlotObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SlotNumberText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158270 0x48 SlotNumberText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SlotBlankObject                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466A158290 0x50 SlotBlankObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SlotBlankNumberText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1582B0 0x58 SlotBlankNumberText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillSlotBaseObject                       = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466A1582D0 0x60 SkillSlotBaseObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillSlotEffectNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A1582F0 0x68 SkillSlotEffectNameText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillSlotEffectDescriptionText            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A158310 0x70 SkillSlotEffectDescriptionText ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillSlotIconImage                        = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A158330 0x78 SkillSlotIconImage          ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.InheritanceObject                         = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466A158350 0x80 InheritanceObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillSlotBaseBlankObject                  = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466A158370 0x88 SkillSlotBaseBlankObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
