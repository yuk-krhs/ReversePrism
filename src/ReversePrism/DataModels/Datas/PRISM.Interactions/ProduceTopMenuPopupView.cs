using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScenarioNameAndDifficultyText            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 HelpButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 LogButton                                ModelClassType UIButton UIButton UIButton Pointer
    // 038 BackToHomeButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 040 GiveUpButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 048 ProduceOptionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 050 SystemOptionButton                       ModelClassType UIButton UIButton UIButton Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceTopMenuPopupView : DataModel
    {
        public UITextMeshProUGUI?                       ScenarioNameAndDifficultyText           { get; set; }
        public UIButton?                                HelpButton                              { get; set; }
        public UIButton?                                LogButton                               { get; set; }
        public UIButton?                                BackToHomeButton                        { get; set; }
        public UIButton?                                GiveUpButton                            { get; set; }
        public UIButton?                                ProduceOptionButton                     { get; set; }
        public UIButton?                                SystemOptionButton                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceTopMenuPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopMenuPopupView() { Pointer= p0 };

            value.ScenarioNameAndDifficultyText             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ScenarioNameAndDifficultyText ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 HelpButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LogButton                                 = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 LogButton                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BackToHomeButton                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BackToHomeButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GiveUpButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 GiveUpButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceOptionButton                       = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 ProduceOptionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SystemOptionButton                        = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 SystemOptionButton          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
