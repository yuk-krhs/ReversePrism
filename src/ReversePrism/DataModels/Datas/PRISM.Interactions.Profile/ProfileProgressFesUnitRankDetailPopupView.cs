using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResourceTagName                          string IL2CPP_TYPE_STRING
    // 020 ListView                                 0001865BE850 ModelClassType ProfileProgressFesUnitRankDetailListView ProfileProgressFesUnitRankDetailListView ProfileProgressFesUnitRankDetailListView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                0001865BFD40 ModelClassType ProfileProgressPanelViewModel ProfileProgressPanelViewModel ProfileProgressPanelViewModel Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileProgressFesUnitRankDetailPopupView
    {
        public ProfileProgressFesUnitRankDetailListView? ListView                                { get; set; }
        public ProfileProgressPanelViewModel?           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileProgressFesUnitRankDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressFesUnitRankDetailPopupView();

            value.ListView                                  = GetObject<ProfileProgressFesUnitRankDetailListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileProgressFesUnitRankDetailListView.FromPointer); // 0270DB71C3E0 0x20 ListView                    ( 0001865BE850 ModelClassType ProfileProgressFesUnitRankDetailListView ProfileProgressFesUnitRankDetailListView ProfileProgressFesUnitRankDetailListView Pointer )
            value.ViewModel                                 = GetObject<ProfileProgressPanelViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileProgressPanelViewModel.FromPointer); // 0270DB71C420 0x30 ViewModel                   ( 0001865BFD40 ModelClassType ProfileProgressPanelViewModel ProfileProgressPanelViewModel ProfileProgressPanelViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB71C440 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
