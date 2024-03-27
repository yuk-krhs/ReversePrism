using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CatetoryTabViewModels                    000185B9E2F0 ModelClassListType ProfileCategoryTabViewModel[] ProfileCategoryTabViewModel[] List<ProfileCategoryTabViewModel> Pointer
    // 018 UserSelfPanelViewModel                   0001865C7B80 ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer
    // 020 ProgressPanelViewModel                   0001865BFD40 ModelClassType ProfileProgressPanelViewModel ProfileProgressPanelViewModel ProfileProgressPanelViewModel Pointer
    // 028 HistoryPanelViewModel                    0001865BA940 ModelClassType ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel Pointer
    // 030 PIdols                                   000185B9CEF0 ModelClassListType ProduceIdol[] ProduceIdol[] List<ProduceIdol> Pointer
    public partial class ProfileUserSalfViewModel
    {
        public List<ProfileCategoryTabViewModel>?       CatetoryTabViewModels                   { get; set; }
        public ProfileUserSelfPanelViewModel?           UserSelfPanelViewModel                  { get; set; }
        public ProfileProgressPanelViewModel?           ProgressPanelViewModel                  { get; set; }
        public ProfileHistoryPanelViewModel?            HistoryPanelViewModel                   { get; set; }
        public List<ProduceIdol>?                       PIdols                                  { get; set; }

        public static ProfileUserSalfViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileUserSalfViewModel();

            value.CatetoryTabViewModels                     = GetObjectList<ProfileCategoryTabViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfileCategoryTabViewModel.FromPointer); // 0270D6670060 0x10 CatetoryTabViewModels       ( 000185B9E2F0 ModelClassListType ProfileCategoryTabViewModel[] ProfileCategoryTabViewModel[] List<ProfileCategoryTabViewModel> Pointer )
            value.UserSelfPanelViewModel                    = GetObject<ProfileUserSelfPanelViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileUserSelfPanelViewModel.FromPointer); // 0270D6670080 0x18 UserSelfPanelViewModel      ( 0001865C7B80 ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer )
            value.ProgressPanelViewModel                    = GetObject<ProfileProgressPanelViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileProgressPanelViewModel.FromPointer); // 0270D66700A0 0x20 ProgressPanelViewModel      ( 0001865BFD40 ModelClassType ProfileProgressPanelViewModel ProfileProgressPanelViewModel ProfileProgressPanelViewModel Pointer )
            value.HistoryPanelViewModel                     = GetObject<ProfileHistoryPanelViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileHistoryPanelViewModel.FromPointer); // 0270D66700C0 0x28 HistoryPanelViewModel       ( 0001865BA940 ModelClassType ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel Pointer )
            value.PIdols                                    = GetObjectList<ProduceIdol>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0270D66700E0 0x30 PIdols                      ( 000185B9CEF0 ModelClassListType ProduceIdol[] ProduceIdol[] List<ProduceIdol> Pointer )

            return value;
        }
    }
}
