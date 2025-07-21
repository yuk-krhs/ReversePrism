using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelfName                                 ModelPrimitiveType string string string String
    // 018 OpponentName                             ModelPrimitiveType string string string String
    // 020 SelfUnit                                 ModelClassType IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus Pointer
    // 028 OpponentUnit                             ModelClassType IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus Pointer
    // 030 SelfSceneData                            ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer
    // 038 OpponentSceneData                        ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer
    // 040 EventEffect                              ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer
    public partial class PvpInGameViewParam : DataModel
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
            var value   = new PvpInGameViewParam() { Pointer= p0 };

            value.SelfName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 SelfName                    ( ModelPrimitiveType string string string String )
            value.OpponentName                              = GetString(new IntPtr(p + 0x018)); // 0x18 OpponentName                ( ModelPrimitiveType string string string String )
            value.SelfUnit                                  = GetObject<IPvpInGameSelfUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPvpInGameSelfUnitStatus.FromPointer); // 0x20 SelfUnit                    ( ModelClassType IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus IPvpInGameSelfUnitStatus Pointer )
            value.OpponentUnit                              = GetObject<IPvpInGameOpponentUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPvpInGameOpponentUnitStatus.FromPointer); // 0x28 OpponentUnit                ( ModelClassType IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus IPvpInGameOpponentUnitStatus Pointer )
            value.SelfSceneData                             = GetObject<PvpInGameUnitSceneData>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpInGameUnitSceneData.FromPointer); // 0x30 SelfSceneData               ( ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer )
            value.OpponentSceneData                         = GetObject<PvpInGameUnitSceneData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpInGameUnitSceneData.FromPointer); // 0x38 OpponentSceneData           ( ModelClassType PvpInGameUnitSceneData PvpInGameUnitSceneData PvpInGameUnitSceneData Pointer )
            value.EventEffect                               = GetObject<IPvpEventEffectStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPvpEventEffectStatus.FromPointer); // 0x40 EventEffect                 ( ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer )

            return value;
        }
    }
}
