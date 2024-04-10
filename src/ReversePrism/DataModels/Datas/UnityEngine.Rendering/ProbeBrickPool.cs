using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kProbePoolChunkSizeInBricks              int IL2CPP_TYPE_I4
    // 000 kBrickCellCount                          int IL2CPP_TYPE_I4
    // 000 kBrickProbeCountPerDim                   int IL2CPP_TYPE_I4
    // 000 kBrickProbeCountTotal                    int IL2CPP_TYPE_I4
    // 000 kChunkProbeCountPerDim                   int IL2CPP_TYPE_I4
    // 010 EstimatedVMemCost                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 kMaxPoolWidth                            int IL2CPP_TYPE_I4
    // 018 M_Pool                                   0001865B49A0 ModelEnumType DataLocation DataLocation DataLocation Int32
    // 068 M_NextFreeChunk                          0001865B4220 ModelEnumType BrickChunkAlloc BrickChunkAlloc BrickChunkAlloc Int32
    // 078 m_FreeList                               Stack`1<BrickChunkAlloc> IL2CPP_TYPE_GENERICINST
    // 080 M_AvailableChunkCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 M_SHBands                                000186521B60 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 088 M_ContainsValidity                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProbeBrickPool : DataModel
    {
        public int                                      EstimatedVMemCost                       { get; set; }
        public DataLocation                             M_Pool                                  { get; set; }
        public BrickChunkAlloc                          M_NextFreeChunk                         { get; set; }
        public int                                      M_AvailableChunkCount                   { get; set; }
        public ProbeVolumeSHBands                       M_SHBands                               { get; set; }
        public bool                                     M_ContainsValidity                      { get; set; }

        public static ProbeBrickPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeBrickPool() { Pointer= p0 };

            value.EstimatedVMemCost                         = GetInt32(new IntPtr(p + 0x010)); // 024669235410 0x10 EstimatedVMemCost           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Pool                                    = (DataLocation)GetInt32(new IntPtr(p + 0x018)); // 024669235450 0x18 M_Pool                      ( 0001865B49A0 ModelEnumType DataLocation DataLocation DataLocation Int32 )
            value.M_NextFreeChunk                           = (BrickChunkAlloc)GetInt32(new IntPtr(p + 0x068)); // 024669235470 0x68 M_NextFreeChunk             ( 0001865B4220 ModelEnumType BrickChunkAlloc BrickChunkAlloc BrickChunkAlloc Int32 )
            value.M_AvailableChunkCount                     = GetInt32(new IntPtr(p + 0x080)); // 0246692354B0 0x80 M_AvailableChunkCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SHBands                                 = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x084)); // 0246692354D0 0x84 M_SHBands                   ( 000186521B60 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.M_ContainsValidity                        = GetBool(new IntPtr(p + 0x088)); // 0246692354F0 0x88 M_ContainsValidity          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
