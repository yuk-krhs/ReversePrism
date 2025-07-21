using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 stateBlendShader                         ComputeShader IL2CPP_TYPE_CLASS
    // 008 scenarioBlendingKernel                   int IL2CPP_TYPE_I4
    // 00C _PoolDim_LerpFactor                      int IL2CPP_TYPE_I4
    // 010 ChunkList                                ModelPrimitiveType int int int Int32
    // 014 State0_L0_L1Rx                           ModelPrimitiveType int int int Int32
    // 018 State0_L1G_L1Ry                          ModelPrimitiveType int int int Int32
    // 01C State0_L1B_L1Rz                          ModelPrimitiveType int int int Int32
    // 020 State0_L2_0                              ModelPrimitiveType int int int Int32
    // 024 State0_L2_1                              ModelPrimitiveType int int int Int32
    // 028 State0_L2_2                              ModelPrimitiveType int int int Int32
    // 02C State0_L2_3                              ModelPrimitiveType int int int Int32
    // 030 State1_L0_L1Rx                           ModelPrimitiveType int int int Int32
    // 034 State1_L1G_L1Ry                          ModelPrimitiveType int int int Int32
    // 038 State1_L1B_L1Rz                          ModelPrimitiveType int int int Int32
    // 03C State1_L2_0                              ModelPrimitiveType int int int Int32
    // 040 State1_L2_1                              ModelPrimitiveType int int int Int32
    // 044 State1_L2_2                              ModelPrimitiveType int int int Int32
    // 048 State1_L2_3                              ModelPrimitiveType int int int Int32
    // 04C Out_L0_L1Rx                              ModelPrimitiveType int int int Int32
    // 050 Out_L1G_L1Ry                             ModelPrimitiveType int int int Int32
    // 054 Out_L1B_L1Rz                             ModelPrimitiveType int int int Int32
    // 058 Out_L2_0                                 ModelPrimitiveType int int int Int32
    // 05C Out_L2_1                                 ModelPrimitiveType int int int Int32
    // 060 Out_L2_2                                 ModelPrimitiveType int int int Int32
    // 064 Out_L2_3                                 ModelPrimitiveType int int int Int32
    // 010 M_ChunkList                              ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 018 M_MappedChunks                           ModelPrimitiveType int int int Int32
    // 020 M_State0                                 ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer
    // 028 M_State1                                 ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer
    // 030 M_MemoryBudget                           ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32
    // 034 M_ShBands                                ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    public partial class ProbeBrickBlendingPool : DataModel
    {
        public int                                      ChunkList                               { get; set; }
        public int                                      State0_L0_L1Rx                          { get; set; }
        public int                                      State0_L1G_L1Ry                         { get; set; }
        public int                                      State0_L1B_L1Rz                         { get; set; }
        public int                                      State0_L2_0                             { get; set; }
        public int                                      State0_L2_1                             { get; set; }
        public int                                      State0_L2_2                             { get; set; }
        public int                                      State0_L2_3                             { get; set; }
        public int                                      State1_L0_L1Rx                          { get; set; }
        public int                                      State1_L1G_L1Ry                         { get; set; }
        public int                                      State1_L1B_L1Rz                         { get; set; }
        public int                                      State1_L2_0                             { get; set; }
        public int                                      State1_L2_1                             { get; set; }
        public int                                      State1_L2_2                             { get; set; }
        public int                                      State1_L2_3                             { get; set; }
        public int                                      Out_L0_L1Rx                             { get; set; }
        public int                                      Out_L1G_L1Ry                            { get; set; }
        public int                                      Out_L1B_L1Rz                            { get; set; }
        public int                                      Out_L2_0                                { get; set; }
        public int                                      Out_L2_1                                { get; set; }
        public int                                      Out_L2_2                                { get; set; }
        public int                                      Out_L2_3                                { get; set; }
        public List<Vector4>?                           M_ChunkList                             { get; set; }
        public int                                      M_MappedChunks                          { get; set; }
        public ProbeBrickPool?                          M_State0                                { get; set; }
        public ProbeBrickPool?                          M_State1                                { get; set; }
        public ProbeVolumeTextureMemoryBudget           M_MemoryBudget                          { get; set; }
        public ProbeVolumeSHBands                       M_ShBands                               { get; set; }

        public static ProbeBrickBlendingPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeBrickBlendingPool() { Pointer= p0 };

            value.ChunkList                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChunkList                   ( ModelPrimitiveType int int int Int32 )
            value.State0_L0_L1Rx                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 State0_L0_L1Rx              ( ModelPrimitiveType int int int Int32 )
            value.State0_L1G_L1Ry                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 State0_L1G_L1Ry             ( ModelPrimitiveType int int int Int32 )
            value.State0_L1B_L1Rz                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C State0_L1B_L1Rz             ( ModelPrimitiveType int int int Int32 )
            value.State0_L2_0                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 State0_L2_0                 ( ModelPrimitiveType int int int Int32 )
            value.State0_L2_1                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 State0_L2_1                 ( ModelPrimitiveType int int int Int32 )
            value.State0_L2_2                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 State0_L2_2                 ( ModelPrimitiveType int int int Int32 )
            value.State0_L2_3                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C State0_L2_3                 ( ModelPrimitiveType int int int Int32 )
            value.State1_L0_L1Rx                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 State1_L0_L1Rx              ( ModelPrimitiveType int int int Int32 )
            value.State1_L1G_L1Ry                           = GetInt32(new IntPtr(p + 0x034)); // 0x34 State1_L1G_L1Ry             ( ModelPrimitiveType int int int Int32 )
            value.State1_L1B_L1Rz                           = GetInt32(new IntPtr(p + 0x038)); // 0x38 State1_L1B_L1Rz             ( ModelPrimitiveType int int int Int32 )
            value.State1_L2_0                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C State1_L2_0                 ( ModelPrimitiveType int int int Int32 )
            value.State1_L2_1                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 State1_L2_1                 ( ModelPrimitiveType int int int Int32 )
            value.State1_L2_2                               = GetInt32(new IntPtr(p + 0x044)); // 0x44 State1_L2_2                 ( ModelPrimitiveType int int int Int32 )
            value.State1_L2_3                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 State1_L2_3                 ( ModelPrimitiveType int int int Int32 )
            value.Out_L0_L1Rx                               = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Out_L0_L1Rx                 ( ModelPrimitiveType int int int Int32 )
            value.Out_L1G_L1Ry                              = GetInt32(new IntPtr(p + 0x050)); // 0x50 Out_L1G_L1Ry                ( ModelPrimitiveType int int int Int32 )
            value.Out_L1B_L1Rz                              = GetInt32(new IntPtr(p + 0x054)); // 0x54 Out_L1B_L1Rz                ( ModelPrimitiveType int int int Int32 )
            value.Out_L2_0                                  = GetInt32(new IntPtr(p + 0x058)); // 0x58 Out_L2_0                    ( ModelPrimitiveType int int int Int32 )
            value.Out_L2_1                                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C Out_L2_1                    ( ModelPrimitiveType int int int Int32 )
            value.Out_L2_2                                  = GetInt32(new IntPtr(p + 0x060)); // 0x60 Out_L2_2                    ( ModelPrimitiveType int int int Int32 )
            value.Out_L2_3                                  = GetInt32(new IntPtr(p + 0x064)); // 0x64 Out_L2_3                    ( ModelPrimitiveType int int int Int32 )
            value.M_ChunkList                               = GetEnumList<Vector4>(new IntPtr(p + 0x010)); // 0x10 M_ChunkList                 ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_MappedChunks                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_MappedChunks              ( ModelPrimitiveType int int int Int32 )
            value.M_State0                                  = GetObject<ProbeBrickPool>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProbeBrickPool.FromPointer); // 0x20 M_State0                    ( ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer )
            value.M_State1                                  = GetObject<ProbeBrickPool>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProbeBrickPool.FromPointer); // 0x28 M_State1                    ( ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer )
            value.M_MemoryBudget                            = (ProbeVolumeTextureMemoryBudget)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_MemoryBudget              ( ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32 )
            value.M_ShBands                                 = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_ShBands                   ( ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )

            return value;
        }
    }
}
