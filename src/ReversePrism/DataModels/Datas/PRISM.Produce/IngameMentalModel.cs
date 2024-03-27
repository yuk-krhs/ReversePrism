using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MentalGuardLimit                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 CurrentMental                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MaxMental                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C MentalBreakCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 MentalGurad                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 MentalDamageCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 onChangeMentalGuard                      Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 030 OnMentaleBreakAfter                      0001866792B0 ModelClassType Action Action Action Pointer
    // 038 CurrentBreakTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 040 countRecoveryMentalWhenSecDic            Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 048 IsOverrideMaxMentalBreakTime             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C OverrideMaxMentalBreakTime               0001866656B0 ModelPrimitiveType float float float Single
    // 050 getProduceInGameEffectManagerFunc        Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 058 onUpdateMentalSubject                    Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 060 onAddMentalSubject                       Subject`1<ValueTuple`4<int, int, int, int>> IL2CPP_TYPE_GENERICINST
    // 068 onUpdateMentalBreakStateSubject          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 onUpdateMentalBreakTimeSubject           Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 078 SelfDamageCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IngameMentalModel
    {
        public int                                      MentalGuardLimit                        { get; set; }
        public int                                      CurrentMental                           { get; set; }
        public int                                      MaxMental                               { get; set; }
        public int                                      MentalBreakCount                        { get; set; }
        public int                                      MentalGurad                             { get; set; }
        public int                                      MentalDamageCount                       { get; set; }
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
            var value   = new IngameMentalModel();

            value.MentalGuardLimit                          = GetInt32(new IntPtr(p + 0x010)); // 0270D5B570D0 0x10 MentalGuardLimit            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentMental                             = GetInt32(new IntPtr(p + 0x014)); // 0270D5B570F0 0x14 CurrentMental               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxMental                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D5B57110 0x18 MaxMental                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MentalBreakCount                          = GetInt32(new IntPtr(p + 0x01C)); // 0270D5B57130 0x1C MentalBreakCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MentalGurad                               = GetInt32(new IntPtr(p + 0x020)); // 0270D5B57150 0x20 MentalGurad                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MentalDamageCount                         = GetInt32(new IntPtr(p + 0x024)); // 0270D5B57170 0x24 MentalDamageCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnMentaleBreakAfter                       = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0270D5B571B0 0x30 OnMentaleBreakAfter         ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.CurrentBreakTime                          = GetSingle(new IntPtr(p + 0x038)); // 0270D5B571D0 0x38 CurrentBreakTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsOverrideMaxMentalBreakTime              = GetBool(new IntPtr(p + 0x048)); // 0270D5B57210 0x48 IsOverrideMaxMentalBreakTime ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverrideMaxMentalBreakTime                = GetSingle(new IntPtr(p + 0x04C)); // 0270D5B57230 0x4C OverrideMaxMentalBreakTime  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SelfDamageCount                           = GetInt32(new IntPtr(p + 0x078)); // 0270D5B572F0 0x78 SelfDamageCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
