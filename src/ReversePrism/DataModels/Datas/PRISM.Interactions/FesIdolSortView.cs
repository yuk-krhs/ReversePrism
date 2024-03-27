using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DisplayOrderToggleButtonGroup            000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    public partial class FesIdolSortView
    {
        public ToggleButtonGroup?                       DisplayOrderToggleButtonGroup           { get; set; }

        public static FesIdolSortView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolSortView();

            value.DisplayOrderToggleButtonGroup             = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270DA2AB5F0 0x20 DisplayOrderToggleButtonGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )

            return value;
        }
    }
}
