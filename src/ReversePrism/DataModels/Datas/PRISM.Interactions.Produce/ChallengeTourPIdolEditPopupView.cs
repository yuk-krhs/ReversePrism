using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PIdolUnitPanelViews                      ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer
    // 028 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 onClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 onLongPressPIdol                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 PIdolViewModels                          ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer
    // 048 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourPIdolEditPopupView : DataModel
    {
        public List<ChallengeTourPIdolUnitPanelView>?   PIdolUnitPanelViews                     { get; set; }
        public List<ChallengeTourPIdolUnitViewModel>?   PIdolViewModels                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourPIdolEditPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolEditPopupView() { Pointer= p0 };

            value.PIdolUnitPanelViews                       = GetObjectList<ChallengeTourPIdolUnitPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourPIdolUnitPanelView.FromPointer); // 0x20 PIdolUnitPanelViews         ( ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer )
            value.PIdolViewModels                           = GetObjectList<ChallengeTourPIdolUnitViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChallengeTourPIdolUnitViewModel.FromPointer); // 0x40 PIdolViewModels             ( ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x48 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
