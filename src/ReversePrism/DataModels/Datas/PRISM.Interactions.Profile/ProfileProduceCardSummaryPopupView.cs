using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModels                               ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileProduceCardSummaryPopupView : DataModel
    {
        public ProfileProduceCardSummaryListView?       ListView                                { get; set; }
        public List<ProfileProduceCardSummaryViewModel>? ViewModels                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileProduceCardSummaryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProduceCardSummaryPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<ProfileProduceCardSummaryListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileProduceCardSummaryListView.FromPointer); // 0x20 ListView                    ( ModelClassType ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView ProfileProduceCardSummaryListView Pointer )
            value.ViewModels                                = GetObjectList<ProfileProduceCardSummaryViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileProduceCardSummaryViewModel.FromPointer); // 0x30 ViewModels                  ( ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
