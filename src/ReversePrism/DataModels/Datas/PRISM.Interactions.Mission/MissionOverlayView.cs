using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabListView                              ModelClassType MissionOverlayTabListView MissionOverlayTabListView MissionOverlayTabListView Pointer
    // 028 contentPanelViews                        SerializableInterface`1<IMissionOverlayContentPanelView>[] IL2CPP_TYPE_SZARRAY
    // 030 gaugeView                                SerializableInterface`1<IMissionGaugeView> IL2CPP_TYPE_GENERICINST
    // 038 eventMissionListPanelView                SerializableInterface`1<IMissionEventListPanelView> IL2CPP_TYPE_GENERICINST
    // 040 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 048 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 ViewModel                                ModelClassType MissionOverlayViewModel MissionOverlayViewModel MissionOverlayViewModel Pointer
    // 058 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 060 onClickTab                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 PanelViews                               ModelClassListType IMissionOverlayContentPanelView[] IMissionOverlayContentPanelView[] List<IMissionOverlayContentPanelView> Pointer
    // 070 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class MissionOverlayView : DataModel
    {
        public MissionOverlayTabListView?               TabListView                             { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public MissionOverlayViewModel?                 ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public List<IMissionOverlayContentPanelView>?   PanelViews                              { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static MissionOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionOverlayView() { Pointer= p0 };

            value.TabListView                               = GetObject<MissionOverlayTabListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MissionOverlayTabListView.FromPointer); // 0x20 TabListView                 ( ModelClassType MissionOverlayTabListView MissionOverlayTabListView MissionOverlayTabListView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x40 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ViewModel                                 = GetObject<MissionOverlayViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.MissionOverlayViewModel.FromPointer); // 0x50 ViewModel                   ( ModelClassType MissionOverlayViewModel MissionOverlayViewModel MissionOverlayViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x58 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.PanelViews                                = GetObjectList<IMissionOverlayContentPanelView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IMissionOverlayContentPanelView.FromPointer); // 0x68 PanelViews                  ( ModelClassListType IMissionOverlayContentPanelView[] IMissionOverlayContentPanelView[] List<IMissionOverlayContentPanelView> Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 0x70 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
