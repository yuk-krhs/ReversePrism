using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer
    public partial class AdvScreenBuilderForLegacyImplement : DataModel
    {
        public AdvScreenView?                           View                                    { get; set; }

        public static AdvScreenBuilderForLegacyImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvScreenBuilderForLegacyImplement() { Pointer= p0 };

            value.View                                      = GetObject<AdvScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvScreenView.FromPointer); // 0x20 View                        ( ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer )

            return value;
        }
    }
}
