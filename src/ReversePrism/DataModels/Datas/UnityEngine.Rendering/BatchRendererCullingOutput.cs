using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CullingJobsFence                         000186601120 ModelEnumType JobHandle JobHandle JobHandle Int32
    // 020 LocalToWorldMatrix                       00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 060 cullingPlanes                            IntPtr IL2CPP_TYPE_PTR
    // 068 CullingPlaneCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 06C ReceiverPlaneOffset                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 ReceiverPlaneCount                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 078 cullingSplits                            IntPtr IL2CPP_TYPE_PTR
    // 080 CullingSplitCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 084 ViewType                                 00018674A170 ModelEnumType BatchCullingViewType BatchCullingViewType BatchCullingViewType Int32
    // 088 ProjectionType                           0001867497F0 ModelEnumType BatchCullingProjectionType BatchCullingProjectionType BatchCullingProjectionType Int32
    // 08C CullingFlags                             000186748A80 ModelEnumType BatchCullingFlags BatchCullingFlags BatchCullingFlags Int32
    // 090 ViewID                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 098 CullingLayerMask                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 0A0 SceneCullingMask                         00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 0A8 drawCommands                             IntPtr IL2CPP_TYPE_PTR
    public partial class BatchRendererCullingOutput : DataModel
    {
        public JobHandle                                CullingJobsFence                        { get; set; }
        public Matrix4x4                                LocalToWorldMatrix                      { get; set; }
        public int                                      CullingPlaneCount                       { get; set; }
        public int                                      ReceiverPlaneOffset                     { get; set; }
        public int                                      ReceiverPlaneCount                      { get; set; }
        public int                                      CullingSplitCount                       { get; set; }
        public BatchCullingViewType                     ViewType                                { get; set; }
        public BatchCullingProjectionType               ProjectionType                          { get; set; }
        public BatchCullingFlags                        CullingFlags                            { get; set; }
        public ulong                                    ViewID                                  { get; set; }
        public uint                                     CullingLayerMask                        { get; set; }
        public ulong                                    SceneCullingMask                        { get; set; }

        public static BatchRendererCullingOutput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchRendererCullingOutput() { Pointer= p0 };

            value.CullingJobsFence                          = (JobHandle)GetInt32(new IntPtr(p + 0x010)); // 0245A24541E8 0x10 CullingJobsFence            ( 000186601120 ModelEnumType JobHandle JobHandle JobHandle Int32 )
            value.LocalToWorldMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x020)); // 0245A2454208 0x20 LocalToWorldMatrix          ( 00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CullingPlaneCount                         = GetInt32(new IntPtr(p + 0x068)); // 0245A2454248 0x68 CullingPlaneCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReceiverPlaneOffset                       = GetInt32(new IntPtr(p + 0x06C)); // 0245A2454268 0x6C ReceiverPlaneOffset         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReceiverPlaneCount                        = GetInt32(new IntPtr(p + 0x070)); // 0245A2454288 0x70 ReceiverPlaneCount          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CullingSplitCount                         = GetInt32(new IntPtr(p + 0x080)); // 0245A24542C8 0x80 CullingSplitCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ViewType                                  = (BatchCullingViewType)GetInt32(new IntPtr(p + 0x084)); // 0245A24542E8 0x84 ViewType                    ( 00018674A170 ModelEnumType BatchCullingViewType BatchCullingViewType BatchCullingViewType Int32 )
            value.ProjectionType                            = (BatchCullingProjectionType)GetInt32(new IntPtr(p + 0x088)); // 0245A2454308 0x88 ProjectionType              ( 0001867497F0 ModelEnumType BatchCullingProjectionType BatchCullingProjectionType BatchCullingProjectionType Int32 )
            value.CullingFlags                              = (BatchCullingFlags)GetInt32(new IntPtr(p + 0x08C)); // 0245A2454328 0x8C CullingFlags                ( 000186748A80 ModelEnumType BatchCullingFlags BatchCullingFlags BatchCullingFlags Int32 )
            value.ViewID                                    = GetUInt64(new IntPtr(p + 0x090)); // 0245A2454348 0x90 ViewID                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CullingLayerMask                          = GetUInt32(new IntPtr(p + 0x098)); // 0245A2454368 0x98 CullingLayerMask            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SceneCullingMask                          = GetUInt64(new IntPtr(p + 0x0A0)); // 0245A2454388 0xA0 SceneCullingMask            ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
