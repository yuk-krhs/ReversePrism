using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 lights                                   NativeArray`1<VisibleLight> IL2CPP_TYPE_GENERICINST
    // 020 reflectionProbes                         NativeArray`1<VisibleReflectionProbe> IL2CPP_TYPE_GENERICINST
    // 030 tileRanges                               NativeArray`1<InclusiveRange> IL2CPP_TYPE_GENERICINST
    // 040 ItemsPerTile                             ModelPrimitiveType int int int Int32
    // 044 RangesPerItem                            ModelPrimitiveType int int int Int32
    // 048 worldToViews                             Fixed2`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 0C8 CenterOffset                             ModelEnumType float4 float4 float4 Int32
    // 0D8 TileScale                                ModelEnumType float2 float2 float2 Int32
    // 0E0 TileScaleInv                             ModelEnumType float2 float2 float2 Int32
    // 0E8 viewPlaneHalfSizes                       Fixed2`1<float2> IL2CPP_TYPE_GENERICINST
    // 0F8 viewPlaneHalfSizeInvs                    Fixed2`1<float2> IL2CPP_TYPE_GENERICINST
    // 108 TileCount                                ModelEnumType int2 int2 int2 Int32
    // 110 Near                                     ModelPrimitiveType float float float Single
    // 114 IsOrthographic                           ModelPrimitiveType bool bool bool Bool
    // 116 M_TileYRange                             ModelEnumType InclusiveRange InclusiveRange InclusiveRange Int32
    // 11C M_Offset                                 ModelPrimitiveType int int int Int32
    // 120 M_ViewIndex                              ModelPrimitiveType int int int Int32
    // 124 M_CenterOffset                           ModelEnumType float2 float2 float2 Int32
    // 000 k_CubePoints                             float3[] IL2CPP_TYPE_SZARRAY
    // 008 k_CubeLineIndices                        int4[] IL2CPP_TYPE_SZARRAY
    public partial class TilingJob : DataModel
    {
        public int                                      ItemsPerTile                            { get; set; }
        public int                                      RangesPerItem                           { get; set; }
        public float4                                   CenterOffset                            { get; set; }
        public float2                                   TileScale                               { get; set; }
        public float2                                   TileScaleInv                            { get; set; }
        public int2                                     TileCount                               { get; set; }
        public float                                    Near                                    { get; set; }
        public bool                                     IsOrthographic                          { get; set; }
        public InclusiveRange                           M_TileYRange                            { get; set; }
        public int                                      M_Offset                                { get; set; }
        public int                                      M_ViewIndex                             { get; set; }
        public float2                                   M_CenterOffset                          { get; set; }

        public static TilingJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TilingJob() { Pointer= p0 };

            value.ItemsPerTile                              = GetInt32(new IntPtr(p + 0x040)); // 0x40 ItemsPerTile                ( ModelPrimitiveType int int int Int32 )
            value.RangesPerItem                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 RangesPerItem               ( ModelPrimitiveType int int int Int32 )
            value.CenterOffset                              = (float4)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 CenterOffset                ( ModelEnumType float4 float4 float4 Int32 )
            value.TileScale                                 = (float2)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 TileScale                   ( ModelEnumType float2 float2 float2 Int32 )
            value.TileScaleInv                              = (float2)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 TileScaleInv                ( ModelEnumType float2 float2 float2 Int32 )
            value.TileCount                                 = (int2)GetInt32(new IntPtr(p + 0x108)); // 0x108 TileCount                   ( ModelEnumType int2 int2 int2 Int32 )
            value.Near                                      = GetSingle(new IntPtr(p + 0x110)); // 0x110 Near                        ( ModelPrimitiveType float float float Single )
            value.IsOrthographic                            = GetBool(new IntPtr(p + 0x114)); // 0x114 IsOrthographic              ( ModelPrimitiveType bool bool bool Bool )
            value.M_TileYRange                              = (InclusiveRange)GetInt32(new IntPtr(p + 0x116)); // 0x116 M_TileYRange                ( ModelEnumType InclusiveRange InclusiveRange InclusiveRange Int32 )
            value.M_Offset                                  = GetInt32(new IntPtr(p + 0x11C)); // 0x11C M_Offset                    ( ModelPrimitiveType int int int Int32 )
            value.M_ViewIndex                               = GetInt32(new IntPtr(p + 0x120)); // 0x120 M_ViewIndex                 ( ModelPrimitiveType int int int Int32 )
            value.M_CenterOffset                            = (float2)GetInt32(new IntPtr(p + 0x124)); // 0x124 M_CenterOffset              ( ModelEnumType float2 float2 float2 Int32 )

            return value;
        }
    }
}
