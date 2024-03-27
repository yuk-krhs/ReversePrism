using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865EE200 ModelClassType PvpPerformanceView PvpPerformanceView PvpPerformanceView Pointer
    public partial class PvpPerformanceBuilder
    {
        public PvpPerformanceView?                      View                                    { get; set; }

        public static PvpPerformanceBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceBuilder();

            value.View                                      = GetObject<PvpPerformanceView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPerformanceView.FromPointer); // 0270DB61F518 0x20 View                        ( 0001865EE200 ModelClassType PvpPerformanceView PvpPerformanceView PvpPerformanceView Pointer )

            return value;
        }
    }
}
