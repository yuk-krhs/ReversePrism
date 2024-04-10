using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DrawProbes                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 DrawBricks                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 DrawCells                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 RealtimeSubdivision                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 SubdivisionCellUpdatePerFrame            0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SubdivisionDelayInSeconds                000186666050 ModelPrimitiveType float float float Single
    // 01C ProbeShading                             00018669F350 ModelEnumType DebugProbeShadingMode DebugProbeShadingMode DebugProbeShadingMode Int32
    // 020 ProbeSize                                000186666050 ModelPrimitiveType float float float Single
    // 024 SubdivisionViewCullingDistance           000186666050 ModelPrimitiveType float float float Single
    // 028 ProbeCullingDistance                     000186666050 ModelPrimitiveType float float float Single
    // 02C MaxSubdivToVisualize                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 MinSubdivToVisualize                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 ExposureCompensation                     000186666050 ModelPrimitiveType float float float Single
    // 038 DrawVirtualOffsetPush                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 03C OffsetSize                               000186666050 ModelPrimitiveType float float float Single
    // 040 FreezeStreaming                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 044 OtherStateIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.DrawProbes                                = GetBool(new IntPtr(p + 0x010)); // 024669261338 0x10 DrawProbes                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DrawBricks                                = GetBool(new IntPtr(p + 0x011)); // 024669261358 0x11 DrawBricks                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DrawCells                                 = GetBool(new IntPtr(p + 0x012)); // 024669261378 0x12 DrawCells                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RealtimeSubdivision                       = GetBool(new IntPtr(p + 0x013)); // 024669261398 0x13 RealtimeSubdivision         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SubdivisionCellUpdatePerFrame             = GetInt32(new IntPtr(p + 0x014)); // 0246692613B8 0x14 SubdivisionCellUpdatePerFrame ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SubdivisionDelayInSeconds                 = GetSingle(new IntPtr(p + 0x018)); // 0246692613D8 0x18 SubdivisionDelayInSeconds   ( 000186666050 ModelPrimitiveType float float float Single )
            value.ProbeShading                              = (DebugProbeShadingMode)GetInt32(new IntPtr(p + 0x01C)); // 0246692613F8 0x1C ProbeShading                ( 00018669F350 ModelEnumType DebugProbeShadingMode DebugProbeShadingMode DebugProbeShadingMode Int32 )
            value.ProbeSize                                 = GetSingle(new IntPtr(p + 0x020)); // 024669261418 0x20 ProbeSize                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.SubdivisionViewCullingDistance            = GetSingle(new IntPtr(p + 0x024)); // 024669261438 0x24 SubdivisionViewCullingDistance ( 000186666050 ModelPrimitiveType float float float Single )
            value.ProbeCullingDistance                      = GetSingle(new IntPtr(p + 0x028)); // 024669261458 0x28 ProbeCullingDistance        ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxSubdivToVisualize                      = GetInt32(new IntPtr(p + 0x02C)); // 024669261478 0x2C MaxSubdivToVisualize        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinSubdivToVisualize                      = GetInt32(new IntPtr(p + 0x030)); // 024669261498 0x30 MinSubdivToVisualize        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ExposureCompensation                      = GetSingle(new IntPtr(p + 0x034)); // 0246692614B8 0x34 ExposureCompensation        ( 000186666050 ModelPrimitiveType float float float Single )
            value.DrawVirtualOffsetPush                     = GetBool(new IntPtr(p + 0x038)); // 0246692614D8 0x38 DrawVirtualOffsetPush       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OffsetSize                                = GetSingle(new IntPtr(p + 0x03C)); // 0246692614F8 0x3C OffsetSize                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.FreezeStreaming                           = GetBool(new IntPtr(p + 0x040)); // 024669261518 0x40 FreezeStreaming             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OtherStateIndex                           = GetInt32(new IntPtr(p + 0x044)); // 024669261538 0x44 OtherStateIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
