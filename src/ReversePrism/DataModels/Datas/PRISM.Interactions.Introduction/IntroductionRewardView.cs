using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceTagName                          string IL2CPP_TYPE_STRING
    // 020 BackgroundView                           000186728E70 ModelClassType IntroductionRewardBackgroundView IntroductionRewardBackgroundView IntroductionRewardBackgroundView Pointer
    // 028 PanelView                                00018672A1C0 ModelClassType IntroductionRewardPanelView IntroductionRewardPanelView IntroductionRewardPanelView Pointer
    // 030 UiCharacterView                          00018672CFB0 ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer
    // 038 WindowTapButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 ViewModel                                000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer
    // 048 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class IntroductionRewardView
    {
        public IntroductionRewardBackgroundView?        BackgroundView                          { get; set; }
        public IntroductionRewardPanelView?             PanelView                               { get; set; }
        public IntroductionUICharacterView?             UiCharacterView                         { get; set; }
        public UIButton?                                WindowTapButton                         { get; set; }
        public IntroductionViewModel?                   ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static IntroductionRewardView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionRewardView();

            value.BackgroundView                            = GetObject<IntroductionRewardBackgroundView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionRewardBackgroundView.FromPointer); // 0270DB61C9E8 0x20 BackgroundView              ( 000186728E70 ModelClassType IntroductionRewardBackgroundView IntroductionRewardBackgroundView IntroductionRewardBackgroundView Pointer )
            value.PanelView                                 = GetObject<IntroductionRewardPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IntroductionRewardPanelView.FromPointer); // 0270DB61CA08 0x28 PanelView                   ( 00018672A1C0 ModelClassType IntroductionRewardPanelView IntroductionRewardPanelView IntroductionRewardPanelView Pointer )
            value.UiCharacterView                           = GetObject<IntroductionUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntroductionUICharacterView.FromPointer); // 0270DB61CA28 0x30 UiCharacterView             ( 00018672CFB0 ModelClassType IntroductionUICharacterView IntroductionUICharacterView IntroductionUICharacterView Pointer )
            value.WindowTapButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB61CA48 0x38 WindowTapButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<IntroductionViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IntroductionViewModel.FromPointer); // 0270DB61CA68 0x40 ViewModel                   ( 000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB61CA88 0x48 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB61CAA8 0x50 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
