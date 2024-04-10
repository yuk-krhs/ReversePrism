using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceTagName                          string IL2CPP_TYPE_STRING
    // 020 GridView                                 000186724AC0 ModelClassType IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView Pointer
    // 028 UiCharacterView                          00018672CFB0 ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer
    // 030 ViewModel                                000186725E60 ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer
    // 038 onSelected                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class IntroductionCharacterSelectView : DataModel
    {
        public IntroductionCharacterSelectGridView?     GridView                                { get; set; }
        public IntroductionUICharacterView?             UiCharacterView                         { get; set; }
        public IntroductionCharacterSelectViewModel?    ViewModel                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static IntroductionCharacterSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectView() { Pointer= p0 };

            value.GridView                                  = GetObject<IntroductionCharacterSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionCharacterSelectGridView.FromPointer); // 02466B6988C0 0x20 GridView                    ( 000186724AC0 ModelClassType IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView IntroductionCharacterSelectGridView Pointer )
            value.UiCharacterView                           = GetObject<IntroductionUICharacterView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IntroductionUICharacterView.FromPointer); // 02466B6988E0 0x28 UiCharacterView             ( 00018672CFB0 ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer )
            value.ViewModel                                 = GetObject<IntroductionCharacterSelectViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntroductionCharacterSelectViewModel.FromPointer); // 02466B698900 0x30 ViewModel                   ( 000186725E60 ModelClassType IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel IntroductionCharacterSelectViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B698940 0x40 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
