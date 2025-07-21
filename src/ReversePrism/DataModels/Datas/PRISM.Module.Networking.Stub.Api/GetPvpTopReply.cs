using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefensePvpUnitChangeableDate             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetPvpTopReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProfileFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Profile                                  ModelClassType PvpProfileStatus PvpProfileStatus PvpProfileStatus Pointer
    // 000 UnitListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_unitList_codec                 FieldCodec`1<PvpUnitStatus> IL2CPP_TYPE_GENERICINST
    // 030 UnitList                                 ModelClassListType RepeatedField`1<PvpUnitStatus> RepeatedField`1<PvpUnitStatus> List<PvpUnitStatus> Pointer
    // 000 PvpEventFieldNumber                      int IL2CPP_TYPE_I4
    // 038 PvpEvent                                 ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer
    // 000 PvpStaminaFieldNumber                    int IL2CPP_TYPE_I4
    // 040 PvpStamina                               ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 DefensePvpUnitChangeableDateFieldNumber  int IL2CPP_TYPE_I4
    // 048 _DefensePvpUnitChangeableDate            ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PvpEventEffectFieldNumber                int IL2CPP_TYPE_I4
    // 050 PvpEventEffect                           ModelClassType PvpEventEffectStatus PvpEventEffectStatus PvpEventEffectStatus Pointer
    public partial class GetPvpTopReply : DataModel
    {
        public DateTime                                 DefensePvpUnitChangeableDate            { get; set; }
        public PvpProfileStatus?                        Profile                                 { get; set; }
        public List<PvpUnitStatus>?                     UnitList                                { get; set; }
        public GameEventStatus?                         PvpEvent                                { get; set; }
        public StaminaStatus?                           PvpStamina                              { get; set; }
        public Timestamp?                               _DefensePvpUnitChangeableDate           { get; set; }
        public PvpEventEffectStatus?                    PvpEventEffect                          { get; set; }

        public static GetPvpTopReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPvpTopReply() { Pointer= p0 };

            value.DefensePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x010)); // 0x10 DefensePvpUnitChangeableDate ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Profile                                   = GetObject<PvpProfileStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpProfileStatus.FromPointer); // 0x28 Profile                     ( ModelClassType PvpProfileStatus PvpProfileStatus PvpProfileStatus Pointer )
            value.UnitList                                  = GetObjectList<PvpUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpUnitStatus.FromPointer); // 0x30 UnitList                    ( ModelClassListType RepeatedField`1<PvpUnitStatus> RepeatedField`1<PvpUnitStatus> List<PvpUnitStatus> Pointer )
            value.PvpEvent                                  = GetObject<GameEventStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameEventStatus.FromPointer); // 0x38 PvpEvent                    ( ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer )
            value.PvpStamina                                = GetObject<StaminaStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x40 PvpStamina                  ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value._DefensePvpUnitChangeableDate             = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _DefensePvpUnitChangeableDate ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PvpEventEffect                            = GetObject<PvpEventEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.PvpEventEffectStatus.FromPointer); // 0x50 PvpEventEffect              ( ModelClassType PvpEventEffectStatus PvpEventEffectStatus PvpEventEffectStatus Pointer )
            value.DefensePvpUnitChangeableDate  = ToDateTime(value._DefensePvpUnitChangeableDate);

            return value;
        }
    }
}
