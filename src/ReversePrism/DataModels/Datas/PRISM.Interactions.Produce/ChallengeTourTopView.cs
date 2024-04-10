using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitListView                             00018658BBD0 ModelClassType ChallengeTourUnitListView ChallengeTourUnitListView ChallengeTourUnitListView Pointer
    // 028 StageListView                            0001865827E0 ModelClassType ChallengeTourStageListView ChallengeTourStageListView ChallengeTourStageListView Pointer
    // 030 UnitView                                 00018658D350 ModelClassType ChallengeTourUnitView ChallengeTourUnitView ChallengeTourUnitView Pointer
    // 038 ArrivalStagePanelView                    00018656CF00 ModelClassType ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView Pointer
    // 040 FilterView                               000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 048 stageFilterPopupFactory                  PopupViewFactory`1<IChallengeTourStageFilterPopupView> IL2CPP_TYPE_GENERICINST
    // 050 stageDetailOverlayFactory                OverlayViewFactory`1<IChallengeTourStageDetailOverlayView> IL2CPP_TYPE_GENERICINST
    // 058 ViewModel                                000186588590 ModelClassType ChallengeTourTopViewModel ChallengeTourTopViewModel ChallengeTourTopViewModel Pointer
    // 060 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ChallengeTourTopView : DataModel
    {
        public ChallengeTourUnitListView?               UnitListView                            { get; set; }
        public ChallengeTourStageListView?              StageListView                           { get; set; }
        public ChallengeTourUnitView?                   UnitView                                { get; set; }
        public ChallengeTourArrivalStagePanelView?      ArrivalStagePanelView                   { get; set; }
        public FilterAndSortView?                       FilterView                              { get; set; }
        public ChallengeTourTopViewModel?               ViewModel                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChallengeTourTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourTopView() { Pointer= p0 };

            value.UnitListView                              = GetObject<ChallengeTourUnitListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitListView.FromPointer); // 02466A238610 0x20 UnitListView                ( 00018658BBD0 ModelClassType ChallengeTourUnitListView ChallengeTourUnitListView ChallengeTourUnitListView Pointer )
            value.StageListView                             = GetObject<ChallengeTourStageListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourStageListView.FromPointer); // 02466A238630 0x28 StageListView               ( 0001865827E0 ModelClassType ChallengeTourStageListView ChallengeTourStageListView ChallengeTourStageListView Pointer )
            value.UnitView                                  = GetObject<ChallengeTourUnitView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourUnitView.FromPointer); // 02466A238650 0x30 UnitView                    ( 00018658D350 ModelClassType ChallengeTourUnitView ChallengeTourUnitView ChallengeTourUnitView Pointer )
            value.ArrivalStagePanelView                     = GetObject<ChallengeTourArrivalStagePanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourArrivalStagePanelView.FromPointer); // 02466A238670 0x38 ArrivalStagePanelView       ( 00018656CF00 ModelClassType ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView Pointer )
            value.FilterView                                = GetObject<FilterAndSortView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 02466A238690 0x40 FilterView                  ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourTopViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ChallengeTourTopViewModel.FromPointer); // 02466A2386F0 0x58 ViewModel                   ( 000186588590 ModelClassType ChallengeTourTopViewModel ChallengeTourTopViewModel ChallengeTourTopViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A238710 0x60 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
