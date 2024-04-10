using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderPanel                              0001865E4990 ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer
    // 028 RankingPanel                             0001865F1E30 ModelClassType PvpRankingPanelView PvpRankingPanelView PvpRankingPanelView Pointer
    // 030 IconAtlas                                00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer
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

            value.HeaderPanel                               = GetObject<PvpHeaderPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpHeaderPanelView.FromPointer); // 02466A1A57E8 0x20 HeaderPanel                 ( 0001865E4990 ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer )
            value.RankingPanel                              = GetObject<PvpRankingPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpRankingPanelView.FromPointer); // 02466A1A5808 0x28 RankingPanel                ( 0001865F1E30 ModelClassType PvpRankingPanelView PvpRankingPanelView PvpRankingPanelView Pointer )
            value.IconAtlas                                 = GetObject<SpriteAtlas>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpriteAtlas.FromPointer); // 02466A1A5828 0x30 IconAtlas                   ( 00018654FA50 ModelClassType SpriteAtlas SpriteAtlas SpriteAtlas Pointer )

            return value;
        }
    }
}
