using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           IEnumerable`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 018 ScriptCount                              ModelPrimitiveType int int int Int32
    // 01C GetAppealPoint                           ModelPrimitiveType int int int Int32
    // 020 RecoverMe                                ModelPrimitiveType int int int Int32
    // 024 DamageMe                                 ModelPrimitiveType int int int Int32
    // 028 SelfDamage                               ModelPrimitiveType int int int Int32
    // 02C OpponentDamageMe                         ModelPrimitiveType int int int Int32
    // 030 RecoverPP                                ModelPrimitiveType int int int Int32
    // 034 GetMentalGuard                           ModelPrimitiveType int int int Int32
    // 038 DamageOpponentMentalGuard                ModelPrimitiveType int int int Int32
    // 03C GetAvoidRate                             ModelPrimitiveType int int int Int32
    // 040 IgnoreMentalGuard                        ModelPrimitiveType bool bool bool Bool
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

            value.ScriptCount                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScriptCount                 ( ModelPrimitiveType int int int Int32 )
            value.GetAppealPoint                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C GetAppealPoint              ( ModelPrimitiveType int int int Int32 )
            value.RecoverMe                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 RecoverMe                   ( ModelPrimitiveType int int int Int32 )
            value.DamageMe                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 DamageMe                    ( ModelPrimitiveType int int int Int32 )
            value.SelfDamage                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 SelfDamage                  ( ModelPrimitiveType int int int Int32 )
            value.OpponentDamageMe                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C OpponentDamageMe            ( ModelPrimitiveType int int int Int32 )
            value.RecoverPP                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 RecoverPP                   ( ModelPrimitiveType int int int Int32 )
            value.GetMentalGuard                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 GetMentalGuard              ( ModelPrimitiveType int int int Int32 )
            value.DamageOpponentMentalGuard                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 DamageOpponentMentalGuard   ( ModelPrimitiveType int int int Int32 )
            value.GetAvoidRate                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C GetAvoidRate                ( ModelPrimitiveType int int int Int32 )
            value.IgnoreMentalGuard                         = GetBool(new IntPtr(p + 0x040)); // 0x40 IgnoreMentalGuard           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
