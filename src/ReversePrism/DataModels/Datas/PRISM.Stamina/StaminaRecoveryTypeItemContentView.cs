using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StaminaLogImage                          0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 RecoveryTimeText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 StaminaText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 StaminaAfterText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ArrowObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 StaminaGaugeView                         0001865657F0 ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer
    // 050 LiveBonusGaugeView                       0001865657F0 ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer
    // 058 UseMinButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 UseMinusButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 UsePlusButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 UseMaxButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 StaminaInfoText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 StaminaLogoSprites                       000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 088 TimerDisposable                          0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 JewelDisposable                          0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class StaminaRecoveryTypeItemContentView
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

        public static StaminaRecoveryTypeItemContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryTypeItemContentView();

            value.StaminaLogImage                           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270D560DA10 0x20 StaminaLogImage             ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.RecoveryTimeText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D560DA30 0x28 RecoveryTimeText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D560DA50 0x30 StaminaText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaAfterText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D560DA70 0x38 StaminaAfterText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArrowObject                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D560DA90 0x40 ArrowObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StaminaGaugeView                          = GetObject<StaminaRecoveryGaugeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.StaminaRecoveryGaugeView.FromPointer); // 0270D560DAB0 0x48 StaminaGaugeView            ( 0001865657F0 ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer )
            value.LiveBonusGaugeView                        = GetObject<StaminaRecoveryGaugeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.StaminaRecoveryGaugeView.FromPointer); // 0270D560DAD0 0x50 LiveBonusGaugeView          ( 0001865657F0 ModelClassType StaminaRecoveryGaugeView StaminaRecoveryGaugeView StaminaRecoveryGaugeView Pointer )
            value.UseMinButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270D560DAF0 0x58 UseMinButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UseMinusButton                            = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270D560DB10 0x60 UseMinusButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UsePlusButton                             = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270D560DB30 0x68 UsePlusButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UseMaxButton                              = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270D560DB50 0x70 UseMaxButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.StaminaInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D560DB70 0x78 StaminaInfoText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StaminaLogoSprites                        = GetObjectList<Sprite>(new IntPtr(p + 0x080), ReversePrism.DataModels.Sprite.FromPointer); // 0270D560DB90 0x80 StaminaLogoSprites          ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.TimerDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D560DBB0 0x88 TimerDisposable             ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.JewelDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D560DBD0 0x90 JewelDisposable             ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
