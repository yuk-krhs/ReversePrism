using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 onTapPosition                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 030 instantiatedObjects                      Dictionary`2<int, CanvasGroup> IL2CPP_TYPE_GENERICINST
    // 038 CurrentDisplayObject                     000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class CharacterPlateView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public CanvasGroup?                             CurrentDisplayObject                    { get; set; }
        public CancellationToken                        Ct                                      { get; set; }

        public static CharacterPlateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterPlateView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466A283DB0 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CurrentDisplayObject                      = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A283E10 0x38 CurrentDisplayObject        ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 02466A283E30 0x40 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
