using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 RawImage                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 CostObj                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 CostText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 LevelText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 058 onRingIdolVoiceActivate                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 OnClickSerialDisposable                  000186729E20 ModelClassType SerialDisposable SerialDisposable SerialDisposable Pointer
    public partial class IdolSkillIconView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public UIRawImage?                              RawImage                                { get; set; }
        public GameObject?                              CostObj                                 { get; set; }
        public UITextMeshProUGUI?                       CostText                                { get; set; }
        public UITextMeshProUGUI?                       LevelText                               { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public SerialDisposable?                        OnClickSerialDisposable                 { get; set; }

        public static IdolSkillIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillIconView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466549C248 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466549C268 0x28 RawImage                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CostObj                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466549C288 0x30 CostObj                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466549C2A8 0x38 CostText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LevelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466549C2C8 0x40 LevelText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 02466549C308 0x50 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.OnClickSerialDisposable                   = GetObject<SerialDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.SerialDisposable.FromPointer); // 02466549C348 0x60 OnClickSerialDisposable     ( 000186729E20 ModelClassType SerialDisposable SerialDisposable SerialDisposable Pointer )

            return value;
        }
    }
}
