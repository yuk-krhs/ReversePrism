using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PhaseNum                                 int IL2CPP_TYPE_I4
    // 010 StartPhase                               ModelPrimitiveType int int int Int32
    // 014 Phase                                    ModelPrimitiveType int int int Int32
    // 018 PhaseChangeCount                         ModelPrimitiveType int int int Int32
    // 01C SetDoublePhaseModeCount                  ModelPrimitiveType int int int Int32
    // 020 CardUseCount                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 onPhaseChangeSubject                     Subject`1<ValueTuple`3<int, int, PhaseChangeCostDownMode>> IL2CPP_TYPE_GENERICINST
    // 030 LastPhaseChangeTime                      ModelPrimitiveType float float float Single
    // 034 IsDoublePhaseMode                        ModelPrimitiveType bool bool bool Bool
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

            value.StartPhase                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartPhase                  ( ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Phase                       ( ModelPrimitiveType int int int Int32 )
            value.PhaseChangeCount                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 PhaseChangeCount            ( ModelPrimitiveType int int int Int32 )
            value.SetDoublePhaseModeCount                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SetDoublePhaseModeCount     ( ModelPrimitiveType int int int Int32 )
            value.CardUseCount                              = GetInt32List(new IntPtr(p + 0x020)); // 0x20 CardUseCount                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastPhaseChangeTime                       = GetSingle(new IntPtr(p + 0x030)); // 0x30 LastPhaseChangeTime         ( ModelPrimitiveType float float float Single )
            value.IsDoublePhaseMode                         = GetBool(new IntPtr(p + 0x034)); // 0x34 IsDoublePhaseMode           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
