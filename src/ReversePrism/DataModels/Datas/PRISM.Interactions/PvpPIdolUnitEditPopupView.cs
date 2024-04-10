using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PIdolUnitPanelViews                      000185C9F688 ModelClassListType PvpPIdolUnitPanelView[] PvpPIdolUnitPanelView[] List<PvpPIdolUnitPanelView> Pointer
    // 028 pIdolDetailPopupFactory                  PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 030 pIdolSelectPopupFactory                  PopupViewFactory`1<IPvpPIdolSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 038 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onCancel                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onClickPIdol                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 onLongPressPIdol                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 PIdolViewModels                          000185C9F858 ModelClassListType PvpPIdolUnitViewModel[] PvpPIdolUnitViewModel[] List<PvpPIdolUnitViewModel> Pointer
    // 060 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PvpPIdolUnitEditPopupView : DataModel
    {
        public List<PvpPIdolUnitPanelView>?             PIdolUnitPanelViews                     { get; set; }
        public List<PvpPIdolUnitViewModel>?             PIdolViewModels                         { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PvpPIdolUnitEditPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPIdolUnitEditPopupView() { Pointer= p0 };

            value.PIdolUnitPanelViews                       = GetObjectList<PvpPIdolUnitPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPIdolUnitPanelView.FromPointer); // 02466A1A42B0 0x20 PIdolUnitPanelViews         ( 000185C9F688 ModelClassListType PvpPIdolUnitPanelView[] PvpPIdolUnitPanelView[] List<PvpPIdolUnitPanelView> Pointer )
            value.PIdolViewModels                           = GetObjectList<PvpPIdolUnitViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.PvpPIdolUnitViewModel.FromPointer); // 02466A1A4390 0x58 PIdolViewModels             ( 000185C9F858 ModelClassListType PvpPIdolUnitViewModel[] PvpPIdolUnitViewModel[] List<PvpPIdolUnitViewModel> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A1A43B0 0x60 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A1A43D0 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
