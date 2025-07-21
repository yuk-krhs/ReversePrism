using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prev                                     ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 Next                                     ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 GroupTransformAncestor                   ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 BoneTransformAncestor                    ModelClassType VisualElement VisualElement VisualElement Pointer
    // 030 PrevDirty                                ModelClassType VisualElement VisualElement VisualElement Pointer
    // 038 NextDirty                                ModelClassType VisualElement VisualElement VisualElement Pointer
    // 040 Flags                                    ModelEnumType RenderDataFlags RenderDataFlags RenderDataFlags Int32
    // 044 HierarchyDepth                           ModelPrimitiveType int int int Int32
    // 048 DirtiedValues                            ModelEnumType RenderDataDirtyTypes RenderDataDirtyTypes RenderDataDirtyTypes Int32
    // 04C DirtyID                                  ModelPrimitiveType uint uint uint UInt32
    // 050 FirstCommand                             ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 058 LastCommand                              ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 060 FirstClosingCommand                      ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 068 LastClosingCommand                       ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 070 IsInChain                                ModelPrimitiveType bool bool bool Bool
    // 071 IsHierarchyHidden                        ModelPrimitiveType bool bool bool Bool
    // 072 LocalFlipsWinding                        ModelPrimitiveType bool bool bool Bool
    // 073 LocalTransformScaleZero                  ModelPrimitiveType bool bool bool Bool
    // 074 WorldFlipsWinding                        ModelPrimitiveType bool bool bool Bool
    // 075 WorldTransformScaleZero                  ModelPrimitiveType bool bool bool Bool
    // 078 ClipMethod                               ModelEnumType ClipMethod ClipMethod ClipMethod Int32
    // 07C ChildrenStencilRef                       ModelPrimitiveType int int int Int32
    // 080 ChildrenMaskDepth                        ModelPrimitiveType int int int Int32
    // 084 DisableNudging                           ModelPrimitiveType bool bool bool Bool
    // 088 Data                                     ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 090 ClosingData                              ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 098 VerticesSpace                            ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0D8 DisplacementUVStart                      ModelPrimitiveType int int int Int32
    // 0DC DisplacementUVEnd                        ModelPrimitiveType int int int Int32
    // 0E0 TransformID                              ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0E8 ClipRectID                               ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0F0 OpacityID                                ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0F8 TextCoreSettingsID                       ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 100 ColorID                                  ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 108 BackgroundColorID                        ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 110 BorderLeftColorID                        ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 118 BorderTopColorID                         ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 120 BorderRightColorID                       ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 128 BorderBottomColorID                      ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 130 TintColorID                              ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 138 CompositeOpacity                         ModelPrimitiveType float float float Single
    // 13C BackgroundColor                          ModelEnumType Color Color Color Int32
    // 150 textures                                 BasicNode`1<TextureEntry> IL2CPP_TYPE_GENERICINST
    public partial class RenderChainVEData : DataModel
    {
        public VisualElement?                           Prev                                    { get; set; }
        public VisualElement?                           Next                                    { get; set; }
        public VisualElement?                           GroupTransformAncestor                  { get; set; }
        public VisualElement?                           BoneTransformAncestor                   { get; set; }
        public VisualElement?                           PrevDirty                               { get; set; }
        public VisualElement?                           NextDirty                               { get; set; }
        public RenderDataFlags                          Flags                                   { get; set; }
        public int                                      HierarchyDepth                          { get; set; }
        public RenderDataDirtyTypes                     DirtiedValues                           { get; set; }
        public uint                                     DirtyID                                 { get; set; }
        public RenderChainCommand?                      FirstCommand                            { get; set; }
        public RenderChainCommand?                      LastCommand                             { get; set; }
        public RenderChainCommand?                      FirstClosingCommand                     { get; set; }
        public RenderChainCommand?                      LastClosingCommand                      { get; set; }
        public bool                                     IsInChain                               { get; set; }
        public bool                                     IsHierarchyHidden                       { get; set; }
        public bool                                     LocalFlipsWinding                       { get; set; }
        public bool                                     LocalTransformScaleZero                 { get; set; }
        public bool                                     WorldFlipsWinding                       { get; set; }
        public bool                                     WorldTransformScaleZero                 { get; set; }
        public ClipMethod                               ClipMethod                              { get; set; }
        public int                                      ChildrenStencilRef                      { get; set; }
        public int                                      ChildrenMaskDepth                       { get; set; }
        public bool                                     DisableNudging                          { get; set; }
        public MeshHandle?                              Data                                    { get; set; }
        public MeshHandle?                              ClosingData                             { get; set; }
        public Matrix4x4                                VerticesSpace                           { get; set; }
        public int                                      DisplacementUVStart                     { get; set; }
        public int                                      DisplacementUVEnd                       { get; set; }
        public BMPAlloc                                 TransformID                             { get; set; }
        public BMPAlloc                                 ClipRectID                              { get; set; }
        public BMPAlloc                                 OpacityID                               { get; set; }
        public BMPAlloc                                 TextCoreSettingsID                      { get; set; }
        public BMPAlloc                                 ColorID                                 { get; set; }
        public BMPAlloc                                 BackgroundColorID                       { get; set; }
        public BMPAlloc                                 BorderLeftColorID                       { get; set; }
        public BMPAlloc                                 BorderTopColorID                        { get; set; }
        public BMPAlloc                                 BorderRightColorID                      { get; set; }
        public BMPAlloc                                 BorderBottomColorID                     { get; set; }
        public BMPAlloc                                 TintColorID                             { get; set; }
        public float                                    CompositeOpacity                        { get; set; }
        public Color                                    BackgroundColor                         { get; set; }

        public static RenderChainVEData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderChainVEData() { Pointer= p0 };

            value.Prev                                      = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 Prev                        ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Next                                      = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 Next                        ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.GroupTransformAncestor                    = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 0x20 GroupTransformAncestor      ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.BoneTransformAncestor                     = GetObject<VisualElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.VisualElement.FromPointer); // 0x28 BoneTransformAncestor       ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.PrevDirty                                 = GetObject<VisualElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.VisualElement.FromPointer); // 0x30 PrevDirty                   ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.NextDirty                                 = GetObject<VisualElement>(new IntPtr(p + 0x038), ReversePrism.DataModels.VisualElement.FromPointer); // 0x38 NextDirty                   ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Flags                                     = (RenderDataFlags)GetInt32(new IntPtr(p + 0x040)); // 0x40 Flags                       ( ModelEnumType RenderDataFlags RenderDataFlags RenderDataFlags Int32 )
            value.HierarchyDepth                            = GetInt32(new IntPtr(p + 0x044)); // 0x44 HierarchyDepth              ( ModelPrimitiveType int int int Int32 )
            value.DirtiedValues                             = (RenderDataDirtyTypes)GetInt32(new IntPtr(p + 0x048)); // 0x48 DirtiedValues               ( ModelEnumType RenderDataDirtyTypes RenderDataDirtyTypes RenderDataDirtyTypes Int32 )
            value.DirtyID                                   = GetUInt32(new IntPtr(p + 0x04C)); // 0x4C DirtyID                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.FirstCommand                              = GetObject<RenderChainCommand>(new IntPtr(p + 0x050), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x50 FirstCommand                ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.LastCommand                               = GetObject<RenderChainCommand>(new IntPtr(p + 0x058), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x58 LastCommand                 ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.FirstClosingCommand                       = GetObject<RenderChainCommand>(new IntPtr(p + 0x060), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x60 FirstClosingCommand         ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.LastClosingCommand                        = GetObject<RenderChainCommand>(new IntPtr(p + 0x068), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x68 LastClosingCommand          ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.IsInChain                                 = GetBool(new IntPtr(p + 0x070)); // 0x70 IsInChain                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsHierarchyHidden                         = GetBool(new IntPtr(p + 0x071)); // 0x71 IsHierarchyHidden           ( ModelPrimitiveType bool bool bool Bool )
            value.LocalFlipsWinding                         = GetBool(new IntPtr(p + 0x072)); // 0x72 LocalFlipsWinding           ( ModelPrimitiveType bool bool bool Bool )
            value.LocalTransformScaleZero                   = GetBool(new IntPtr(p + 0x073)); // 0x73 LocalTransformScaleZero     ( ModelPrimitiveType bool bool bool Bool )
            value.WorldFlipsWinding                         = GetBool(new IntPtr(p + 0x074)); // 0x74 WorldFlipsWinding           ( ModelPrimitiveType bool bool bool Bool )
            value.WorldTransformScaleZero                   = GetBool(new IntPtr(p + 0x075)); // 0x75 WorldTransformScaleZero     ( ModelPrimitiveType bool bool bool Bool )
            value.ClipMethod                                = (ClipMethod)GetInt32(new IntPtr(p + 0x078)); // 0x78 ClipMethod                  ( ModelEnumType ClipMethod ClipMethod ClipMethod Int32 )
            value.ChildrenStencilRef                        = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ChildrenStencilRef          ( ModelPrimitiveType int int int Int32 )
            value.ChildrenMaskDepth                         = GetInt32(new IntPtr(p + 0x080)); // 0x80 ChildrenMaskDepth           ( ModelPrimitiveType int int int Int32 )
            value.DisableNudging                            = GetBool(new IntPtr(p + 0x084)); // 0x84 DisableNudging              ( ModelPrimitiveType bool bool bool Bool )
            value.Data                                      = GetObject<MeshHandle>(new IntPtr(p + 0x088), ReversePrism.DataModels.MeshHandle.FromPointer); // 0x88 Data                        ( ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.ClosingData                               = GetObject<MeshHandle>(new IntPtr(p + 0x090), ReversePrism.DataModels.MeshHandle.FromPointer); // 0x90 ClosingData                 ( ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.VerticesSpace                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x098)); // 0x98 VerticesSpace               ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.DisplacementUVStart                       = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 DisplacementUVStart         ( ModelPrimitiveType int int int Int32 )
            value.DisplacementUVEnd                         = GetInt32(new IntPtr(p + 0x0DC)); // 0xDC DisplacementUVEnd           ( ModelPrimitiveType int int int Int32 )
            value.TransformID                               = (BMPAlloc)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 TransformID                 ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.ClipRectID                                = (BMPAlloc)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 ClipRectID                  ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.OpacityID                                 = (BMPAlloc)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 OpacityID                   ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.TextCoreSettingsID                        = (BMPAlloc)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 TextCoreSettingsID          ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.ColorID                                   = (BMPAlloc)GetInt32(new IntPtr(p + 0x100)); // 0x100 ColorID                     ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BackgroundColorID                         = (BMPAlloc)GetInt32(new IntPtr(p + 0x108)); // 0x108 BackgroundColorID           ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderLeftColorID                         = (BMPAlloc)GetInt32(new IntPtr(p + 0x110)); // 0x110 BorderLeftColorID           ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderTopColorID                          = (BMPAlloc)GetInt32(new IntPtr(p + 0x118)); // 0x118 BorderTopColorID            ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderRightColorID                        = (BMPAlloc)GetInt32(new IntPtr(p + 0x120)); // 0x120 BorderRightColorID          ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderBottomColorID                       = (BMPAlloc)GetInt32(new IntPtr(p + 0x128)); // 0x128 BorderBottomColorID         ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.TintColorID                               = (BMPAlloc)GetInt32(new IntPtr(p + 0x130)); // 0x130 TintColorID                 ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.CompositeOpacity                          = GetSingle(new IntPtr(p + 0x138)); // 0x138 CompositeOpacity            ( ModelPrimitiveType float float float Single )
            value.BackgroundColor                           = (Color)GetInt32(new IntPtr(p + 0x13C)); // 0x13C BackgroundColor             ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
