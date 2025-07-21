using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CommonCellData                           ModelClassType ChainTalkCellCommonData ChainTalkCellCommonData ChainTalkCellCommonData Pointer
    public partial class ChainTalkCellDataForReadScroller : DataModel
    {
        public ChainTalkCellCommonData?                 CommonCellData                          { get; set; }

        public static ChainTalkCellDataForReadScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellDataForReadScroller() { Pointer= p0 };

            value.CommonCellData                            = GetObject<ChainTalkCellCommonData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainTalkCellCommonData.FromPointer); // 0x10 CommonCellData              ( ModelClassType ChainTalkCellCommonData ChainTalkCellCommonData ChainTalkCellCommonData Pointer )

            return value;
        }
    }
}
