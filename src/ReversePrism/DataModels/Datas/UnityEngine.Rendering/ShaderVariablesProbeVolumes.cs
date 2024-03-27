using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PoolDim_CellInMeters                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 MinCellPos_Noise                         0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 IndicesDim_IndexChunkSize                0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 040 Biases_CellInMinBrick_MinBrickSize       0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 LeakReductionParams                      0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 Weight_MinLoadedCell                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 070 MaxLoadedCell_FrameIndex                 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 080 NormalizationClamp_Padding12             0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class ShaderVariablesProbeVolumes
    {
        public Vector4                                  PoolDim_CellInMeters                    { get; set; }
        public Vector4                                  MinCellPos_Noise                        { get; set; }
        public Vector4                                  IndicesDim_IndexChunkSize               { get; set; }
        public Vector4                                  Biases_CellInMinBrick_MinBrickSize      { get; set; }
        public Vector4                                  LeakReductionParams                     { get; set; }
        public Vector4                                  Weight_MinLoadedCell                    { get; set; }
        public Vector4                                  MaxLoadedCell_FrameIndex                { get; set; }
        public Vector4                                  NormalizationClamp_Padding12            { get; set; }

        public static ShaderVariablesProbeVolumes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderVariablesProbeVolumes();

            value.PoolDim_CellInMeters                      = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0270D9252E00 0x10 PoolDim_CellInMeters        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MinCellPos_Noise                          = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0270D9252E20 0x20 MinCellPos_Noise            ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.IndicesDim_IndexChunkSize                 = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0270D9252E40 0x30 IndicesDim_IndexChunkSize   ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Biases_CellInMinBrick_MinBrickSize        = (Vector4)GetInt32(new IntPtr(p + 0x040)); // 0270D9252E60 0x40 Biases_CellInMinBrick_MinBrickSize ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.LeakReductionParams                       = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0270D9252E80 0x50 LeakReductionParams         ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Weight_MinLoadedCell                      = (Vector4)GetInt32(new IntPtr(p + 0x060)); // 0270D9252EA0 0x60 Weight_MinLoadedCell        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MaxLoadedCell_FrameIndex                  = (Vector4)GetInt32(new IntPtr(p + 0x070)); // 0270D9252EC0 0x70 MaxLoadedCell_FrameIndex    ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.NormalizationClamp_Padding12              = (Vector4)GetInt32(new IntPtr(p + 0x080)); // 0270D9252EE0 0x80 NormalizationClamp_Padding12 ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
