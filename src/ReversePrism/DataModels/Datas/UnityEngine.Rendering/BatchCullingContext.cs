using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 cullingPlanes                            NativeArray`1<Plane> IL2CPP_TYPE_GENERICINST
    // 020 cullingSplits                            NativeArray`1<CullingSplit> IL2CPP_TYPE_GENERICINST
    // 030 LodParameters                            ModelEnumType LODParameters LODParameters LODParameters Int32
    // 04C LocalToWorldMatrix                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 08C ViewType                                 ModelEnumType BatchCullingViewType BatchCullingViewType BatchCullingViewType Int32
    // 090 ProjectionType                           ModelEnumType BatchCullingProjectionType BatchCullingProjectionType BatchCullingProjectionType Int32
    // 094 CullingFlags                             ModelEnumType BatchCullingFlags BatchCullingFlags BatchCullingFlags Int32
    // 098 ViewID                                   ModelEnumType BatchPackedCullingViewID BatchPackedCullingViewID BatchPackedCullingViewID Int32
    // 0A0 CullingLayerMask                         ModelPrimitiveType uint uint uint UInt32
    // 0A8 SceneCullingMask                         ModelPrimitiveType ulong ulong ulong UInt64
    // 0B0 IsOrthographic                           ModelPrimitiveType sbyte sbyte sbyte SByte
    // 0B4 ReceiverPlaneOffset                      ModelPrimitiveType int int int Int32
    // 0B8 ReceiverPlaneCount                       ModelPrimitiveType int int int Int32
    public partial class BatchCullingContext : DataModel
    {
        public LODParameters                            LodParameters                           { get; set; }
        public Matrix4x4                                LocalToWorldMatrix                      { get; set; }
        public BatchCullingViewType                     ViewType                                { get; set; }
        public BatchCullingProjectionType               ProjectionType                          { get; set; }
        public BatchCullingFlags                        CullingFlags                            { get; set; }
        public BatchPackedCullingViewID                 ViewID                                  { get; set; }
        public uint                                     CullingLayerMask                        { get; set; }
        public ulong                                    SceneCullingMask                        { get; set; }
        public sbyte                                    IsOrthographic                          { get; set; }
        public int                                      ReceiverPlaneOffset                     { get; set; }
        public int                                      ReceiverPlaneCount                      { get; set; }

        public static BatchCullingContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchCullingContext() { Pointer= p0 };

            value.LodParameters                             = (LODParameters)GetInt32(new IntPtr(p + 0x030)); // 0x30 LodParameters               ( ModelEnumType LODParameters LODParameters LODParameters Int32 )
            value.LocalToWorldMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x04C)); // 0x4C LocalToWorldMatrix          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ViewType                                  = (BatchCullingViewType)GetInt32(new IntPtr(p + 0x08C)); // 0x8C ViewType                    ( ModelEnumType BatchCullingViewType BatchCullingViewType BatchCullingViewType Int32 )
            value.ProjectionType                            = (BatchCullingProjectionType)GetInt32(new IntPtr(p + 0x090)); // 0x90 ProjectionType              ( ModelEnumType BatchCullingProjectionType BatchCullingProjectionType BatchCullingProjectionType Int32 )
            value.CullingFlags                              = (BatchCullingFlags)GetInt32(new IntPtr(p + 0x094)); // 0x94 CullingFlags                ( ModelEnumType BatchCullingFlags BatchCullingFlags BatchCullingFlags Int32 )
            value.ViewID                                    = (BatchPackedCullingViewID)GetInt32(new IntPtr(p + 0x098)); // 0x98 ViewID                      ( ModelEnumType BatchPackedCullingViewID BatchPackedCullingViewID BatchPackedCullingViewID Int32 )
            value.CullingLayerMask                          = GetUInt32(new IntPtr(p + 0x0A0)); // 0xA0 CullingLayerMask            ( ModelPrimitiveType uint uint uint UInt32 )
            value.SceneCullingMask                          = GetUInt64(new IntPtr(p + 0x0A8)); // 0xA8 SceneCullingMask            ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.IsOrthographic                            = GetSByte(new IntPtr(p + 0x0B0)); // 0xB0 IsOrthographic              ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.ReceiverPlaneOffset                       = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 ReceiverPlaneOffset         ( ModelPrimitiveType int int int Int32 )
            value.ReceiverPlaneCount                        = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 ReceiverPlaneCount          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
