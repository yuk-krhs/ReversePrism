using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderPanel                              ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer
    // 028 RankingPanel                             ModelClassType PvpRankingPanelView PvpRankingPanelView PvpRankingPanelView Pointer
    // 030 IconAtlas                                ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
    public partial class PvpRankingView : DataModel
    {
        public PvpHeaderPanelView?                      HeaderPanel                             { get; set; }
        public PvpRankingPanelView?                     RankingPanel                            { get; set; }
        public SpriteAtlas?                             IconAtlas                               { get; set; }

        public static PvpRankingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingView() { Pointer= p0 };

            value.HeaderPanel                               = GetObject<PvpHeaderPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpHeaderPanelView.FromPointer); // 0x20 HeaderPanel                 ( ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer )
            value.RankingPanel                              = GetObject<PvpRankingPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpRankingPanelView.FromPointer); // 0x28 RankingPanel                ( ModelClassType PvpRankingPanelView PvpRankingPanelView PvpRankingPanelView Pointer )
            value.IconAtlas                                 = GetObject<SpriteAtlas>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 0x30 IconAtlas                   ( ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )

            return value;
        }
    }
}
