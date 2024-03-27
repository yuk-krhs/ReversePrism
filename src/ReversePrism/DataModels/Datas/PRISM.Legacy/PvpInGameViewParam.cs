using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelfName                                 0001866736C0 ModelPrimitiveType string string string String
    // 018 OpponentName                             0001866736C0 ModelPrimitiveType string string string String
    // 020 SelfUnit                                 000186606DA0 ModelClassType IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus Pointer
    // 028 OpponentUnit                             000186606420 ModelClassType IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus Pointer
    // 030 SelfSceneData                            0001865E8690 ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer
    // 038 OpponentSceneData                        0001865E8690 ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer
    // 040 EventEffect                              000186605890 ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer
    public partial class PvpInGameViewParam
    {
        public string                                   SelfName                                { get; set; }
        public string                                   OpponentName                            { get; set; }
        public IPvpInGameSelfUnitStatus?                SelfUnit                                { get; set; }
        public IPvpInGameOpponentUnitStatus?            OpponentUnit                            { get; set; }
        public PvpInGameUnitSceneData?                  SelfSceneData                           { get; set; }
        public PvpInGameUnitSceneData?                  OpponentSceneData                       { get; set; }
        public IPvpEventEffectStatus?                   EventEffect                             { get; set; }

        public static PvpInGameViewParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameViewParam();

            value.SelfName                                  = GetString(new IntPtr(p + 0x010)); // 0270D5093070 0x10 SelfName                    ( 0001866736C0 ModelPrimitiveType string string string String )
            value.OpponentName                              = GetString(new IntPtr(p + 0x018)); // 0270D5093090 0x18 OpponentName                ( 0001866736C0 ModelPrimitiveType string string string String )
            value.SelfUnit                                  = GetObject<IPvpInGameSelfUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPvpInGameSelfUnitStatus.FromPointer); // 0270D50930B0 0x20 SelfUnit                    ( 000186606DA0 ModelClassType IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus Pointer )
            value.OpponentUnit                              = GetObject<IPvpInGameOpponentUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPvpInGameOpponentUnitStatus.FromPointer); // 0270D50930D0 0x28 OpponentUnit                ( 000186606420 ModelClassType IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus Pointer )
            value.SelfSceneData                             = GetObject<PvpInGameUnitSceneData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpInGameUnitSceneData.FromPointer); // 0270D50930F0 0x30 SelfSceneData               ( 0001865E8690 ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer )
            value.OpponentSceneData                         = GetObject<PvpInGameUnitSceneData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpInGameUnitSceneData.FromPointer); // 0270D5093110 0x38 OpponentSceneData           ( 0001865E8690 ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer )
            value.EventEffect                               = GetObject<IPvpEventEffectStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPvpEventEffectStatus.FromPointer); // 0270D5093130 0x40 EventEffect                 ( 000186605890 ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer )

            return value;
        }
    }
}
