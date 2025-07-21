using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 FixedFilterCellViewPrefab                ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 030 SupportEffectTitleCellViewPrefab         ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 038 SupportEffectFoldCellViewPrefab          ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 040 SupportEffectCellViewPrefab              ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer
    // 048 Context                                  ModelClassType SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel Pointer
    // 050 CellVMAry                                ModelClassListType ISupportCharaSearchPopupCellViewModel[] ISupportCharaSearchPopupCellViewModel[] List<ISupportCharaSearchPopupCellViewModel> Pointer
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

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.FixedFilterCellViewPrefab                 = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x28 FixedFilterCellViewPrefab   ( ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.SupportEffectTitleCellViewPrefab          = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x30 SupportEffectTitleCellViewPrefab ( ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.SupportEffectFoldCellViewPrefab           = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x038), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x38 SupportEffectFoldCellViewPrefab ( ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.SupportEffectCellViewPrefab               = GetObject<EnhancedScrollerCellView>(new IntPtr(p + 0x040), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x40 SupportEffectCellViewPrefab ( ModelClassType EnhancedScrollerCellView EnhancedScrollerCellView EnhancedScrollerCellView Pointer )
            value.Context                                   = GetObject<SupportCharaSearchPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportCharaSearchPopupViewModel.FromPointer); // 0x48 Context                     ( ModelClassType SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel SupportCharaSearchPopupViewModel Pointer )
            value.CellVMAry                                 = GetObjectList<ISupportCharaSearchPopupCellViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISupportCharaSearchPopupCellViewModel.FromPointer); // 0x50 CellVMAry                   ( ModelClassListType ISupportCharaSearchPopupCellViewModel[] ISupportCharaSearchPopupCellViewModel[] List<ISupportCharaSearchPopupCellViewModel> Pointer )

            return value;
        }
    }
}
