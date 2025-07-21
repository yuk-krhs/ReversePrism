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
    // 030 MergeLength                              ModelPrimitiveType float float float Single
    // 038 gridMap                                  GridMap`1<int> IL2CPP_TYPE_GENERICINST
    // 040 joinPairMap                              NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 050 resultRef                                NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SameDistanceReduction : DataModel
    {
        public string                                   Name                                    { get; set; }
        public VirtualMesh?                             Vmesh                                   { get; set; }
        public ReductionWorkData?                       WorkData                                { get; set; }
        public ResultCode                               Result                                  { get; set; }
        public float                                    MergeLength                             { get; set; }

        public static SameDistanceReduction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SameDistanceReduction() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Vmesh                                     = GetObject<VirtualMesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x18 Vmesh                       ( ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer )
            value.WorkData                                  = GetObject<ReductionWorkData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReductionWorkData.FromPointer); // 0x20 WorkData                    ( ModelClassType ReductionWorkData ReductionWorkData ReductionWorkData Pointer )
            value.Result                                    = (ResultCode)GetInt32(new IntPtr(p + 0x028)); // 0x28 Result                      ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.MergeLength                               = GetSingle(new IntPtr(p + 0x030)); // 0x30 MergeLength                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
