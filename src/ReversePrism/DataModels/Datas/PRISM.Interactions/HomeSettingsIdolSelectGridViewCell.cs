using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 IdolIcon                                 ModelClassType HomeSettingsIdolIcon HomeSettingsIdolIcon HomeSettingsIdolIcon Pointer
    public partial class HomeSettingsIdolSelectGridViewCell : DataModel
    {
        public HomeSettingsIdolIcon?                    IdolIcon                                { get; set; }

        public static HomeSettingsIdolSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolSelectGridViewCell() { Pointer= p0 };

            value.IdolIcon                                  = GetObject<HomeSettingsIdolIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeSettingsIdolIcon.FromPointer); // 0x30 IdolIcon                    ( ModelClassType HomeSettingsIdolIcon HomeSettingsIdolIcon HomeSettingsIdolIcon Pointer )

            return value;
        }
    }
}
