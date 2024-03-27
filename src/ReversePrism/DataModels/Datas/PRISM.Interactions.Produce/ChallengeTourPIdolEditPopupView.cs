using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PIdolUnitPanelViews                      000185B74050 ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer
    // 028 pIdoleDetailPopupFactory                 PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 030 pIdoleSelectPopupFactory                 PopupViewFactory`1<IChallengeTourPIdolSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 038 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onCancel                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 onLongPressPIdol                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 PIdolViewModels                          000185B74250 ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer
    // 060 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourPIdolEditPopupView
    {
        public List<ChallengeTourPIdolUnitPanelView>?   PIdolUnitPanelViews                     { get; set; }
        public List<ChallengeTourPIdolUnitViewModel>?   PIdolViewModels                         { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourPIdolEditPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolEditPopupView();

            value.PIdolUnitPanelViews                       = GetObjectList<ChallengeTourPIdolUnitPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourPIdolUnitPanelView.FromPointer); // 0270DA1B6ED8 0x20 PIdolUnitPanelViews         ( 000185B74050 ModelClassListType ChallengeTourPIdolUnitPanelView[] ChallengeTourPIdolUnitPanelView[] List<ChallengeTourPIdolUnitPanelView> Pointer )
            value.PIdolViewModels                           = GetObjectList<ChallengeTourPIdolUnitViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ChallengeTourPIdolUnitViewModel.FromPointer); // 0270DA1B6FB8 0x58 PIdolViewModels             ( 000185B74250 ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA1B6FD8 0x60 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA1B6FF8 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
