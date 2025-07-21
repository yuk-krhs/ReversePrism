using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 AdvUI                                    ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer
    public partial class ProduceSubSeasonSelectConnector : DataModel
    {
        public AdvScreenView?                           AdvUI                                   { get; set; }

        public static ProduceSubSeasonSelectConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSubSeasonSelectConnector() { Pointer= p0 };

            value.AdvUI                                     = GetObject<AdvScreenView>(new IntPtr(p + 0x088), ReversePrism.DataModels.AdvScreenView.FromPointer); // 0x88 AdvUI                       ( ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer )

            return value;
        }
    }
}
