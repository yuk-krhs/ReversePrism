using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865F27D0 ModelClassType PvpRankingView PvpRankingView PvpRankingView Pointer
    public partial class PvpRankingBuilder : DataModel
    {
        public PvpRankingView?                          View                                    { get; set; }

        public static PvpRankingBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingBuilder() { Pointer= p0 };

            value.View                                      = GetObject<PvpRankingView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpRankingView.FromPointer); // 02466B6B2918 0x20 View                        ( 0001865F27D0 ModelClassType PvpRankingView PvpRankingView PvpRankingView Pointer )

            return value;
        }
    }
}
