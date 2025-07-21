using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType MedalGashaView MedalGashaView MedalGashaView Pointer
    public partial class MedalGashaBuilder : DataModel
    {
        public MedalGashaView?                          View                                    { get; set; }

        public static MedalGashaBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaBuilder() { Pointer= p0 };

            value.View                                      = GetObject<MedalGashaView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MedalGashaView.FromPointer); // 0x20 View                        ( ModelClassType MedalGashaView MedalGashaView MedalGashaView Pointer )

            return value;
        }
    }
}
