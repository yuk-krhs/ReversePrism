using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType PvpPerformanceView PvpPerformanceView PvpPerformanceView Pointer
    public partial class PvpPerformanceBuilder : DataModel
    {
        public PvpPerformanceView?                      View                                    { get; set; }

        public static PvpPerformanceBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceBuilder() { Pointer= p0 };

            value.View                                      = GetObject<PvpPerformanceView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPerformanceView.FromPointer); // 0x20 View                        ( ModelClassType PvpPerformanceView PvpPerformanceView PvpPerformanceView Pointer )

            return value;
        }
    }
}
