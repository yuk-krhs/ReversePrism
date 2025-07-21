using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterIconModelList                   ModelClassListType List`1<HomeSettingsIdolIconViewModel> List`1<HomeSettingsIdolIconViewModel> List<HomeSettingsIdolIconViewModel> Pointer
    public partial class HomeSettingsIdolSelectViewModel : DataModel
    {
        public List<HomeSettingsIdolIconViewModel>?     CharacterIconModelList                  { get; set; }

        public static HomeSettingsIdolSelectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolSelectViewModel() { Pointer= p0 };

            value.CharacterIconModelList                    = GetObjectList<HomeSettingsIdolIconViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeSettingsIdolIconViewModel.FromPointer); // 0x10 CharacterIconModelList      ( ModelClassListType List`1<HomeSettingsIdolIconViewModel> List`1<HomeSettingsIdolIconViewModel> List<HomeSettingsIdolIconViewModel> Pointer )

            return value;
        }
    }
}
