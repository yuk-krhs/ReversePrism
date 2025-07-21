using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Mode                                     ModelEnumType Mode Mode Mode Int32
    // 024 Size                                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 OverrideRendererFilters                  ModelPrimitiveType bool bool bool Bool
    // 034 MinRendererVolumeSize                    ModelPrimitiveType float float float Single
    // 038 ObjectLayerMask                          ModelEnumType LayerMask LayerMask LayerMask Int32
    // 03C LowestSubdivLevelOverride                ModelPrimitiveType int int int Int32
    // 040 HighestSubdivLevelOverride               ModelPrimitiveType int int int Int32
    // 044 OverridesSubdivLevels                    ModelPrimitiveType bool bool bool Bool
    // 045 MightNeedRebaking                        ModelPrimitiveType bool bool bool Bool
    // 048 CachedTransform                          ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 088 CachedHashCode                           ModelPrimitiveType int int int Int32
    // 08C FillEmptySpaces                          ModelPrimitiveType bool bool bool Bool
    // 090 Version                                  ModelEnumType Version Version Version Int32
    // 094 GlobalVolume                             ModelPrimitiveType bool bool bool Bool
    public partial class ProbeVolume : DataModel
    {
        public Mode                                     Mode                                    { get; set; }
        public Vector3                                  Size                                    { get; set; }
        public bool                                     OverrideRendererFilters                 { get; set; }
        public float                                    MinRendererVolumeSize                   { get; set; }
        public LayerMask                                ObjectLayerMask                         { get; set; }
        public int                                      LowestSubdivLevelOverride               { get; set; }
        public int                                      HighestSubdivLevelOverride              { get; set; }
        public bool                                     OverridesSubdivLevels                   { get; set; }
        public bool                                     MightNeedRebaking                       { get; set; }
        public Matrix4x4                                CachedTransform                         { get; set; }
        public int                                      CachedHashCode                          { get; set; }
        public bool                                     FillEmptySpaces                         { get; set; }
        public Version                                  Version                                 { get; set; }
        public bool                                     GlobalVolume                            { get; set; }

        public static ProbeVolume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolume() { Pointer= p0 };

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x020)); // 0x20 Mode                        ( ModelEnumType Mode Mode Mode Int32 )
            value.Size                                      = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 Size                        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OverrideRendererFilters                   = GetBool(new IntPtr(p + 0x030)); // 0x30 OverrideRendererFilters     ( ModelPrimitiveType bool bool bool Bool )
            value.MinRendererVolumeSize                     = GetSingle(new IntPtr(p + 0x034)); // 0x34 MinRendererVolumeSize       ( ModelPrimitiveType float float float Single )
            value.ObjectLayerMask                           = (LayerMask)GetInt32(new IntPtr(p + 0x038)); // 0x38 ObjectLayerMask             ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.LowestSubdivLevelOverride                 = GetInt32(new IntPtr(p + 0x03C)); // 0x3C LowestSubdivLevelOverride   ( ModelPrimitiveType int int int Int32 )
            value.HighestSubdivLevelOverride                = GetInt32(new IntPtr(p + 0x040)); // 0x40 HighestSubdivLevelOverride  ( ModelPrimitiveType int int int Int32 )
            value.OverridesSubdivLevels                     = GetBool(new IntPtr(p + 0x044)); // 0x44 OverridesSubdivLevels       ( ModelPrimitiveType bool bool bool Bool )
            value.MightNeedRebaking                         = GetBool(new IntPtr(p + 0x045)); // 0x45 MightNeedRebaking           ( ModelPrimitiveType bool bool bool Bool )
            value.CachedTransform                           = (Matrix4x4)GetInt32(new IntPtr(p + 0x048)); // 0x48 CachedTransform             ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CachedHashCode                            = GetInt32(new IntPtr(p + 0x088)); // 0x88 CachedHashCode              ( ModelPrimitiveType int int int Int32 )
            value.FillEmptySpaces                           = GetBool(new IntPtr(p + 0x08C)); // 0x8C FillEmptySpaces             ( ModelPrimitiveType bool bool bool Bool )
            value.Version                                   = (Version)GetInt32(new IntPtr(p + 0x090)); // 0x90 Version                     ( ModelEnumType Version Version Version Int32 )
            value.GlobalVolume                              = GetBool(new IntPtr(p + 0x094)); // 0x94 GlobalVolume                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
