using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 RawImage                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 CostObj                                  ModelClassType GameObject GameObject GameObject Pointer
    // 038 CostText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 LevelText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 058 onRingIdolVoiceActivate                  Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 OnClickSerialDisposable                  ModelClassType SerialDisposable SerialDisposable SerialDisposable Pointer
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

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 RawImage                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CostObj                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 CostObj                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 CostText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LevelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 LevelText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0x50 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.OnClickSerialDisposable                   = GetObject<SerialDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.SerialDisposable.FromPointer); // 0x60 OnClickSerialDisposable     ( ModelClassType SerialDisposable SerialDisposable SerialDisposable Pointer )

            return value;
        }
    }
}
