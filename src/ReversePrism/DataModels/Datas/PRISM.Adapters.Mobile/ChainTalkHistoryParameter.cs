using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollPosition                           ModelPrimitiveType float float float Single
    // 014 ChainGroupId                             ModelPrimitiveType int int int Int32
    public partial class ChainTalkHistoryParameter : DataModel
    {
        public float                                    ScrollPosition                          { get; set; }
        public int                                      ChainGroupId                            { get; set; }

        public static ChainTalkHistoryParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkHistoryParameter() { Pointer= p0 };

            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 ScrollPosition              ( ModelPrimitiveType float float float Single )
            value.ChainGroupId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 ChainGroupId                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
