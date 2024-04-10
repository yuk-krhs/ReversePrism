using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rank                                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RankingData : DataModel
    {
        public int                                      Rank                                    { get; set; }

        public static RankingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingData() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x010)); // 02466523F5A0 0x10 Rank                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
