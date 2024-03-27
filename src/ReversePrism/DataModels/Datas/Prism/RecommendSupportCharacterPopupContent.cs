using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ToggleButtonGroup                        000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    public partial class RecommendSupportCharacterPopupContent
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }

        public static RecommendSupportCharacterPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecommendSupportCharacterPopupContent();

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D4ED0040 0x60 ToggleButtonGroup           ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )

            return value;
        }
    }
}
