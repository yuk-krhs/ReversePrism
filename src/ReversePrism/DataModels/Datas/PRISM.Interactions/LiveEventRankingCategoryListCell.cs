using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CellText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveEventRankingCategoryListCell
    {
        public UITextMeshProUGUI?                       CellText                                { get; set; }

        public static LiveEventRankingCategoryListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingCategoryListCell();

            value.CellText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90BEA8 0x40 CellText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
