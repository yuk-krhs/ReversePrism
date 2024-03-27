using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prev                                     0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 Next                                     0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 GroupTransformAncestor                   0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 BoneTransformAncestor                    0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 030 PrevDirty                                0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 038 NextDirty                                0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 040 Flags                                    000186650ED0 ModelEnumType RenderDataFlags RenderDataFlags RenderDataFlags Int32
    // 044 HierarchyDepth                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 048 DirtiedValues                            000186650770 ModelEnumType RenderDataDirtyTypes RenderDataDirtyTypes RenderDataDirtyTypes Int32
    // 04C DirtyID                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 050 FirstCommand                             000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 058 LastCommand                              000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 060 FirstClosingCommand                      000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 068 LastClosingCommand                       000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 070 IsInChain                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 071 IsHierarchyHidden                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 072 LocalFlipsWinding                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 073 LocalTransformScaleZero                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 074 WorldFlipsWinding                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 078 ClipMethod                               0001865B9650 ModelEnumType ClipMethod ClipMethod ClipMethod Int32
    // 07C ChildrenStencilRef                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 080 ChildrenMaskDepth                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 084 DisableNudging                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 088 Data                                     000186611C80 ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 090 ClosingData                              000186611C80 ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 098 VerticesSpace                            00018660DB20 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0D8 DisplacementUVStart                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 0DC DisplacementUVEnd                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 0E0 TransformID                              000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0E8 ClipRectID                               000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0F0 OpacityID                                000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0F8 TextCoreSettingsID                       000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 100 ColorID                                  000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 108 BackgroundColorID                        000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 110 BorderLeftColorID                        000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 118 BorderTopColorID                         000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 120 BorderRightColorID                       000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 128 BorderBottomColorID                      000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 130 TintColorID                              000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 138 CompositeOpacity                         000186665900 ModelPrimitiveType float float float Single
    // 13C BackgroundColor                          0001865AABD0 ModelEnumType Color Color Color Int32
    // 150 textures                                 BasicNode`1<TextureEntry> IL2CPP_TYPE_GENERICINST
    public partial class RenderChainVEData
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
            var value   = new RenderChainVEData();

            value.Prev                                      = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F089D0 0x10 Prev                        ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Next                                      = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F089F0 0x18 Next                        ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.GroupTransformAncestor                    = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F08A10 0x20 GroupTransformAncestor      ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.BoneTransformAncestor                     = GetObject<VisualElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F08A30 0x28 BoneTransformAncestor       ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.PrevDirty                                 = GetObject<VisualElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F08A50 0x30 PrevDirty                   ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.NextDirty                                 = GetObject<VisualElement>(new IntPtr(p + 0x038), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F08A70 0x38 NextDirty                   ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Flags                                     = (RenderDataFlags)GetInt32(new IntPtr(p + 0x040)); // 027003F08A90 0x40 Flags                       ( 000186650ED0 ModelEnumType RenderDataFlags RenderDataFlags RenderDataFlags Int32 )
            value.HierarchyDepth                            = GetInt32(new IntPtr(p + 0x044)); // 027003F08AB0 0x44 HierarchyDepth              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DirtiedValues                             = (RenderDataDirtyTypes)GetInt32(new IntPtr(p + 0x048)); // 027003F08AD0 0x48 DirtiedValues               ( 000186650770 ModelEnumType RenderDataDirtyTypes RenderDataDirtyTypes RenderDataDirtyTypes Int32 )
            value.DirtyID                                   = GetUInt32(new IntPtr(p + 0x04C)); // 027003F08AF0 0x4C DirtyID                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.FirstCommand                              = GetObject<RenderChainCommand>(new IntPtr(p + 0x050), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027003F08B10 0x50 FirstCommand                ( 000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.LastCommand                               = GetObject<RenderChainCommand>(new IntPtr(p + 0x058), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027003F08B30 0x58 LastCommand                 ( 000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.FirstClosingCommand                       = GetObject<RenderChainCommand>(new IntPtr(p + 0x060), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027003F08B50 0x60 FirstClosingCommand         ( 000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.LastClosingCommand                        = GetObject<RenderChainCommand>(new IntPtr(p + 0x068), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027003F08B70 0x68 LastClosingCommand          ( 000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.IsInChain                                 = GetBool(new IntPtr(p + 0x070)); // 027003F08B90 0x70 IsInChain                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsHierarchyHidden                         = GetBool(new IntPtr(p + 0x071)); // 027003F08BB0 0x71 IsHierarchyHidden           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.LocalFlipsWinding                         = GetBool(new IntPtr(p + 0x072)); // 027003F08BD0 0x72 LocalFlipsWinding           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.LocalTransformScaleZero                   = GetBool(new IntPtr(p + 0x073)); // 027003F08BF0 0x73 LocalTransformScaleZero     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.WorldFlipsWinding                         = GetBool(new IntPtr(p + 0x074)); // 027003F08C10 0x74 WorldFlipsWinding           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ClipMethod                                = (ClipMethod)GetInt32(new IntPtr(p + 0x078)); // 027003F08C30 0x78 ClipMethod                  ( 0001865B9650 ModelEnumType ClipMethod ClipMethod ClipMethod Int32 )
            value.ChildrenStencilRef                        = GetInt32(new IntPtr(p + 0x07C)); // 027003F08C50 0x7C ChildrenStencilRef          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.ChildrenMaskDepth                         = GetInt32(new IntPtr(p + 0x080)); // 027003F08C70 0x80 ChildrenMaskDepth           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DisableNudging                            = GetBool(new IntPtr(p + 0x084)); // 027003F08C90 0x84 DisableNudging              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Data                                      = GetObject<MeshHandle>(new IntPtr(p + 0x088), ReversePrism.DataModels.MeshHandle.FromPointer); // 027003F08CB0 0x88 Data                        ( 000186611C80 ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.ClosingData                               = GetObject<MeshHandle>(new IntPtr(p + 0x090), ReversePrism.DataModels.MeshHandle.FromPointer); // 027003F08CD0 0x90 ClosingData                 ( 000186611C80 ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.VerticesSpace                             = (Matrix4x4)GetInt32(new IntPtr(p + 0x098)); // 027003F08CF0 0x98 VerticesSpace               ( 00018660DB20 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.DisplacementUVStart                       = GetInt32(new IntPtr(p + 0x0D8)); // 027003F08D10 0xD8 DisplacementUVStart         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DisplacementUVEnd                         = GetInt32(new IntPtr(p + 0x0DC)); // 027003F08D30 0xDC DisplacementUVEnd           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TransformID                               = (BMPAlloc)GetInt32(new IntPtr(p + 0x0E0)); // 027003F08D50 0xE0 TransformID                 ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.ClipRectID                                = (BMPAlloc)GetInt32(new IntPtr(p + 0x0E8)); // 027003F08D70 0xE8 ClipRectID                  ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.OpacityID                                 = (BMPAlloc)GetInt32(new IntPtr(p + 0x0F0)); // 027003F08D90 0xF0 OpacityID                   ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.TextCoreSettingsID                        = (BMPAlloc)GetInt32(new IntPtr(p + 0x0F8)); // 027003F08DB0 0xF8 TextCoreSettingsID          ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.ColorID                                   = (BMPAlloc)GetInt32(new IntPtr(p + 0x100)); // 027003F08DD0 0x100 ColorID                     ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BackgroundColorID                         = (BMPAlloc)GetInt32(new IntPtr(p + 0x108)); // 027003F08DF0 0x108 BackgroundColorID           ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderLeftColorID                         = (BMPAlloc)GetInt32(new IntPtr(p + 0x110)); // 027003F08E10 0x110 BorderLeftColorID           ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderTopColorID                          = (BMPAlloc)GetInt32(new IntPtr(p + 0x118)); // 027003F08E30 0x118 BorderTopColorID            ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderRightColorID                        = (BMPAlloc)GetInt32(new IntPtr(p + 0x120)); // 027003F08E50 0x120 BorderRightColorID          ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.BorderBottomColorID                       = (BMPAlloc)GetInt32(new IntPtr(p + 0x128)); // 027003F08E70 0x128 BorderBottomColorID         ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.TintColorID                               = (BMPAlloc)GetInt32(new IntPtr(p + 0x130)); // 027003F08E90 0x130 TintColorID                 ( 000186732510 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.CompositeOpacity                          = GetSingle(new IntPtr(p + 0x138)); // 027003F08EB0 0x138 CompositeOpacity            ( 000186665900 ModelPrimitiveType float float float Single )
            value.BackgroundColor                           = (Color)GetInt32(new IntPtr(p + 0x13C)); // 027003F08ED0 0x13C BackgroundColor             ( 0001865AABD0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
