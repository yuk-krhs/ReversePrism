using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 0001865F12F0 ModelClassType PvpRankingListView PvpRankingListView PvpRankingListView Pointer
    public partial class PvpRankingPanelView : DataModel
    {
        public PvpRankingListView?                      ListView                                { get; set; }

        public static PvpRankingPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingPanelView() { Pointer= p0 };

            value.ListView                                  = GetObject<PvpRankingListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpRankingListView.FromPointer); // 02466A1A5848 0x20 ListView                    ( 0001865F12F0 ModelClassType PvpRankingListView PvpRankingListView PvpRankingListView Pointer )

            return value;
        }
    }
}
