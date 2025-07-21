using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FavoriteIdolDrawType                     ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32
    // 014 ApplyFavoriteIdolDrawType                ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32
    // 018 IdolIconViewModels                       ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer
    // 020 ApplyIdolIconViewModels                  ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer
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

            value.FavoriteIdolDrawType                      = (HomeSettingFavoriteIdolDrawType)GetInt32(new IntPtr(p + 0x010)); // 0x10 FavoriteIdolDrawType        ( ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32 )
            value.ApplyFavoriteIdolDrawType                 = (HomeSettingFavoriteIdolDrawType)GetInt32(new IntPtr(p + 0x014)); // 0x14 ApplyFavoriteIdolDrawType   ( ModelEnumType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType HomeSettingFavoriteIdolDrawType Int32 )
            value.IdolIconViewModels                        = GetObjectList<HomeSettingsIdolIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeSettingsIdolIconViewModel.FromPointer); // 0x18 IdolIconViewModels          ( ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer )
            value.ApplyIdolIconViewModels                   = GetObjectList<HomeSettingsIdolIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSettingsIdolIconViewModel.FromPointer); // 0x20 ApplyIdolIconViewModels     ( ModelClassListType HomeSettingsIdolIconViewModel[] HomeSettingsIdolIconViewModel[] List<HomeSettingsIdolIconViewModel> Pointer )

            return value;
        }
    }
}
