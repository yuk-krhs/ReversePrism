using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 AdvUI                                    000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer
    public partial class ProduceSubSeasonSelectConnector : DataModel
    {
        public ADVUI?                                   AdvUI                                   { get; set; }

        public static ProduceSubSeasonSelectConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectConnector() { Pointer= p0 };

            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.ADVUI.FromPointer); // 02466A282770 0x90 AdvUI                       ( 000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer )

            return value;
        }
    }
}
