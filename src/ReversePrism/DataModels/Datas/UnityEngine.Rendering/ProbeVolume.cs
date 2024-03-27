using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Mode                                     0001865B8330 ModelEnumType Mode Mode Mode Int32
    // 024 Size                                     0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 OverrideRendererFilters                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 034 MinRendererVolumeSize                    000186666050 ModelPrimitiveType float float float Single
    // 038 ObjectLayerMask                          00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 03C LowestSubdivLevelOverride                0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 HighestSubdivLevelOverride               0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 OverridesSubdivLevels                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 045 MightNeedRebaking                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 048 CachedTransform                          00018660DB20 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 088 CachedHashCode                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 08C FillEmptySpaces                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 090 Version                                  0001865B8A60 ModelEnumType Version Version Version Int32
    // 094 GlobalVolume                             000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ProbeVolume
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
            var value   = new ProbeVolume();

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x020)); // 0270D9220498 0x20 Mode                        ( 0001865B8330 ModelEnumType Mode Mode Mode Int32 )
            value.Size                                      = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0270D92204B8 0x24 Size                        ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OverrideRendererFilters                   = GetBool(new IntPtr(p + 0x030)); // 0270D92204D8 0x30 OverrideRendererFilters     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MinRendererVolumeSize                     = GetSingle(new IntPtr(p + 0x034)); // 0270D92204F8 0x34 MinRendererVolumeSize       ( 000186666050 ModelPrimitiveType float float float Single )
            value.ObjectLayerMask                           = (LayerMask)GetInt32(new IntPtr(p + 0x038)); // 0270D9220518 0x38 ObjectLayerMask             ( 00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.LowestSubdivLevelOverride                 = GetInt32(new IntPtr(p + 0x03C)); // 0270D9220538 0x3C LowestSubdivLevelOverride   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HighestSubdivLevelOverride                = GetInt32(new IntPtr(p + 0x040)); // 0270D9220558 0x40 HighestSubdivLevelOverride  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OverridesSubdivLevels                     = GetBool(new IntPtr(p + 0x044)); // 0270D9220578 0x44 OverridesSubdivLevels       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MightNeedRebaking                         = GetBool(new IntPtr(p + 0x045)); // 0270D9220598 0x45 MightNeedRebaking           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.CachedTransform                           = (Matrix4x4)GetInt32(new IntPtr(p + 0x048)); // 0270D92205B8 0x48 CachedTransform             ( 00018660DB20 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.CachedHashCode                            = GetInt32(new IntPtr(p + 0x088)); // 0270D92205D8 0x88 CachedHashCode              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.FillEmptySpaces                           = GetBool(new IntPtr(p + 0x08C)); // 0270D92205F8 0x8C FillEmptySpaces             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Version                                   = (Version)GetInt32(new IntPtr(p + 0x090)); // 0270D9220618 0x90 Version                     ( 0001865B8A60 ModelEnumType Version Version Version Int32 )
            value.GlobalVolume                              = GetBool(new IntPtr(p + 0x094)); // 0270D9220638 0x94 GlobalVolume                ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
