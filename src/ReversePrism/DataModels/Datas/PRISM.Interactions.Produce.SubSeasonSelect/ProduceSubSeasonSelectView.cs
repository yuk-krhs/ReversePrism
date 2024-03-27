using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onSelectSubseasonSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 028 SafeAreaRoot                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 ChoiceButtonRoot                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 Buttons                                  000185D17588 ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer
    // 040 ButtonTexts                              000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 048 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceSubSeasonSelectView
    {
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public GameObject?                              ChoiceButtonRoot                        { get; set; }
        public List<UIButton>?                          Buttons                                 { get; set; }
        public List<UITextMeshProUGUI>?                 ButtonTexts                             { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static ProduceSubSeasonSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectView();

            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA21F388 0x28 SafeAreaRoot                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ChoiceButtonRoot                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA21F3A8 0x30 ChoiceButtonRoot            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Buttons                                   = GetObjectList<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA21F3C8 0x38 Buttons                     ( 000185D17588 ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer )
            value.ButtonTexts                               = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA21F3E8 0x40 ButtonTexts                 ( 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA21F408 0x48 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
