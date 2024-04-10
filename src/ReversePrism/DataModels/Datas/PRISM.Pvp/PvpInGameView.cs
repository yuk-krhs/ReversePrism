using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0D0 PvpAppealGauge                           0001865E2E20 ModelClassType PvpAppealGauge PvpAppealGauge PvpAppealGauge Pointer
    // 0D8 PvpSceneAssetName                        000186671910 ModelPrimitiveType string string string String
    // 0E0 SwitchDisplayUnitTime                    0001866656B0 ModelPrimitiveType float float float Single
    // 0E8 AuditionPvp                              00018671C4C0 ModelClassType AuditionPvP AuditionPvP AuditionPvP Pointer
    // 0F0 PvpScene                                 000186660100 ModelEnumType Scene Scene Scene Int32
    // 0F4 UnitDisplayTimer                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class PvpInGameView : DataModel
    {
        public PvpAppealGauge?                          PvpAppealGauge                          { get; set; }
        public string                                   PvpSceneAssetName                       { get; set; }
        public float                                    SwitchDisplayUnitTime                   { get; set; }
        public AuditionPvP?                             AuditionPvp                             { get; set; }
        public Scene                                    PvpScene                                { get; set; }
        public float                                    UnitDisplayTimer                        { get; set; }

        public static PvpInGameView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameView() { Pointer= p0 };

            value.PvpAppealGauge                            = GetObject<PvpAppealGauge>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PvpAppealGauge.FromPointer); // 0246650E85F8 0xD0 PvpAppealGauge              ( 0001865E2E20 ModelClassType PvpAppealGauge PvpAppealGauge PvpAppealGauge Pointer )
            value.PvpSceneAssetName                         = GetString(new IntPtr(p + 0x0D8)); // 0246650E8618 0xD8 PvpSceneAssetName           ( 000186671910 ModelPrimitiveType string string string String )
            value.SwitchDisplayUnitTime                     = GetSingle(new IntPtr(p + 0x0E0)); // 0246650E8638 0xE0 SwitchDisplayUnitTime       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AuditionPvp                               = GetObject<AuditionPvP>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.AuditionPvP.FromPointer); // 0246650E8658 0xE8 AuditionPvp                 ( 00018671C4C0 ModelClassType AuditionPvP AuditionPvP AuditionPvP Pointer )
            value.PvpScene                                  = (Scene)GetInt32(new IntPtr(p + 0x0F0)); // 0246650E8678 0xF0 PvpScene                    ( 000186660100 ModelEnumType Scene Scene Scene Int32 )
            value.UnitDisplayTimer                          = GetSingle(new IntPtr(p + 0x0F4)); // 0246650E8698 0xF4 UnitDisplayTimer            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
