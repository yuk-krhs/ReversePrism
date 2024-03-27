using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CellBase                                 00018655BB00 ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer
    public partial class ChainTalkCellForReadScroller
    {
        public ChainTalkCellBase?                       CellBase                                { get; set; }

        public static ChainTalkCellForReadScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellForReadScroller();

            value.CellBase                                  = GetObject<ChainTalkCellBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellBase.FromPointer); // 0270DB0E7160 0x38 CellBase                    ( 00018655BB00 ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer )

            return value;
        }
    }
}
