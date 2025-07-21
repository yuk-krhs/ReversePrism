using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitListView                             ModelClassType ChallengeTourUnitListView ChallengeTourUnitListView ChallengeTourUnitListView Pointer
    // 028 StageListView                            ModelClassType ChallengeTourStageListView ChallengeTourStageListView ChallengeTourStageListView Pointer
    // 030 UnitView                                 ModelClassType ChallengeTourUnitView ChallengeTourUnitView ChallengeTourUnitView Pointer
    // 038 ArrivalStagePanelView                    ModelClassType ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView Pointer
    // 040 FilterView                               ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 048 ViewModel                                ModelClassType ChallengeTourTopViewModel ChallengeTourTopViewModel ChallengeTourTopViewModel Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ChallengeTourTopView : DataModel
    {
        public ChallengeTourUnitListView?               UnitListView                            { get; set; }
        public ChallengeTourStageListView?              StageListView                           { get; set; }
        public ChallengeTourUnitView?                   UnitView                                { get; set; }
        public ChallengeTourArrivalStagePanelView?      ArrivalStagePanelView                   { get; set; }
        public FilterAndSortView?                       FilterView                              { get; set; }
        public ChallengeTourTopViewModel?               ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChallengeTourTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourTopView() { Pointer= p0 };

            value.UnitListView                              = GetObject<ChallengeTourUnitListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitListView.FromPointer); // 0x20 UnitListView                ( ModelClassType ChallengeTourUnitListView ChallengeTourUnitListView ChallengeTourUnitListView Pointer )
            value.StageListView                             = GetObject<ChallengeTourStageListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourStageListView.FromPointer); // 0x28 StageListView               ( ModelClassType ChallengeTourStageListView ChallengeTourStageListView ChallengeTourStageListView Pointer )
            value.UnitView                                  = GetObject<ChallengeTourUnitView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourUnitView.FromPointer); // 0x30 UnitView                    ( ModelClassType ChallengeTourUnitView ChallengeTourUnitView ChallengeTourUnitView Pointer )
            value.ArrivalStagePanelView                     = GetObject<ChallengeTourArrivalStagePanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourArrivalStagePanelView.FromPointer); // 0x38 ArrivalStagePanelView       ( ModelClassType ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView ChallengeTourArrivalStagePanelView Pointer )
            value.FilterView                                = GetObject<FilterAndSortView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x40 FilterView                  ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourTopViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeTourTopViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType ChallengeTourTopViewModel ChallengeTourTopViewModel ChallengeTourTopViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
