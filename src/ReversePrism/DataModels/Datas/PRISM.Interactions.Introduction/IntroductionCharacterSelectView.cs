using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView Pointer
    // 028 UiCharacterView                          ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer
    // 030 ViewModel                                ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer
    // 038 onSelected                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IntroductionCharacterSelectView : DataModel
    {
        public IntroductionCharacterSelectGridView?     GridView                                { get; set; }
        public IntroductionUICharacterView?             UiCharacterView                         { get; set; }
        public IntroductionCharacterSelectViewModel?    ViewModel                               { get; set; }

        public static IntroductionCharacterSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectView() { Pointer= p0 };

            value.GridView                                  = GetObject<IntroductionCharacterSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionCharacterSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView Pointer )
            value.UiCharacterView                           = GetObject<IntroductionUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IntroductionUICharacterView.FromPointer); // 0x28 UiCharacterView             ( ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer )
            value.ViewModel                                 = GetObject<IntroductionCharacterSelectViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntroductionCharacterSelectViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer )

            return value;
        }
    }
}
