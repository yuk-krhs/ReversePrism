using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flag                                     ModelEnumType BitField64 BitField64 BitField64 Int32
    // 018 UpdateMode                               ModelEnumType ClothUpdateMode ClothUpdateMode ClothUpdateMode Int32
    // 01C FrameDeltaTime                           ModelPrimitiveType float float float Single
    // 020 Time                                     ModelPrimitiveType float float float Single
    // 024 OldTime                                  ModelPrimitiveType float float float Single
    // 028 NowUpdateTime                            ModelPrimitiveType float float float Single
    // 02C OldUpdateTime                            ModelPrimitiveType float float float Single
    // 030 FrameUpdateTime                          ModelPrimitiveType float float float Single
    // 034 FrameOldTime                             ModelPrimitiveType float float float Single
    // 038 TimeScale                                ModelPrimitiveType float float float Single
    // 03C NowTimeScale                             ModelPrimitiveType float float float Single
    // 040 UpdateCount                              ModelPrimitiveType int int int Int32
    // 044 SkipCount                                ModelPrimitiveType int int int Int32
    // 048 FrameInterpolation                       ModelPrimitiveType float float float Single
    // 04C GravityRatio                             ModelPrimitiveType float float float Single
    // 050 GravityDot                               ModelPrimitiveType float float float Single
    // 054 CenterTransformIndex                     ModelPrimitiveType int int int Int32
    // 058 AnchorTransformId                        ModelPrimitiveType int int int Int32
    // 05C InitScale                                ModelEnumType float3 float3 float3 Int32
    // 068 ScaleRatio                               ModelPrimitiveType float float float Single
    // 06C SyncTeamId                               ModelPrimitiveType int int int Int32
    // 070 syncParentTeamId                         FixedList32Bytes`1<int> IL2CPP_TYPE_GENERICINST
    // 090 SyncCenterTransformIndex                 ModelPrimitiveType int int int Int32
    // 094 AnimationPoseRatio                       ModelPrimitiveType float float float Single
    // 098 VelocityWeight                           ModelPrimitiveType float float float Single
    // 09C BlendWeight                              ModelPrimitiveType float float float Single
    // 0A0 ForceMode                                ModelEnumType ClothForceMode ClothForceMode ClothForceMode Int32
    // 0A4 ImpactForce                              ModelEnumType float3 float3 float3 Int32
    // 0B0 ProxyMeshType                            ModelEnumType MeshType MeshType MeshType Int32
    // 0B4 ProxyTransformChunk                      ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0BC ProxyCommonChunk                         ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0C4 ProxyVertexChildDataChunk                ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0CC ProxyTriangleChunk                       ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0D4 ProxyEdgeChunk                           ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0DC ProxyMeshChunk                           ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0E4 ProxyBoneChunk                           ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0EC ProxySkinBoneChunk                       ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0F4 BaseLineChunk                            ModelEnumType DataChunk DataChunk DataChunk Int32
    // 0FC BaseLineDataChunk                        ModelEnumType DataChunk DataChunk DataChunk Int32
    // 104 FixedDataChunk                           ModelEnumType DataChunk DataChunk DataChunk Int32
    // 10C ParticleChunk                            ModelEnumType DataChunk DataChunk DataChunk Int32
    // 114 ColliderChunk                            ModelEnumType DataChunk DataChunk DataChunk Int32
    // 11C ColliderTransformChunk                   ModelEnumType DataChunk DataChunk DataChunk Int32
    // 124 ColliderCount                            ModelPrimitiveType int int int Int32
    // 128 DistanceStartChunk                       ModelEnumType DataChunk DataChunk DataChunk Int32
    // 130 DistanceDataChunk                        ModelEnumType DataChunk DataChunk DataChunk Int32
    // 138 BendingPairChunk                         ModelEnumType DataChunk DataChunk DataChunk Int32
    // 140 BendingWriteIndexChunk                   ModelEnumType DataChunk DataChunk DataChunk Int32
    // 148 BendingBufferChunk                       ModelEnumType DataChunk DataChunk DataChunk Int32
    // 150 SelfPointChunk                           ModelEnumType DataChunk DataChunk DataChunk Int32
    // 158 SelfEdgeChunk                            ModelEnumType DataChunk DataChunk DataChunk Int32
    // 160 SelfTriangleChunk                        ModelEnumType DataChunk DataChunk DataChunk Int32
    public partial class TeamData : DataModel
    {
        public BitField64                               Flag                                    { get; set; }
        public ClothUpdateMode                          UpdateMode                              { get; set; }
        public float                                    FrameDeltaTime                          { get; set; }
        public float                                    Time                                    { get; set; }
        public float                                    OldTime                                 { get; set; }
        public float                                    NowUpdateTime                           { get; set; }
        public float                                    OldUpdateTime                           { get; set; }
        public float                                    FrameUpdateTime                         { get; set; }
        public float                                    FrameOldTime                            { get; set; }
        public float                                    TimeScale                               { get; set; }
        public float                                    NowTimeScale                            { get; set; }
        public int                                      UpdateCount                             { get; set; }
        public int                                      SkipCount                               { get; set; }
        public float                                    FrameInterpolation                      { get; set; }
        public float                                    GravityRatio                            { get; set; }
        public float                                    GravityDot                              { get; set; }
        public int                                      CenterTransformIndex                    { get; set; }
        public int                                      AnchorTransformId                       { get; set; }
        public float3                                   InitScale                               { get; set; }
        public float                                    ScaleRatio                              { get; set; }
        public int                                      SyncTeamId                              { get; set; }
        public int                                      SyncCenterTransformIndex                { get; set; }
        public float                                    AnimationPoseRatio                      { get; set; }
        public float                                    VelocityWeight                          { get; set; }
        public float                                    BlendWeight                             { get; set; }
        public ClothForceMode                           ForceMode                               { get; set; }
        public float3                                   ImpactForce                             { get; set; }
        public MeshType                                 ProxyMeshType                           { get; set; }
        public DataChunk                                ProxyTransformChunk                     { get; set; }
        public DataChunk                                ProxyCommonChunk                        { get; set; }
        public DataChunk                                ProxyVertexChildDataChunk               { get; set; }
        public DataChunk                                ProxyTriangleChunk                      { get; set; }
        public DataChunk                                ProxyEdgeChunk                          { get; set; }
        public DataChunk                                ProxyMeshChunk                          { get; set; }
        public DataChunk                                ProxyBoneChunk                          { get; set; }
        public DataChunk                                ProxySkinBoneChunk                      { get; set; }
        public DataChunk                                BaseLineChunk                           { get; set; }
        public DataChunk                                BaseLineDataChunk                       { get; set; }
        public DataChunk                                FixedDataChunk                          { get; set; }
        public DataChunk                                ParticleChunk                           { get; set; }
        public DataChunk                                ColliderChunk                           { get; set; }
        public DataChunk                                ColliderTransformChunk                  { get; set; }
        public int                                      ColliderCount                           { get; set; }
        public DataChunk                                DistanceStartChunk                      { get; set; }
        public DataChunk                                DistanceDataChunk                       { get; set; }
        public DataChunk                                BendingPairChunk                        { get; set; }
        public DataChunk                                BendingWriteIndexChunk                  { get; set; }
        public DataChunk                                BendingBufferChunk                      { get; set; }
        public DataChunk                                SelfPointChunk                          { get; set; }
        public DataChunk                                SelfEdgeChunk                           { get; set; }
        public DataChunk                                SelfTriangleChunk                       { get; set; }

        public static TeamData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TeamData() { Pointer= p0 };

            value.Flag                                      = (BitField64)GetInt32(new IntPtr(p + 0x010)); // 0x10 Flag                        ( ModelEnumType BitField64 BitField64 BitField64 Int32 )
            value.UpdateMode                                = (ClothUpdateMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 UpdateMode                  ( ModelEnumType ClothUpdateMode ClothUpdateMode ClothUpdateMode Int32 )
            value.FrameDeltaTime                            = GetSingle(new IntPtr(p + 0x01C)); // 0x1C FrameDeltaTime              ( ModelPrimitiveType float float float Single )
            value.Time                                      = GetSingle(new IntPtr(p + 0x020)); // 0x20 Time                        ( ModelPrimitiveType float float float Single )
            value.OldTime                                   = GetSingle(new IntPtr(p + 0x024)); // 0x24 OldTime                     ( ModelPrimitiveType float float float Single )
            value.NowUpdateTime                             = GetSingle(new IntPtr(p + 0x028)); // 0x28 NowUpdateTime               ( ModelPrimitiveType float float float Single )
            value.OldUpdateTime                             = GetSingle(new IntPtr(p + 0x02C)); // 0x2C OldUpdateTime               ( ModelPrimitiveType float float float Single )
            value.FrameUpdateTime                           = GetSingle(new IntPtr(p + 0x030)); // 0x30 FrameUpdateTime             ( ModelPrimitiveType float float float Single )
            value.FrameOldTime                              = GetSingle(new IntPtr(p + 0x034)); // 0x34 FrameOldTime                ( ModelPrimitiveType float float float Single )
            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 TimeScale                   ( ModelPrimitiveType float float float Single )
            value.NowTimeScale                              = GetSingle(new IntPtr(p + 0x03C)); // 0x3C NowTimeScale                ( ModelPrimitiveType float float float Single )
            value.UpdateCount                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 UpdateCount                 ( ModelPrimitiveType int int int Int32 )
            value.SkipCount                                 = GetInt32(new IntPtr(p + 0x044)); // 0x44 SkipCount                   ( ModelPrimitiveType int int int Int32 )
            value.FrameInterpolation                        = GetSingle(new IntPtr(p + 0x048)); // 0x48 FrameInterpolation          ( ModelPrimitiveType float float float Single )
            value.GravityRatio                              = GetSingle(new IntPtr(p + 0x04C)); // 0x4C GravityRatio                ( ModelPrimitiveType float float float Single )
            value.GravityDot                                = GetSingle(new IntPtr(p + 0x050)); // 0x50 GravityDot                  ( ModelPrimitiveType float float float Single )
            value.CenterTransformIndex                      = GetInt32(new IntPtr(p + 0x054)); // 0x54 CenterTransformIndex        ( ModelPrimitiveType int int int Int32 )
            value.AnchorTransformId                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 AnchorTransformId           ( ModelPrimitiveType int int int Int32 )
            value.InitScale                                 = (float3)GetInt32(new IntPtr(p + 0x05C)); // 0x5C InitScale                   ( ModelEnumType float3 float3 float3 Int32 )
            value.ScaleRatio                                = GetSingle(new IntPtr(p + 0x068)); // 0x68 ScaleRatio                  ( ModelPrimitiveType float float float Single )
            value.SyncTeamId                                = GetInt32(new IntPtr(p + 0x06C)); // 0x6C SyncTeamId                  ( ModelPrimitiveType int int int Int32 )
            value.SyncCenterTransformIndex                  = GetInt32(new IntPtr(p + 0x090)); // 0x90 SyncCenterTransformIndex    ( ModelPrimitiveType int int int Int32 )
            value.AnimationPoseRatio                        = GetSingle(new IntPtr(p + 0x094)); // 0x94 AnimationPoseRatio          ( ModelPrimitiveType float float float Single )
            value.VelocityWeight                            = GetSingle(new IntPtr(p + 0x098)); // 0x98 VelocityWeight              ( ModelPrimitiveType float float float Single )
            value.BlendWeight                               = GetSingle(new IntPtr(p + 0x09C)); // 0x9C BlendWeight                 ( ModelPrimitiveType float float float Single )
            value.ForceMode                                 = (ClothForceMode)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ForceMode                   ( ModelEnumType ClothForceMode ClothForceMode ClothForceMode Int32 )
            value.ImpactForce                               = (float3)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 ImpactForce                 ( ModelEnumType float3 float3 float3 Int32 )
            value.ProxyMeshType                             = (MeshType)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ProxyMeshType               ( ModelEnumType MeshType MeshType MeshType Int32 )
            value.ProxyTransformChunk                       = (DataChunk)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 ProxyTransformChunk         ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxyCommonChunk                          = (DataChunk)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC ProxyCommonChunk            ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxyVertexChildDataChunk                 = (DataChunk)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 ProxyVertexChildDataChunk   ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxyTriangleChunk                        = (DataChunk)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC ProxyTriangleChunk          ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxyEdgeChunk                            = (DataChunk)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 ProxyEdgeChunk              ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxyMeshChunk                            = (DataChunk)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC ProxyMeshChunk              ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxyBoneChunk                            = (DataChunk)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 ProxyBoneChunk              ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ProxySkinBoneChunk                        = (DataChunk)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC ProxySkinBoneChunk          ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.BaseLineChunk                             = (DataChunk)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 BaseLineChunk               ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.BaseLineDataChunk                         = (DataChunk)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC BaseLineDataChunk           ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.FixedDataChunk                            = (DataChunk)GetInt32(new IntPtr(p + 0x104)); // 0x104 FixedDataChunk              ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ParticleChunk                             = (DataChunk)GetInt32(new IntPtr(p + 0x10C)); // 0x10C ParticleChunk               ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ColliderChunk                             = (DataChunk)GetInt32(new IntPtr(p + 0x114)); // 0x114 ColliderChunk               ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ColliderTransformChunk                    = (DataChunk)GetInt32(new IntPtr(p + 0x11C)); // 0x11C ColliderTransformChunk      ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.ColliderCount                             = GetInt32(new IntPtr(p + 0x124)); // 0x124 ColliderCount               ( ModelPrimitiveType int int int Int32 )
            value.DistanceStartChunk                        = (DataChunk)GetInt32(new IntPtr(p + 0x128)); // 0x128 DistanceStartChunk          ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.DistanceDataChunk                         = (DataChunk)GetInt32(new IntPtr(p + 0x130)); // 0x130 DistanceDataChunk           ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.BendingPairChunk                          = (DataChunk)GetInt32(new IntPtr(p + 0x138)); // 0x138 BendingPairChunk            ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.BendingWriteIndexChunk                    = (DataChunk)GetInt32(new IntPtr(p + 0x140)); // 0x140 BendingWriteIndexChunk      ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.BendingBufferChunk                        = (DataChunk)GetInt32(new IntPtr(p + 0x148)); // 0x148 BendingBufferChunk          ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.SelfPointChunk                            = (DataChunk)GetInt32(new IntPtr(p + 0x150)); // 0x150 SelfPointChunk              ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.SelfEdgeChunk                             = (DataChunk)GetInt32(new IntPtr(p + 0x158)); // 0x158 SelfEdgeChunk               ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.SelfTriangleChunk                         = (DataChunk)GetInt32(new IntPtr(p + 0x160)); // 0x160 SelfTriangleChunk           ( ModelEnumType DataChunk DataChunk DataChunk Int32 )

            return value;
        }
    }
}
