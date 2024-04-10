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
    // 010 ChunkList                                0001865F4BC0 ModelPrimitiveType int int int Int32
    // 014 State0_L0_L1Rx                           0001865F4BC0 ModelPrimitiveType int int int Int32
    // 018 State0_L1G_L1Ry                          0001865F4BC0 ModelPrimitiveType int int int Int32
    // 01C State0_L1B_L1Rz                          0001865F4BC0 ModelPrimitiveType int int int Int32
    // 020 State0_L2_0                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 024 State0_L2_1                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 028 State0_L2_2                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 02C State0_L2_3                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 030 State1_L0_L1Rx                           0001865F4BC0 ModelPrimitiveType int int int Int32
    // 034 State1_L1G_L1Ry                          0001865F4BC0 ModelPrimitiveType int int int Int32
    // 038 State1_L1B_L1Rz                          0001865F4BC0 ModelPrimitiveType int int int Int32
    // 03C State1_L2_0                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 040 State1_L2_1                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 044 State1_L2_2                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 048 State1_L2_3                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 04C Out_L0_L1Rx                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 050 Out_L1G_L1Ry                             0001865F4BC0 ModelPrimitiveType int int int Int32
    // 054 Out_L1B_L1Rz                             0001865F4BC0 ModelPrimitiveType int int int Int32
    // 058 Out_L2_0                                 0001865F4BC0 ModelPrimitiveType int int int Int32
    // 05C Out_L2_1                                 0001865F4BC0 ModelPrimitiveType int int int Int32
    // 060 Out_L2_2                                 0001865F4BC0 ModelPrimitiveType int int int Int32
    // 064 Out_L2_3                                 0001865F4BC0 ModelPrimitiveType int int int Int32
    // 010 M_ChunkList                              000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 018 M_MappedChunks                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_State0                                 00018651DAA0 ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer
    // 028 M_State1                                 00018651DAA0 ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer
    // 030 M_MemoryBudget                           000186523340 ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32
    // 034 M_ShBands                                000186521B60 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
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

            value.ChunkList                                 = GetInt32(new IntPtr(p + 0x010)); // 024669236898 0x10 ChunkList                   ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L0_L1Rx                            = GetInt32(new IntPtr(p + 0x014)); // 0246692368B8 0x14 State0_L0_L1Rx              ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L1G_L1Ry                           = GetInt32(new IntPtr(p + 0x018)); // 0246692368D8 0x18 State0_L1G_L1Ry             ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L1B_L1Rz                           = GetInt32(new IntPtr(p + 0x01C)); // 0246692368F8 0x1C State0_L1B_L1Rz             ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L2_0                               = GetInt32(new IntPtr(p + 0x020)); // 024669236918 0x20 State0_L2_0                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L2_1                               = GetInt32(new IntPtr(p + 0x024)); // 024669236938 0x24 State0_L2_1                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L2_2                               = GetInt32(new IntPtr(p + 0x028)); // 024669236958 0x28 State0_L2_2                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State0_L2_3                               = GetInt32(new IntPtr(p + 0x02C)); // 024669236978 0x2C State0_L2_3                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L0_L1Rx                            = GetInt32(new IntPtr(p + 0x030)); // 024669236998 0x30 State1_L0_L1Rx              ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L1G_L1Ry                           = GetInt32(new IntPtr(p + 0x034)); // 0246692369B8 0x34 State1_L1G_L1Ry             ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L1B_L1Rz                           = GetInt32(new IntPtr(p + 0x038)); // 0246692369D8 0x38 State1_L1B_L1Rz             ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L2_0                               = GetInt32(new IntPtr(p + 0x03C)); // 0246692369F8 0x3C State1_L2_0                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L2_1                               = GetInt32(new IntPtr(p + 0x040)); // 024669236A18 0x40 State1_L2_1                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L2_2                               = GetInt32(new IntPtr(p + 0x044)); // 024669236A38 0x44 State1_L2_2                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State1_L2_3                               = GetInt32(new IntPtr(p + 0x048)); // 024669236A58 0x48 State1_L2_3                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L0_L1Rx                               = GetInt32(new IntPtr(p + 0x04C)); // 024669236A78 0x4C Out_L0_L1Rx                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L1G_L1Ry                              = GetInt32(new IntPtr(p + 0x050)); // 024669236A98 0x50 Out_L1G_L1Ry                ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L1B_L1Rz                              = GetInt32(new IntPtr(p + 0x054)); // 024669236AB8 0x54 Out_L1B_L1Rz                ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L2_0                                  = GetInt32(new IntPtr(p + 0x058)); // 024669236AD8 0x58 Out_L2_0                    ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L2_1                                  = GetInt32(new IntPtr(p + 0x05C)); // 024669236AF8 0x5C Out_L2_1                    ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L2_2                                  = GetInt32(new IntPtr(p + 0x060)); // 024669236B18 0x60 Out_L2_2                    ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Out_L2_3                                  = GetInt32(new IntPtr(p + 0x064)); // 024669236B38 0x64 Out_L2_3                    ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.M_ChunkList                               = GetEnumList<Vector4>(new IntPtr(p + 0x010)); // 024669236B58 0x10 M_ChunkList                 ( 000185CB1478 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_MappedChunks                            = GetInt32(new IntPtr(p + 0x018)); // 024669236B78 0x18 M_MappedChunks              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_State0                                  = GetObject<ProbeBrickPool>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProbeBrickPool.FromPointer); // 024669236B98 0x20 M_State0                    ( 00018651DAA0 ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer )
            value.M_State1                                  = GetObject<ProbeBrickPool>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProbeBrickPool.FromPointer); // 024669236BB8 0x28 M_State1                    ( 00018651DAA0 ModelClassType ProbeBrickPool ProbeBrickPool ProbeBrickPool Pointer )
            value.M_MemoryBudget                            = (ProbeVolumeTextureMemoryBudget)GetInt32(new IntPtr(p + 0x030)); // 024669236BD8 0x30 M_MemoryBudget              ( 000186523340 ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32 )
            value.M_ShBands                                 = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x034)); // 024669236BF8 0x34 M_ShBands                   ( 000186521B60 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )

            return value;
        }
    }
}
