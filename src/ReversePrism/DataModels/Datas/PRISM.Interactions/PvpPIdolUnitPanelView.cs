using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 SkillIconView                            0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 VoDaViMeRankView                         000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 038 VoDaViMeView                             000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    public partial class PvpPIdolUnitPanelView
    {
        public PFIdolIconView?                          IconView                                { get; set; }
        public IdolSkillIconView?                       SkillIconView                           { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }
        public VoDaViMeView?                            VoDaViMeView                            { get; set; }

        public static PvpPIdolUnitPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPIdolUnitPanelView();

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DA148E10 0x20 IconView                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA148E30 0x28 SkillIconView               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0270DA148E50 0x30 VoDaViMeRankView            ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeView>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0270DA148E70 0x38 VoDaViMeView                ( 000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
