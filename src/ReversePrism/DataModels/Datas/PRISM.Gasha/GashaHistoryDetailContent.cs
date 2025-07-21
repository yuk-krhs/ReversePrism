using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GashaHistoryDetailScroll                 ModelClassType GashaHistoryDetailScroll GashaHistoryDetailScroll GashaHistoryDetailScroll Pointer
    public partial class GashaHistoryDetailContent : DataModel
    {
        public GashaHistoryDetailScroll?                GashaHistoryDetailScroll                { get; set; }

        public static GashaHistoryDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryDetailContent() { Pointer= p0 };

            value.GashaHistoryDetailScroll                  = GetObject<GashaHistoryDetailScroll>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaHistoryDetailScroll.FromPointer); // 0x60 GashaHistoryDetailScroll    ( ModelClassType GashaHistoryDetailScroll GashaHistoryDetailScroll GashaHistoryDetailScroll Pointer )

            return value;
        }
    }
}
