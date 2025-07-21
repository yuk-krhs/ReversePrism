using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClickIcon                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onClickThumbnail                         Subject`1<ChainTalkCellThumbnailData> IL2CPP_TYPE_GENERICINST
    public partial class ChainTalkReadScrollerViewContext : DataModel
    {

        public static ChainTalkReadScrollerViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkReadScrollerViewContext() { Pointer= p0 };


            return value;
        }
    }
}
