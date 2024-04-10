using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteIdolDrawType                     0001865FC860 ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32
    // 014 ApplyFavoriteIdolDrawType                0001865FC860 ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32
    // 018 IdolIconViewModels                       000185B853E0 ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer
    // 020 ApplyIdolIconViewModels                  000185B853E0 ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer
    public partial class HomeSettingsViewModel : DataModel
    {
        public HomeSettingFavoriteIdolDrawType          FavoriteIdolDrawType                    { get; set; }
        public HomeSettingFavoriteIdolDrawType          ApplyFavoriteIdolDrawType               { get; set; }
        public List<HomeSettingsIdolIconViewModel>?     IdolIconViewModels                      { get; set; }
        public List<HomeSettingsIdolIconViewModel>?     ApplyIdolIconViewModels                 { get; set; }

        public static HomeSettingsViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsViewModel() { Pointer= p0 };

            value.FavoriteIdolDrawType                      = (HomeSettingFavoriteIdolDrawType)GetInt32(new IntPtr(p + 0x010)); // 0245A3664FD8 0x10 FavoriteIdolDrawType        ( 0001865FC860 ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32 )
            value.ApplyFavoriteIdolDrawType                 = (HomeSettingFavoriteIdolDrawType)GetInt32(new IntPtr(p + 0x014)); // 0245A3664FF8 0x14 ApplyFavoriteIdolDrawType   ( 0001865FC860 ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32 )
            value.IdolIconViewModels                        = GetObjectList<HomeSettingsIdolIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeSettingsIdolIconViewModel.FromPointer); // 0245A3665018 0x18 IdolIconViewModels          ( 000185B853E0 ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer )
            value.ApplyIdolIconViewModels                   = GetObjectList<HomeSettingsIdolIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSettingsIdolIconViewModel.FromPointer); // 0245A3665038 0x20 ApplyIdolIconViewModels     ( 000185B853E0 ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer )

            return value;
        }
    }
}
