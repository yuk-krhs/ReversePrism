using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StampAssetKey                            000186672F10 ModelPrimitiveType string string string String
    public partial class ChainTalkCellStampData
    {
        public string                                   StampAssetKey                           { get; set; }

        public static ChainTalkCellStampData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellStampData();

            value.StampAssetKey                             = GetString(new IntPtr(p + 0x010)); // 0270D6866E30 0x10 StampAssetKey               ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
