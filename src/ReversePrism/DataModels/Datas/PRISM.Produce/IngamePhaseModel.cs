using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PhaseNum                                 int IL2CPP_TYPE_I4
    // 010 StartPhase                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Phase                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 PhaseChangeCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C SetDoublePhaseModeCount                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CardUseCount                             000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 onPhaseChangeSubject                     Subject`1<ValueTuple`3<int, int, PhaseChangeCostDownMode>> IL2CPP_TYPE_GENERICINST
    // 030 LastPhaseChangeTime                      0001866656B0 ModelPrimitiveType float float float Single
    // 034 IsDoublePhaseMode                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 getGameTimeFunc                          Func`1<float> IL2CPP_TYPE_GENERICINST
    // 040 IsPhaseMatchCallback                     Func`2<int, bool> IL2CPP_TYPE_GENERICINST
    public partial class IngamePhaseModel : DataModel
    {
        public int                                      StartPhase                              { get; set; }
        public int                                      Phase                                   { get; set; }
        public int                                      PhaseChangeCount                        { get; set; }
        public int                                      SetDoublePhaseModeCount                 { get; set; }
        public List<int>?                               CardUseCount                            { get; set; }
        public float                                    LastPhaseChangeTime                     { get; set; }
        public bool                                     IsDoublePhaseMode                       { get; set; }

        public static IngamePhaseModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePhaseModel() { Pointer= p0 };

            value.StartPhase                                = GetInt32(new IntPtr(p + 0x010)); // 024665BC3B38 0x10 StartPhase                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x014)); // 024665BC3B58 0x14 Phase                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PhaseChangeCount                          = GetInt32(new IntPtr(p + 0x018)); // 024665BC3B78 0x18 PhaseChangeCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SetDoublePhaseModeCount                   = GetInt32(new IntPtr(p + 0x01C)); // 024665BC3B98 0x1C SetDoublePhaseModeCount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardUseCount                              = GetInt32List(new IntPtr(p + 0x020)); // 024665BC3BB8 0x20 CardUseCount                ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastPhaseChangeTime                       = GetSingle(new IntPtr(p + 0x030)); // 024665BC3BF8 0x30 LastPhaseChangeTime         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsDoublePhaseMode                         = GetBool(new IntPtr(p + 0x034)); // 024665BC3C18 0x34 IsDoublePhaseMode           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
