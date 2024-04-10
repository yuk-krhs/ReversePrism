using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 FixedFilterCellViewPrefab                000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 030 SupportEffectTitleCellViewPrefab         000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 038 SupportEffectFoldCellViewPrefab          000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 040 SupportEffectCellViewPrefab              000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 048 Context                                  0001865E2150 ModelClassType SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel Pointer
    // 050 CellVMAry                                000185B89AD0 ModelClassListType ISupportCharaSearchPopupCellViewModel[] ISupportCharaSearchPopupCellViewModel[] List<ISupportCharaSearchPopupCellViewModel> Pointer
    public partial class SupportCharaFilterCellListView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public EnhancedScrollerCellView?                FixedFilterCellViewPrefab               { get; set; }
        public EnhancedScrollerCellView?                SupportEffectTitleCellViewPrefab        { get; set; }
        public EnhancedScrollerCellView?                SupportEffectFoldCellViewPrefab         { get; set; }
        public EnhancedScrollerCellView?                SupportEffectCellViewPrefab             { get; set; }
        public SupportCharaSearchPopupViewModel?        Context                                 { get; set; }
        public List<ISupportCharaSearchPopupCellViewModel>? CellVMAry                               { get; set; }

        public static SupportCharaFilterCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaFilterCellListView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 02466A3A3C78 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.FixedFilterCellViewPrefab                 = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 02466A3A3C98 0x28 FixedFilterCellViewPrefab   ( 000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.SupportEffectTitleCellViewPrefab          = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 02466A3A3CB8 0x30 SupportEffectTitleCellViewPrefab ( 000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.SupportEffectFoldCellViewPrefab           = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x038), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 02466A3A3CD8 0x38 SupportEffectFoldCellViewPrefab ( 000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.SupportEffectCellViewPrefab               = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x040), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 02466A3A3CF8 0x40 SupportEffectCellViewPrefab ( 000186735AD0 ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.Context                                   = GetObject<SupportCharaSearchPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportCharaSearchPopupViewModel.FromPointer); // 02466A3A3D18 0x48 Context                     ( 0001865E2150 ModelClassType SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel Pointer )
            value.CellVMAry                                 = GetObjectList<ISupportCharaSearchPopupCellViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISupportCharaSearchPopupCellViewModel.FromPointer); // 02466A3A3D38 0x50 CellVMAry                   ( 000185B89AD0 ModelClassListType ISupportCharaSearchPopupCellViewModel[] ISupportCharaSearchPopupCellViewModel[] List<ISupportCharaSearchPopupCellViewModel> Pointer )

            return value;
        }
    }
}
