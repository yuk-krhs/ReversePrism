using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CostumeIcon                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 CostumeName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CostumeDescription                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CostumeUnlockCondition                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TagParent                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 StageCostumeTag                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 CasualCostumeTag                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 CharacterExclusiveTagText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class CostumeDetailPopupView
    {
        public UIRawImage?                              CostumeIcon                             { get; set; }
        public UITextMeshProUGUI?                       CostumeName                             { get; set; }
        public UITextMeshProUGUI?                       CostumeDescription                      { get; set; }
        public UITextMeshProUGUI?                       CostumeUnlockCondition                  { get; set; }
        public RectTransform?                           TagParent                               { get; set; }
        public GameObject?                              StageCostumeTag                         { get; set; }
        public GameObject?                              CasualCostumeTag                        { get; set; }
        public UITextMeshProUGUI?                       CharacterExclusiveTagText               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static CostumeDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeDetailPopupView();

            value.CostumeIcon                               = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA2A7D00 0x20 CostumeIcon                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CostumeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A7D20 0x28 CostumeName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeDescription                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A7D40 0x30 CostumeDescription          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeUnlockCondition                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A7D60 0x38 CostumeUnlockCondition      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TagParent                                 = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA2A7D80 0x40 TagParent                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.StageCostumeTag                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA2A7DA0 0x48 StageCostumeTag             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CasualCostumeTag                          = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA2A7DC0 0x50 CasualCostumeTag            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterExclusiveTagText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A7DE0 0x58 CharacterExclusiveTagText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2A7E20 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
