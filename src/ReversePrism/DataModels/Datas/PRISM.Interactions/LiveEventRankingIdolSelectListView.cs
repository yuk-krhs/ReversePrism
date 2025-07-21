using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 LeftArrow                                ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 098 RightArrow                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class LiveEventRankingIdolSelectListView : DataModel
    {
        public ButtonBase?                              LeftArrow                               { get; set; }
        public ButtonBase?                              RightArrow                              { get; set; }

        public static LiveEventRankingIdolSelectListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingIdolSelectListView() { Pointer= p0 };

            value.LeftArrow                                 = GetObject<ButtonBase>(new IntPtr(p + 0x090), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x90 LeftArrow                   ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RightArrow                                = GetObject<ButtonBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x98 RightArrow                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
