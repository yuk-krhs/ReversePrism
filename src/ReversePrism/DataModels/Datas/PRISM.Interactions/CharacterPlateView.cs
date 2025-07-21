using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 onTapPosition                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 030 instantiatedObjects                      Dictionary`2<int, CanvasGroup> IL2CPP_TYPE_GENERICINST
    // 038 CurrentDisplayObject                     ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
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

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CurrentDisplayObject                      = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CurrentDisplayObject        ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0x40 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
