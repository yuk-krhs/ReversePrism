using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Vmesh                                    ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer
    // 020 WorkData                                 ModelClassType ReductionWorkData ReductionWorkData ReductionWorkData Pointer
    // 028 Result                                   ModelEnumType ResultCode ResultCode ResultCode Int32
    // 030 StartMergeLength                         ModelPrimitiveType float float float Single
    // 034 EndMergeLength                           ModelPrimitiveType float float float Single
    // 038 MaxStep                                  ModelPrimitiveType int int int Int32
    // 03C DontMakeLine                             ModelPrimitiveType bool bool bool Bool
    // 040 JoinPositionAdjustment                   ModelPrimitiveType float float float Single
    // 044 NowStepIndex                             ModelPrimitiveType int int int Int32
    // 048 NowMergeLength                           ModelPrimitiveType float float float Single
    // 04C NowStepScale                             ModelPrimitiveType float float float Single
    // 050 joinEdgeList                             NativeList`1<JoinEdge> IL2CPP_TYPE_GENERICINST
    // 058 completeVertexSet                        NativeParallelHashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 068 removePairList                           NativeList`1<int2> IL2CPP_TYPE_GENERICINST
    // 070 resultArray                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class StepReductionBase : DataModel
    {
        public string                                   Name                                    { get; set; }
        public VirtualMesh?                             Vmesh                                   { get; set; }
        public ReductionWorkData?                       WorkData                                { get; set; }
        public ResultCode                               Result                                  { get; set; }
        public float                                    StartMergeLength                        { get; set; }
        public float                                    EndMergeLength                          { get; set; }
        public int                                      MaxStep                                 { get; set; }
        public bool                                     DontMakeLine                            { get; set; }
        public float                                    JoinPositionAdjustment                  { get; set; }
        public int                                      NowStepIndex                            { get; set; }
        public float                                    NowMergeLength                          { get; set; }
        public float                                    NowStepScale                            { get; set; }

        public static StepReductionBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepReductionBase() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Vmesh                                     = GetObject<VirtualMesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x18 Vmesh                       ( ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer )
            value.WorkData                                  = GetObject<ReductionWorkData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReductionWorkData.FromPointer); // 0x20 WorkData                    ( ModelClassType ReductionWorkData ReductionWorkData ReductionWorkData Pointer )
            value.Result                                    = (ResultCode)GetInt32(new IntPtr(p + 0x028)); // 0x28 Result                      ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.StartMergeLength                          = GetSingle(new IntPtr(p + 0x030)); // 0x30 StartMergeLength            ( ModelPrimitiveType float float float Single )
            value.EndMergeLength                            = GetSingle(new IntPtr(p + 0x034)); // 0x34 EndMergeLength              ( ModelPrimitiveType float float float Single )
            value.MaxStep                                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 MaxStep                     ( ModelPrimitiveType int int int Int32 )
            value.DontMakeLine                              = GetBool(new IntPtr(p + 0x03C)); // 0x3C DontMakeLine                ( ModelPrimitiveType bool bool bool Bool )
            value.JoinPositionAdjustment                    = GetSingle(new IntPtr(p + 0x040)); // 0x40 JoinPositionAdjustment      ( ModelPrimitiveType float float float Single )
            value.NowStepIndex                              = GetInt32(new IntPtr(p + 0x044)); // 0x44 NowStepIndex                ( ModelPrimitiveType int int int Int32 )
            value.NowMergeLength                            = GetSingle(new IntPtr(p + 0x048)); // 0x48 NowMergeLength              ( ModelPrimitiveType float float float Single )
            value.NowStepScale                              = GetSingle(new IntPtr(p + 0x04C)); // 0x4C NowStepScale                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
