using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Content                                  ModelClassType PvpPerformanceContent PvpPerformanceContent PvpPerformanceContent Pointer
    public partial class PvpPerformanceView : DataModel
    {
        public PvpPerformanceContent?                   Content                                 { get; set; }

        public static PvpPerformanceView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceView() { Pointer= p0 };

            value.Content                                   = GetObject<PvpPerformanceContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpPerformanceContent.FromPointer); // 0x20 Content                     ( ModelClassType PvpPerformanceContent PvpPerformanceContent PvpPerformanceContent Pointer )

            return value;
        }
    }
}
