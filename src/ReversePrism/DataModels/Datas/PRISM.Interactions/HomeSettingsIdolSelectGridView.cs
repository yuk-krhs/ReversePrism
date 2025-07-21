using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType HomeSettingsIdolSelectGridViewCell HomeSettingsIdolSelectGridViewCell HomeSettingsIdolSelectGridViewCell Pointer
    public partial class HomeSettingsIdolSelectGridView : DataModel
    {
        public HomeSettingsIdolSelectGridViewCell?      CellPrefab                              { get; set; }

        public static HomeSettingsIdolSelectGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolSelectGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<HomeSettingsIdolSelectGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.HomeSettingsIdolSelectGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType HomeSettingsIdolSelectGridViewCell HomeSettingsIdolSelectGridViewCell HomeSettingsIdolSelectGridViewCell Pointer )

            return value;
        }
    }
}
