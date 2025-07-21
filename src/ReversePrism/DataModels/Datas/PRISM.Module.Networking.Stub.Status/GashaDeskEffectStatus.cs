using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaDeskEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 Phase1FieldNumber                        int IL2CPP_TYPE_I4
    // 018 Phase1                                   ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 Phase2FieldNumber                        int IL2CPP_TYPE_I4
    // 020 Phase2                                   ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer
    // 000 CharacterEffectListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_characterEffectList_codec      FieldCodec`1<GashaSupportCharacterEffectStatus> IL2CPP_TYPE_GENERICINST
    // 028 CharacterEffectList                      ModelClassListType RepeatedField`1<GashaSupportCharacterEffectStatus> RepeatedField`1<GashaSupportCharacterEffectStatus> List<GashaSupportCharacterEffectStatus> Pointer
    // 000 NoticeTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 NoticeType                               ModelPrimitiveType int int int Int32
    // 000 DrawCountFieldNumber                     int IL2CPP_TYPE_I4
    // 034 DrawCount                                ModelPrimitiveType int int int Int32
    // 000 CalenderFieldNumber                      int IL2CPP_TYPE_I4
    // 038 Calender                                 ModelEnumType GashaEffectCalenderType GashaEffectCalenderType GashaEffectCalenderType Int32
    // 000 TvTypeFieldNumber                        int IL2CPP_TYPE_I4
    // 03C TvType                                   ModelEnumType GashaEffectTVType GashaEffectTVType GashaEffectTVType Int32
    // 000 IsSkipPhase1FieldNumber                  int IL2CPP_TYPE_I4
    // 040 IsSkipPhase1                             ModelPrimitiveType bool bool bool Bool
    // 000 PasserbyCharacterFieldNumber             int IL2CPP_TYPE_I4
    // 048 PasserbyCharacter                        ModelClassType GashaPasserbyCharacterEffectStatus GashaPasserbyCharacterEffectStatus GashaPasserbyCharacterEffectStatus Pointer
    // 000 FlavorTextIdFieldNumber                  int IL2CPP_TYPE_I4
    // 050 FlavorTextId                             ModelPrimitiveType string string string String
    public partial class GashaDeskEffectStatus : DataModel
    {
        public GashaEffectPhaseStatus?                  Phase1                                  { get; set; }
        public GashaEffectPhaseStatus?                  Phase2                                  { get; set; }
        public List<GashaSupportCharacterEffectStatus>? CharacterEffectList                     { get; set; }
        public int                                      NoticeType                              { get; set; }
        public int                                      DrawCount                               { get; set; }
        public GashaEffectCalenderType                  Calender                                { get; set; }
        public GashaEffectTVType                        TvType                                  { get; set; }
        public bool                                     IsSkipPhase1                            { get; set; }
        public GashaPasserbyCharacterEffectStatus?      PasserbyCharacter                       { get; set; }
        public string                                   FlavorTextId                            { get; set; }

        public static GashaDeskEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDeskEffectStatus() { Pointer= p0 };

            value.Phase1                                    = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x18 Phase1                      ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.Phase2                                    = GetObject<GashaEffectPhaseStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaEffectPhaseStatus.FromPointer); // 0x20 Phase2                      ( ModelClassType GashaEffectPhaseStatus GashaEffectPhaseStatus GashaEffectPhaseStatus Pointer )
            value.CharacterEffectList                       = GetObjectList<GashaSupportCharacterEffectStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaSupportCharacterEffectStatus.FromPointer); // 0x28 CharacterEffectList         ( ModelClassListType RepeatedField`1<GashaSupportCharacterEffectStatus> RepeatedField`1<GashaSupportCharacterEffectStatus> List<GashaSupportCharacterEffectStatus> Pointer )
            value.NoticeType                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 NoticeType                  ( ModelPrimitiveType int int int Int32 )
            value.DrawCount                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 DrawCount                   ( ModelPrimitiveType int int int Int32 )
            value.Calender                                  = (GashaEffectCalenderType)GetInt32(new IntPtr(p + 0x038)); // 0x38 Calender                    ( ModelEnumType GashaEffectCalenderType GashaEffectCalenderType GashaEffectCalenderType Int32 )
            value.TvType                                    = (GashaEffectTVType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C TvType                      ( ModelEnumType GashaEffectTVType GashaEffectTVType GashaEffectTVType Int32 )
            value.IsSkipPhase1                              = GetBool(new IntPtr(p + 0x040)); // 0x40 IsSkipPhase1                ( ModelPrimitiveType bool bool bool Bool )
            value.PasserbyCharacter                         = GetObject<GashaPasserbyCharacterEffectStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaPasserbyCharacterEffectStatus.FromPointer); // 0x48 PasserbyCharacter           ( ModelClassType GashaPasserbyCharacterEffectStatus GashaPasserbyCharacterEffectStatus GashaPasserbyCharacterEffectStatus Pointer )
            value.FlavorTextId                              = GetString(new IntPtr(p + 0x050)); // 0x50 FlavorTextId                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
