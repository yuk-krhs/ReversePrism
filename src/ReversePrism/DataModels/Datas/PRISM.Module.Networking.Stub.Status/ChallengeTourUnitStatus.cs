using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 UnitTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 01C UnitType                                 ModelEnumType ChallengeTourUnitType ChallengeTourUnitType ChallengeTourUnitType Int32
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 FesUnitId                                ModelPrimitiveType string string string String
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 028 TotalPower                               ModelPrimitiveType int int int Int32
    // 000 IdolListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_idolList_codec                 FieldCodec`1<ChallengeTourIdolStatus> IL2CPP_TYPE_GENERICINST
    // 030 IdolList                                 ModelClassListType RepeatedField`1<ChallengeTourIdolStatus> RepeatedField`1<ChallengeTourIdolStatus> List<ChallengeTourIdolStatus> Pointer
    // 000 CardDeckFieldNumber                      int IL2CPP_TYPE_I4
    // 038 CardDeck                                 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    public partial class ChallengeTourUnitStatus : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public ChallengeTourUnitType                    UnitType                                { get; set; }
        public string                                   FesUnitId                               { get; set; }
        public int                                      TotalPower                              { get; set; }
        public List<ChallengeTourIdolStatus>?           IdolList                                { get; set; }
        public ProduceCardDeckStatus?                   CardDeck                                { get; set; }

        public static ChallengeTourUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitStatus() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnitType                                  = (ChallengeTourUnitType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C UnitType                    ( ModelEnumType ChallengeTourUnitType ChallengeTourUnitType ChallengeTourUnitType Int32 )
            value.FesUnitId                                 = GetString(new IntPtr(p + 0x020)); // 0x20 FesUnitId                   ( ModelPrimitiveType string string string String )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotalPower                  ( ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<ChallengeTourIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourIdolStatus.FromPointer); // 0x30 IdolList                    ( ModelClassListType RepeatedField`1<ChallengeTourIdolStatus> RepeatedField`1<ChallengeTourIdolStatus> List<ChallengeTourIdolStatus> Pointer )
            value.CardDeck                                  = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0x38 CardDeck                    ( ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )

            return value;
        }
    }
}
