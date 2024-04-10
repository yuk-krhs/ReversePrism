using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetChallengeTourUnitArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChallengeTourIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 ChallengeTourId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 01C UnitType                                 00018658CBB0 ModelEnumType ChallengeTourUnitType ChallengeTourUnitType ChallengeTourUnitType Int32
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 FesUnitId                                000186671910 ModelPrimitiveType string string string String
    public partial class SetChallengeTourUnitArgs : DataModel
    {
        public int                                      ChallengeTourId                         { get; set; }
        public ChallengeTourUnitType                    UnitType                                { get; set; }
        public string                                   FesUnitId                               { get; set; }

        public static SetChallengeTourUnitArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetChallengeTourUnitArgs() { Pointer= p0 };

            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x018)); // 024660B3E118 0x18 ChallengeTourId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitType                                  = (ChallengeTourUnitType)GetInt32(new IntPtr(p + 0x01C)); // 024660B3E158 0x1C UnitType                    ( 00018658CBB0 ModelEnumType ChallengeTourUnitType ChallengeTourUnitType ChallengeTourUnitType Int32 )
            value.FesUnitId                                 = GetString(new IntPtr(p + 0x020)); // 024660B3E198 0x20 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
