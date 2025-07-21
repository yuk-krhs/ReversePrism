using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0D0 PvpAppealGauge                           ModelClassType PvpAppealGauge PvpAppealGauge PvpAppealGauge Pointer
    // 0D8 PvpSceneAssetName                        ModelPrimitiveType string string string String
    // 0E0 SwitchDisplayUnitTime                    ModelPrimitiveType float float float Single
    // 0E8 AuditionPvp                              ModelClassType AuditionPvP AuditionPvP AuditionPvP Pointer
    // 0F0 PvpScene                                 ModelEnumType Scene Scene Scene Int32
    // 0F4 UnitDisplayTimer                         ModelPrimitiveType float float float Single
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

            value.PvpAppealGauge                            = GetObject<PvpAppealGauge>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PvpAppealGauge.FromPointer); // 0xD0 PvpAppealGauge              ( ModelClassType PvpAppealGauge PvpAppealGauge PvpAppealGauge Pointer )
            value.PvpSceneAssetName                         = GetString(new IntPtr(p + 0x0D8)); // 0xD8 PvpSceneAssetName           ( ModelPrimitiveType string string string String )
            value.SwitchDisplayUnitTime                     = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 SwitchDisplayUnitTime       ( ModelPrimitiveType float float float Single )
            value.AuditionPvp                               = GetObject<AuditionPvP>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.AuditionPvP.FromPointer); // 0xE8 AuditionPvp                 ( ModelClassType AuditionPvP AuditionPvP AuditionPvP Pointer )
            value.PvpScene                                  = (Scene)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 PvpScene                    ( ModelEnumType Scene Scene Scene Int32 )
            value.UnitDisplayTimer                          = GetSingle(new IntPtr(p + 0x0F4)); // 0xF4 UnitDisplayTimer            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
