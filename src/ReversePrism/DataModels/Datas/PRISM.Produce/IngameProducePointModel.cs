using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onChangePpRecoveryTime                   Subject`1<ValueTuple`2<float, float>> IL2CPP_TYPE_GENERICINST
    // 018 onChangeProducePointSubject              Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 020 onTimeRecoveryProducePointSubject        Subject`1<ValueTuple`3<int, int, int>> IL2CPP_TYPE_GENERICINST
    // 028 ProducePointValue                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C CurrentPlayerPPRecoveryTime              0001866656B0 ModelPrimitiveType float float float Single
    // 030 <IsMentaleBreakFunc>k__BackingField      Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 <GetMentalPercentFunc>k__BackingField    Func`1<int> IL2CPP_TYPE_GENERICINST
    // 040 <GetStatusEffectManagerFunc>k__BackingField Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 048 ProducePointMaxBase                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IngameProducePointModel : DataModel
    {
        public int                                      ProducePointValue                       { get; set; }
        public float                                    CurrentPlayerPPRecoveryTime             { get; set; }
        public int                                      ProducePointMaxBase                     { get; set; }

        public static IngameProducePointModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameProducePointModel() { Pointer= p0 };

            value.ProducePointValue                         = GetInt32(new IntPtr(p + 0x028)); // 024665BCF4F0 0x28 ProducePointValue           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentPlayerPPRecoveryTime               = GetSingle(new IntPtr(p + 0x02C)); // 024665BCF510 0x2C CurrentPlayerPPRecoveryTime ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ProducePointMaxBase                       = GetInt32(new IntPtr(p + 0x048)); // 024665BCF590 0x48 ProducePointMaxBase         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
