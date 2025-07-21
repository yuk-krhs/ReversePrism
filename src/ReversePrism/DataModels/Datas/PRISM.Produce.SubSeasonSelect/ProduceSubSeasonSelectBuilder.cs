using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ProduceSubSeasonSelectView ProduceSubSeasonSelectView ProduceSubSeasonSelectView Pointer
    public partial class ProduceSubSeasonSelectBuilder : DataModel
    {
        public ProduceSubSeasonSelectView?              View                                    { get; set; }

        public static ProduceSubSeasonSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceSubSeasonSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceSubSeasonSelectView.FromPointer); // 0x20 View                        ( ModelClassType ProduceSubSeasonSelectView ProduceSubSeasonSelectView ProduceSubSeasonSelectView Pointer )

            return value;
        }
    }
}
