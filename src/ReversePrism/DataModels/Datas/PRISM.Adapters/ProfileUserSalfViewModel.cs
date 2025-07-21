using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CatetoryTabViewModels                    ModelClassListType ProfileCategoryTabViewModel[] ProfileCategoryTabViewModel[] List<ProfileCategoryTabViewModel> Pointer
    // 018 UserSelfPanelViewModel                   ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer
    // 020 ProgressPanelViewModel                   ModelClassType ProfileProgressPanelViewModel ProfileProgressPanelViewModel ProfileProgressPanelViewModel Pointer
    // 028 HistoryPanelViewModel                    ModelClassType ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel Pointer
    // 030 PIdols                                   ModelClassListType ProduceIdol[] ProduceIdol[] List<ProduceIdol> Pointer
    public partial class ProfileUserSalfViewModel : DataModel
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
            var value   = new ProfileUserSalfViewModel() { Pointer= p0 };

            value.CatetoryTabViewModels                     = GetObjectList<ProfileCategoryTabViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfileCategoryTabViewModel.FromPointer); // 0x10 CatetoryTabViewModels       ( ModelClassListType ProfileCategoryTabViewModel[] ProfileCategoryTabViewModel[] List<ProfileCategoryTabViewModel> Pointer )
            value.UserSelfPanelViewModel                    = GetObject<ProfileUserSelfPanelViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileUserSelfPanelViewModel.FromPointer); // 0x18 UserSelfPanelViewModel      ( ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer )
            value.ProgressPanelViewModel                    = GetObject<ProfileProgressPanelViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileProgressPanelViewModel.FromPointer); // 0x20 ProgressPanelViewModel      ( ModelClassType ProfileProgressPanelViewModel ProfileProgressPanelViewModel ProfileProgressPanelViewModel Pointer )
            value.HistoryPanelViewModel                     = GetObject<ProfileHistoryPanelViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileHistoryPanelViewModel.FromPointer); // 0x28 HistoryPanelViewModel       ( ModelClassType ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel ProfileHistoryPanelViewModel Pointer )
            value.PIdols                                    = GetObjectList<ProduceIdol>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x30 PIdols                      ( ModelClassListType ProduceIdol[] ProduceIdol[] List<ProduceIdol> Pointer )

            return value;
        }
    }
}
