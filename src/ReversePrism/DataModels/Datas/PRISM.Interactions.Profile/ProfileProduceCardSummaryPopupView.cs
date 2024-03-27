using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 0001865BD960 ModelClassType ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModels                               000185B9E990 ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileProduceCardSummaryPopupView
    {
        public ProfileProduceCardSummaryListView?       ListView                                { get; set; }
        public List<ProfileProduceCardSummaryViewModel>? ViewModels                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileProduceCardSummaryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProduceCardSummaryPopupView();

            value.ListView                                  = GetObject<ProfileProduceCardSummaryListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileProduceCardSummaryListView.FromPointer); // 0270DB719B30 0x20 ListView                    ( 0001865BD960 ModelClassType ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView Pointer )
            value.ViewModels                                = GetObjectList<ProfileProduceCardSummaryViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileProduceCardSummaryViewModel.FromPointer); // 0270DB719B70 0x30 ViewModels                  ( 000185B9E990 ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB719B90 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
