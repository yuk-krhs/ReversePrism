using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PvpMatch                                 000186607960 ModelClassType IPvpMatchStatus IPvpMatchStatus IPvpMatchStatus Pointer
    public partial class LegacyPvpPerformanceParameter
    {
        public IPvpMatchStatus?                         PvpMatch                                { get; set; }

        public static LegacyPvpPerformanceParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyPvpPerformanceParameter();

            value.PvpMatch                                  = GetObject<IPvpMatchStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpMatchStatus.FromPointer); // 0270D50932B0 0x10 PvpMatch                    ( 000186607960 ModelClassType IPvpMatchStatus IPvpMatchStatus IPvpMatchStatus Pointer )

            return value;
        }
    }
}
