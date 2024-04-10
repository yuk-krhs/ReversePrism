using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 HowToPlayPopupResourceConfigRef          000186671E00 ModelPrimitiveType string string string String
    // 060 TitleView                                0001865E9EF0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 068 GlobalButton                             0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 TutorialSequence                         0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 078 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.HowToPlayPopupResourceConfigRef           = GetString(new IntPtr(p + 0x058)); // 0245A24F7990 0x58 HowToPlayPopupResourceConfigRef ( 000186671E00 ModelPrimitiveType string string string String )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0245A24F79B0 0x60 TitleView                   ( 0001865E9EF0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.GlobalButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0245A24F79D0 0x68 GlobalButton                ( 0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TutorialSequence                          = GetObject<ITutorialSequence>(new IntPtr(p + 0x070), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0245A24F79F0 0x70 TutorialSequence            ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A24F7A10 0x78 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
