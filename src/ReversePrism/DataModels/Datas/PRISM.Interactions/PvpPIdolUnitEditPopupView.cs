using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PIdolUnitPanelViews                      ModelClassListType PvpPIdolUnitPanelView[] PvpPIdolUnitPanelView[] List<PvpPIdolUnitPanelView> Pointer
    // 028 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 onCancel                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 onLongPressPIdol                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 PIdolViewModels                          ModelClassListType PvpPIdolUnitViewModel[] PvpPIdolUnitViewModel[] List<PvpPIdolUnitViewModel> Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PvpPIdolUnitEditPopupView : DataModel
    {
        public List<PvpPIdolUnitPanelView>?             PIdolUnitPanelViews                     { get; set; }
        public List<PvpPIdolUnitViewModel>?             PIdolViewModels                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PvpPIdolUnitEditPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPIdolUnitEditPopupView() { Pointer= p0 };

            value.PIdolUnitPanelViews                       = GetObjectList<PvpPIdolUnitPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPIdolUnitPanelView.FromPointer); // 0x20 PIdolUnitPanelViews         ( ModelClassListType PvpPIdolUnitPanelView[] PvpPIdolUnitPanelView[] List<PvpPIdolUnitPanelView> Pointer )
            value.PIdolViewModels                           = GetObjectList<PvpPIdolUnitViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.PvpPIdolUnitViewModel.FromPointer); // 0x48 PIdolViewModels             ( ModelClassListType PvpPIdolUnitViewModel[] PvpPIdolUnitViewModel[] List<PvpPIdolUnitViewModel> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
