using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MentalGuardLimit                         ModelPrimitiveType int int int Int32
    // 014 CurrentMental                            ModelPrimitiveType int int int Int32
    // 018 MaxMental                                ModelPrimitiveType int int int Int32
    // 01C MentalBreakCount                         ModelPrimitiveType int int int Int32
    // 020 MentalGurad                              ModelPrimitiveType int int int Int32
    // 024 MentalDamageCount                        ModelPrimitiveType int int int Int32
    // 028 MentalDamegeIgnoreZeroDamage             ModelPrimitiveType int int int Int32
    // 02C MentalRecoveryCount                      ModelPrimitiveType int int int Int32
    // 030 onChangeMentalGuard                      Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 OnMentaleBreakAfter                      ModelClassType Action Action Action Pointer
    // 040 CurrentBreakTime                         ModelPrimitiveType float float float Single
    // 048 countRecoveryMentalWhenSecDic            Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 050 IsOverrideMaxMentalBreakTime             ModelPrimitiveType bool bool bool Bool
    // 054 OverrideMaxMentalBreakTime               ModelPrimitiveType float float float Single
    // 058 getProduceInGameEffectManagerFunc        Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 060 onUpdateMentalSubject                    Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 068 onAddMentalSubject                       Subject`1<ValueTuple`4<int, int, int, int>> IL2CPP_TYPE_GENERICINST
    // 070 onUpdateMentalBreakStateSubject          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 onUpdateMentalBreakTimeSubject           Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 080 SelfDamageCount                          ModelPrimitiveType int int int Int32
    public partial class IngameMentalModel : DataModel
    {
        public int                                      MentalGuardLimit                        { get; set; }
        public int                                      CurrentMental                           { get; set; }
        public int                                      MaxMental                               { get; set; }
        public int                                      MentalBreakCount                        { get; set; }
        public int                                      MentalGurad                             { get; set; }
        public int                                      MentalDamageCount                       { get; set; }
        public int                                      MentalDamegeIgnoreZeroDamage            { get; set; }
        public int                                      MentalRecoveryCount                     { get; set; }
        public Action?                                  OnMentaleBreakAfter                     { get; set; }
        public float                                    CurrentBreakTime                        { get; set; }
        public bool                                     IsOverrideMaxMentalBreakTime            { get; set; }
        public float                                    OverrideMaxMentalBreakTime              { get; set; }
        public int                                      SelfDamageCount                         { get; set; }

        public static IngameMentalModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameMentalModel() { Pointer= p0 };

            value.MentalGuardLimit                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 MentalGuardLimit            ( ModelPrimitiveType int int int Int32 )
            value.CurrentMental                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 CurrentMental               ( ModelPrimitiveType int int int Int32 )
            value.MaxMental                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxMental                   ( ModelPrimitiveType int int int Int32 )
            value.MentalBreakCount                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MentalBreakCount            ( ModelPrimitiveType int int int Int32 )
            value.MentalGurad                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 MentalGurad                 ( ModelPrimitiveType int int int Int32 )
            value.MentalDamageCount                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 MentalDamageCount           ( ModelPrimitiveType int int int Int32 )
            value.MentalDamegeIgnoreZeroDamage              = GetInt32(new IntPtr(p + 0x028)); // 0x28 MentalDamegeIgnoreZeroDamage ( ModelPrimitiveType int int int Int32 )
            value.MentalRecoveryCount                       = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MentalRecoveryCount         ( ModelPrimitiveType int int int Int32 )
            value.OnMentaleBreakAfter                       = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0x38 OnMentaleBreakAfter         ( ModelClassType Action Action Action Pointer )
            value.CurrentBreakTime                          = GetSingle(new IntPtr(p + 0x040)); // 0x40 CurrentBreakTime            ( ModelPrimitiveType float float float Single )
            value.IsOverrideMaxMentalBreakTime              = GetBool(new IntPtr(p + 0x050)); // 0x50 IsOverrideMaxMentalBreakTime ( ModelPrimitiveType bool bool bool Bool )
            value.OverrideMaxMentalBreakTime                = GetSingle(new IntPtr(p + 0x054)); // 0x54 OverrideMaxMentalBreakTime  ( ModelPrimitiveType float float float Single )
            value.SelfDamageCount                           = GetInt32(new IntPtr(p + 0x080)); // 0x80 SelfDamageCount             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
