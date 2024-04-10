using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           IEnumerable`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 018 ScriptCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C GetAppealPoint                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 RecoverMe                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 DamageMe                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SelfDamage                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C OpponentDamageMe                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 RecoverPP                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 GetMentalGuard                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 DamageOpponentMentalGuard                0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C GetAvoidRate                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 IgnoreMentalGuard                        000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class IngameLogicScript : DataModel
    {
        public int                                      ScriptCount                             { get; set; }
        public int                                      GetAppealPoint                          { get; set; }
        public int                                      RecoverMe                               { get; set; }
        public int                                      DamageMe                                { get; set; }
        public int                                      SelfDamage                              { get; set; }
        public int                                      OpponentDamageMe                        { get; set; }
        public int                                      RecoverPP                               { get; set; }
        public int                                      GetMentalGuard                          { get; set; }
        public int                                      DamageOpponentMentalGuard               { get; set; }
        public int                                      GetAvoidRate                            { get; set; }
        public bool                                     IgnoreMentalGuard                       { get; set; }

        public static IngameLogicScript? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameLogicScript() { Pointer= p0 };

            value.ScriptCount                               = GetInt32(new IntPtr(p + 0x018)); // 024665E03C40 0x18 ScriptCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetAppealPoint                            = GetInt32(new IntPtr(p + 0x01C)); // 024665E03C60 0x1C GetAppealPoint              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RecoverMe                                 = GetInt32(new IntPtr(p + 0x020)); // 024665E03C80 0x20 RecoverMe                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DamageMe                                  = GetInt32(new IntPtr(p + 0x024)); // 024665E03CA0 0x24 DamageMe                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SelfDamage                                = GetInt32(new IntPtr(p + 0x028)); // 024665E03CC0 0x28 SelfDamage                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OpponentDamageMe                          = GetInt32(new IntPtr(p + 0x02C)); // 024665E03CE0 0x2C OpponentDamageMe            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RecoverPP                                 = GetInt32(new IntPtr(p + 0x030)); // 024665E03D00 0x30 RecoverPP                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetMentalGuard                            = GetInt32(new IntPtr(p + 0x034)); // 024665E03D20 0x34 GetMentalGuard              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DamageOpponentMentalGuard                 = GetInt32(new IntPtr(p + 0x038)); // 024665E03D40 0x38 DamageOpponentMentalGuard   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GetAvoidRate                              = GetInt32(new IntPtr(p + 0x03C)); // 024665E03D60 0x3C GetAvoidRate                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IgnoreMentalGuard                         = GetBool(new IntPtr(p + 0x040)); // 024665E03D80 0x40 IgnoreMentalGuard           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
