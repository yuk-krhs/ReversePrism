using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 LevelView                                0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 030 DearnessView                             0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 038 VocalView                                0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 040 DanceView                                0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 048 VisualView                               0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 050 MentalView                               0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    public partial class IdolLevelUpIdolView
    {
        public PFIdolIconView?                          IconView                                { get; set; }
        public IdolLevelUpParamView?                    LevelView                               { get; set; }
        public IdolLevelUpParamView?                    DearnessView                            { get; set; }
        public IdolLevelUpParamView?                    VocalView                               { get; set; }
        public IdolLevelUpParamView?                    DanceView                               { get; set; }
        public IdolLevelUpParamView?                    VisualView                              { get; set; }
        public IdolLevelUpParamView?                    MentalView                              { get; set; }

        public static IdolLevelUpIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelUpIdolView();

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D4C53270 0x20 IconView                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.LevelView                                 = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0270D4C53290 0x28 LevelView                   ( 0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.DearnessView                              = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0270D4C532B0 0x30 DearnessView                ( 0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.VocalView                                 = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0270D4C532D0 0x38 VocalView                   ( 0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.DanceView                                 = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0270D4C532F0 0x40 DanceView                   ( 0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.VisualView                                = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0270D4C53310 0x48 VisualView                  ( 0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.MentalView                                = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0270D4C53330 0x50 MentalView                  ( 0001866B1050 ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )

            return value;
        }
    }
}
