using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaLogImage                          ModelClassType Image Image Image Pointer
    // 028 RecoveryTimeText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 StaminaText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 StaminaAfterText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ArrowObject                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 StaminaGaugeView                         ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer
    // 050 LiveBonusGaugeView                       ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer
    // 058 UseMinButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 060 UseMinusButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 068 UsePlusButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 070 UseMaxButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 078 StaminaInfoText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 StaminaLogoSprites                       ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 088 TimerDisposable                          ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 JewelDisposable                          ModelClassType IDisposable IDisposable IDisposable Pointer
    // 098 onUseMinus                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onUsePlus                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class StaminaRecoveryTypeItemPanelView : DataModel
    {
        public Image?                                   StaminaLogImage                         { get; set; }
        public UITextMeshProUGUI?                       RecoveryTimeText                        { get; set; }
        public UITextMeshProUGUI?                       StaminaText                             { get; set; }
        public UITextMeshProUGUI?                       StaminaAfterText                        { get; set; }
        public GameObject?                              ArrowObject                             { get; set; }
        public StaminaRecoveryGaugeView?                StaminaGaugeView                        { get; set; }
        public StaminaRecoveryGaugeView?                LiveBonusGaugeView                      { get; set; }
        public UIButton?                                UseMinButton                            { get; set; }
        public UIButton?                                UseMinusButton                          { get; set; }
        public UIButton?                                UsePlusButton                           { get; set; }
        public UIButton?                                UseMaxButton                            { get; set; }
        public UITextMeshProUGUI?                       StaminaInfoText                         { get; set; }
        public List<Sprite>?                            StaminaLogoSprites                      { get; set; }
        public IDisposable?                             TimerDisposable                         { get; set; }
        public IDisposable?                             JewelDisposable                         { get; set; }

        public static StaminaRecoveryTypeItemPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryTypeItemPanelView() { Pointer= p0 };

            value.StaminaLogImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 StaminaLogImage             ( ModelClassType Image Image Image Pointer )
            value.RecoveryTimeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 RecoveryTimeText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 StaminaText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaAfterText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 StaminaAfterText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArrowObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ArrowObject                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StaminaGaugeView                          = GetObject<StaminaRecoveryGaugeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.StaminaRecoveryGaugeView.FromPointer); // 0x48 StaminaGaugeView            ( ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer )
            value.LiveBonusGaugeView                        = GetObject<StaminaRecoveryGaugeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.StaminaRecoveryGaugeView.FromPointer); // 0x50 LiveBonusGaugeView          ( ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer )
            value.UseMinButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 UseMinButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseMinusButton                            = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 UseMinusButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UsePlusButton                             = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 UsePlusButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseMaxButton                              = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 UseMaxButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.StaminaInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 StaminaInfoText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaLogoSprites                        = GetObjectList<Sprite>(new IntPtr(p + 0x080), ReversePrism.DataModels.Sprite.FromPointer); // 0x80 StaminaLogoSprites          ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.TimerDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 TimerDisposable             ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.JewelDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 0x90 JewelDisposable             ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
