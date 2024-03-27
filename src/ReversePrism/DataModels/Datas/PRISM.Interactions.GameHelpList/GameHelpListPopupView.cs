using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CategoryCell                             0001865E8F10 ModelClassType GameHelpListCategoryCellView GameHelpListCategoryCellView GameHelpListCategoryCellView Pointer
    // 028 GetTextSizeView                          0001866704A0 ModelClassType GetTextSizeView GetTextSizeView GetTextSizeView Pointer
    // 030 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 ViewModel                                0001865EA360 ModelClassType GameHelpListViewModel GameHelpListViewModel GameHelpListViewModel Pointer
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GameHelpListPopupView
    {
        public GameHelpListCategoryCellView?            CategoryCell                            { get; set; }
        public GetTextSizeView?                         GetTextSizeView                         { get; set; }
        public EnhancedScroller?                        Scroller                                { get; set; }
        public GameHelpListViewModel?                   ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GameHelpListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameHelpListPopupView();

            value.CategoryCell                              = GetObject<GameHelpListCategoryCellView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameHelpListCategoryCellView.FromPointer); // 0270DB59BB28 0x20 CategoryCell                ( 0001865E8F10 ModelClassType GameHelpListCategoryCellView GameHelpListCategoryCellView GameHelpListCategoryCellView Pointer )
            value.GetTextSizeView                           = GetObject<GetTextSizeView>(new IntPtr(p + 0x028), ReversePrism.DataModels.GetTextSizeView.FromPointer); // 0270DB59BB48 0x28 GetTextSizeView             ( 0001866704A0 ModelClassType GetTextSizeView GetTextSizeView GetTextSizeView Pointer )
            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0270DB59BB68 0x30 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.ViewModel                                 = GetObject<GameHelpListViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameHelpListViewModel.FromPointer); // 0270DB59BBA8 0x40 ViewModel                   ( 0001865EA360 ModelClassType GameHelpListViewModel GameHelpListViewModel GameHelpListViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB59BBC8 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
