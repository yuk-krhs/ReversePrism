using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DrawProbes                               ModelPrimitiveType bool bool bool Bool
    // 011 DrawBricks                               ModelPrimitiveType bool bool bool Bool
    // 012 DrawCells                                ModelPrimitiveType bool bool bool Bool
    // 013 RealtimeSubdivision                      ModelPrimitiveType bool bool bool Bool
    // 014 SubdivisionCellUpdatePerFrame            ModelPrimitiveType int int int Int32
    // 018 SubdivisionDelayInSeconds                ModelPrimitiveType float float float Single
    // 01C ProbeShading                             ModelEnumType DebugProbeShadingMode DebugProbeShadingMode DebugProbeShadingMode Int32
    // 020 ProbeSize                                ModelPrimitiveType float float float Single
    // 024 SubdivisionViewCullingDistance           ModelPrimitiveType float float float Single
    // 028 ProbeCullingDistance                     ModelPrimitiveType float float float Single
    // 02C MaxSubdivToVisualize                     ModelPrimitiveType int int int Int32
    // 030 MinSubdivToVisualize                     ModelPrimitiveType int int int Int32
    // 034 ExposureCompensation                     ModelPrimitiveType float float float Single
    // 038 DrawVirtualOffsetPush                    ModelPrimitiveType bool bool bool Bool
    // 03C OffsetSize                               ModelPrimitiveType float float float Single
    // 040 FreezeStreaming                          ModelPrimitiveType bool bool bool Bool
    // 044 OtherStateIndex                          ModelPrimitiveType int int int Int32
    public partial class ProbeVolumeDebug : DataModel
    {
        public bool                                     DrawProbes                              { get; set; }
        public bool                                     DrawBricks                              { get; set; }
        public bool                                     DrawCells                               { get; set; }
        public bool                                     RealtimeSubdivision                     { get; set; }
        public int                                      SubdivisionCellUpdatePerFrame           { get; set; }
        public float                                    SubdivisionDelayInSeconds               { get; set; }
        public DebugProbeShadingMode                    ProbeShading                            { get; set; }
        public float                                    ProbeSize                               { get; set; }
        public float                                    SubdivisionViewCullingDistance          { get; set; }
        public float                                    ProbeCullingDistance                    { get; set; }
        public int                                      MaxSubdivToVisualize                    { get; set; }
        public int                                      MinSubdivToVisualize                    { get; set; }
        public float                                    ExposureCompensation                    { get; set; }
        public bool                                     DrawVirtualOffsetPush                   { get; set; }
        public float                                    OffsetSize                              { get; set; }
        public bool                                     FreezeStreaming                         { get; set; }
        public int                                      OtherStateIndex                         { get; set; }

        public static ProbeVolumeDebug? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumeDebug() { Pointer= p0 };

            value.DrawProbes                                = GetBool(new IntPtr(p + 0x010)); // 0x10 DrawProbes                  ( ModelPrimitiveType bool bool bool Bool )
            value.DrawBricks                                = GetBool(new IntPtr(p + 0x011)); // 0x11 DrawBricks                  ( ModelPrimitiveType bool bool bool Bool )
            value.DrawCells                                 = GetBool(new IntPtr(p + 0x012)); // 0x12 DrawCells                   ( ModelPrimitiveType bool bool bool Bool )
            value.RealtimeSubdivision                       = GetBool(new IntPtr(p + 0x013)); // 0x13 RealtimeSubdivision         ( ModelPrimitiveType bool bool bool Bool )
            value.SubdivisionCellUpdatePerFrame             = GetInt32(new IntPtr(p + 0x014)); // 0x14 SubdivisionCellUpdatePerFrame ( ModelPrimitiveType int int int Int32 )
            value.SubdivisionDelayInSeconds                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 SubdivisionDelayInSeconds   ( ModelPrimitiveType float float float Single )
            value.ProbeShading                              = (DebugProbeShadingMode)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ProbeShading                ( ModelEnumType DebugProbeShadingMode DebugProbeShadingMode DebugProbeShadingMode Int32 )
            value.ProbeSize                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 ProbeSize                   ( ModelPrimitiveType float float float Single )
            value.SubdivisionViewCullingDistance            = GetSingle(new IntPtr(p + 0x024)); // 0x24 SubdivisionViewCullingDistance ( ModelPrimitiveType float float float Single )
            value.ProbeCullingDistance                      = GetSingle(new IntPtr(p + 0x028)); // 0x28 ProbeCullingDistance        ( ModelPrimitiveType float float float Single )
            value.MaxSubdivToVisualize                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MaxSubdivToVisualize        ( ModelPrimitiveType int int int Int32 )
            value.MinSubdivToVisualize                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 MinSubdivToVisualize        ( ModelPrimitiveType int int int Int32 )
            value.ExposureCompensation                      = GetSingle(new IntPtr(p + 0x034)); // 0x34 ExposureCompensation        ( ModelPrimitiveType float float float Single )
            value.DrawVirtualOffsetPush                     = GetBool(new IntPtr(p + 0x038)); // 0x38 DrawVirtualOffsetPush       ( ModelPrimitiveType bool bool bool Bool )
            value.OffsetSize                                = GetSingle(new IntPtr(p + 0x03C)); // 0x3C OffsetSize                  ( ModelPrimitiveType float float float Single )
            value.FreezeStreaming                           = GetBool(new IntPtr(p + 0x040)); // 0x40 FreezeStreaming             ( ModelPrimitiveType bool bool bool Bool )
            value.OtherStateIndex                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 OtherStateIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
