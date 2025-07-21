using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundView                           ModelClassType IntroductionRewardBackgroundView IntroductionRewardBackgroundView IntroductionRewardBackgroundView Pointer
    // 028 PanelView                                ModelClassType IntroductionRewardPanelView IntroductionRewardPanelView IntroductionRewardPanelView Pointer
    // 030 UiCharacterView                          ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer
    // 038 WindowTapButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 040 ViewModel                                ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer
    // 048 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 050 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class IntroductionRewardView : DataModel
    {
        public IntroductionRewardBackgroundView?        BackgroundView                          { get; set; }
        public IntroductionRewardPanelView?             PanelView                               { get; set; }
        public IntroductionUICharacterView?             UiCharacterView                         { get; set; }
        public UIButton?                                WindowTapButton                         { get; set; }
        public IntroductionViewModel?                   ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static IntroductionRewardView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionRewardView() { Pointer= p0 };

            value.BackgroundView                            = GetObject<IntroductionRewardBackgroundView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionRewardBackgroundView.FromPointer); // 0x20 BackgroundView              ( ModelClassType IntroductionRewardBackgroundView IntroductionRewardBackgroundView IntroductionRewardBackgroundView Pointer )
            value.PanelView                                 = GetObject<IntroductionRewardPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IntroductionRewardPanelView.FromPointer); // 0x28 PanelView                   ( ModelClassType IntroductionRewardPanelView IntroductionRewardPanelView IntroductionRewardPanelView Pointer )
            value.UiCharacterView                           = GetObject<IntroductionUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntroductionUICharacterView.FromPointer); // 0x30 UiCharacterView             ( ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer )
            value.WindowTapButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 WindowTapButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<IntroductionViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IntroductionViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x48 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
