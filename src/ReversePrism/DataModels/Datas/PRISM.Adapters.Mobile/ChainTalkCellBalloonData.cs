using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BodyText                                 000186672F10 ModelPrimitiveType string string string String
    public partial class ChainTalkCellBalloonData
    {
        public string                                   BodyText                                { get; set; }

        public static ChainTalkCellBalloonData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellBalloonData();

            value.BodyText                                  = GetString(new IntPtr(p + 0x010)); // 0270D68665F0 0x10 BodyText                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
