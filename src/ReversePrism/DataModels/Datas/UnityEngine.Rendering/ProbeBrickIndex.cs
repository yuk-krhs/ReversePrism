using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxSubdivisionLevels                    int IL2CPP_TYPE_I4
    // 000 kIndexChunkSize                          int IL2CPP_TYPE_I4
    // 010 M_IndexChunks                            000186593200 ModelClassType BitArray BitArray BitArray Pointer
    // 018 M_IndexInChunks                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_NextFreeChunk                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_AvailableChunkCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_PhysicalIndexBuffer                    0001865F59C0 ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 030 M_PhysicalIndexBufferData                000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 EstimatedVMemCost                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C M_CenterRS                               0001866AD710 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 048 m_VoxelToBricks                          Dictionary`2<Vector3Int, List`1<VoxelMeta>> IL2CPP_TYPE_GENERICINST
    // 050 m_BricksToVoxels                         Dictionary`2<Cell, BrickMeta> IL2CPP_TYPE_GENERICINST
    // 058 m_BrickMetaPool                          ObjectPool`1<BrickMeta> IL2CPP_TYPE_GENERICINST
    // 060 m_VoxelMetaListPool                      ObjectPool`1<List`1<VoxelMeta>> IL2CPP_TYPE_GENERICINST
    // 068 m_VoxelMetaPool                          ObjectPool`1<VoxelMeta> IL2CPP_TYPE_GENERICINST
    // 070 M_NeedUpdateIndexComputeBuffer           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 M_UpdateMinIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 M_UpdateMaxIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 g_Cell                                   Cell IL2CPP_TYPE_CLASS
    public partial class ProbeBrickIndex
    {
        public BitArray?                                M_IndexChunks                           { get; set; }
        public int                                      M_IndexInChunks                         { get; set; }
        public int                                      M_NextFreeChunk                         { get; set; }
        public int                                      M_AvailableChunkCount                   { get; set; }
        public ComputeBuffer?                           M_PhysicalIndexBuffer                   { get; set; }
        public List<int>?                               M_PhysicalIndexBufferData               { get; set; }
        public int                                      EstimatedVMemCost                       { get; set; }
        public Vector3Int                               M_CenterRS                              { get; set; }
        public bool                                     M_NeedUpdateIndexComputeBuffer          { get; set; }
        public int                                      M_UpdateMinIndex                        { get; set; }
        public int                                      M_UpdateMaxIndex                        { get; set; }

        public static ProbeBrickIndex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeBrickIndex();

            value.M_IndexChunks                             = GetObject<BitArray>(new IntPtr(p + 0x010), ReversePrism.DataModels.BitArray.FromPointer); // 0270D91B6DE8 0x10 M_IndexChunks               ( 000186593200 ModelClassType BitArray BitArray BitArray Pointer )
            value.M_IndexInChunks                           = GetInt32(new IntPtr(p + 0x018)); // 0270D91B6E08 0x18 M_IndexInChunks             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_NextFreeChunk                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D91B6E28 0x1C M_NextFreeChunk             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_AvailableChunkCount                     = GetInt32(new IntPtr(p + 0x020)); // 0270D91B6E48 0x20 M_AvailableChunkCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_PhysicalIndexBuffer                     = GetObject<ComputeBuffer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0270D91B6E68 0x28 M_PhysicalIndexBuffer       ( 0001865F59C0 ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_PhysicalIndexBufferData                 = GetInt32List(new IntPtr(p + 0x030)); // 0270D91B6E88 0x30 M_PhysicalIndexBufferData   ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EstimatedVMemCost                         = GetInt32(new IntPtr(p + 0x038)); // 0270D91B6EA8 0x38 EstimatedVMemCost           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CenterRS                                = (Vector3Int)GetInt32(new IntPtr(p + 0x03C)); // 0270D91B6EC8 0x3C M_CenterRS                  ( 0001866AD710 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.M_NeedUpdateIndexComputeBuffer            = GetBool(new IntPtr(p + 0x070)); // 0270D91B6F88 0x70 M_NeedUpdateIndexComputeBuffer ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_UpdateMinIndex                          = GetInt32(new IntPtr(p + 0x074)); // 0270D91B6FA8 0x74 M_UpdateMinIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_UpdateMaxIndex                          = GetInt32(new IntPtr(p + 0x078)); // 0270D91B6FC8 0x78 M_UpdateMaxIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
