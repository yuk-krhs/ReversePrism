using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 LevelView                                ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 030 DearnessView                             ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 038 VocalView                                ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 040 DanceView                                ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 048 VisualView                               ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    // 050 MentalView                               ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer
    public partial class IdolLevelUpIdolView : DataModel
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
            var value   = new IdolLevelUpIdolView() { Pointer= p0 };

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 IconView                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.LevelView                                 = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0x28 LevelView                   ( ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.DearnessView                              = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0x30 DearnessView                ( ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.VocalView                                 = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0x38 VocalView                   ( ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.DanceView                                 = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0x40 DanceView                   ( ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.VisualView                                = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0x48 VisualView                  ( ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )
            value.MentalView                                = GetObject<IdolLevelUpParamView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolLevelUpParamView.FromPointer); // 0x50 MentalView                  ( ModelClassType IdolLevelUpParamView IdolLevelUpParamView IdolLevelUpParamView Pointer )

            return value;
        }
    }
}
