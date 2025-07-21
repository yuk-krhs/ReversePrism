using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ToggleButtonGroup                        ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    public partial class RecommendSupportCharacterPopupContent : DataModel
    {
        public ToggleButtonGroup?                       ToggleButtonGroup                       { get; set; }

        public static RecommendSupportCharacterPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecommendSupportCharacterPopupContent() { Pointer= p0 };

            value.ToggleButtonGroup                         = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x60 ToggleButtonGroup           ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )

            return value;
        }
    }
}
