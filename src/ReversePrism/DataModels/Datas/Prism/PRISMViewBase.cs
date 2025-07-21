using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 HowToPlayPopupResourceConfigRef          ModelPrimitiveType string string string String
    // 058 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 060 GlobalButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 TutorialSequence                         ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 070 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class PRISMViewBase : DataModel
    {
        public string                                   HowToPlayPopupResourceConfigRef         { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ButtonBase?                              GlobalButton                            { get; set; }
        public ITutorialSequence?                       TutorialSequence                        { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static PRISMViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMViewBase() { Pointer= p0 };

            value.HowToPlayPopupResourceConfigRef           = GetString(new IntPtr(p + 0x050)); // 0x50 HowToPlayPopupResourceConfigRef ( ModelPrimitiveType string string string String )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x58 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.GlobalButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 GlobalButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TutorialSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x068), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x68 TutorialSequence            ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 0x70 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
