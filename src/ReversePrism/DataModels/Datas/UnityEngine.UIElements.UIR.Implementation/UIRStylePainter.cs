using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Owner                                  ModelClassType RenderChain RenderChain RenderChain Pointer
    // 018 M_Entries                                ModelEnumListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    // 020 M_Atlas                                  ModelClassType AtlasBase AtlasBase AtlasBase Pointer
    // 028 M_VectorImageManager                     ModelClassType VectorImageManager VectorImageManager VectorImageManager Pointer
    // 030 M_CurrentEntry                           ModelEnumType Entry Entry Entry Int32
    // 080 M_ClosingInfo                            ModelEnumType ClosingInfo ClosingInfo ClosingInfo Int32
    // 0B8 M_MaskDepth                              ModelPrimitiveType int int int Int32
    // 0BC M_StencilRef                             ModelPrimitiveType int int int Int32
    // 0C0 M_ClipRectID                             ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0C8 M_SVGBackgroundEntryIndex                ModelPrimitiveType int int int Int32
    // 0D0 m_VertsPool                              TempAllocator`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 0D8 m_IndicesPool                            TempAllocator`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0E0 M_MeshWriteDataPool                      ModelClassListType List`1<MeshWriteData> List`1<MeshWriteData> List<MeshWriteData> Pointer
    // 0E8 M_NextMeshWriteDataPoolItem              ModelPrimitiveType int int int Int32
    // 0F0 m_RepeatRectUVList                       List`1<RepeatRectUV>[] IL2CPP_TYPE_SZARRAY
    // 0F8 M_AllocRawVertsIndicesDelegate           ModelClassType Allocator Allocator Allocator Pointer
    // 100 M_AllocThroughDrawMeshDelegate           ModelClassType Allocator Allocator Allocator Pointer
    // 108 MeshGenerationContext                    ModelClassType MeshGenerationContext MeshGenerationContext MeshGenerationContext Pointer
    // 110 CurrentElement                           ModelClassType VisualElement VisualElement VisualElement Pointer
    // 118 TotalVertices                            ModelPrimitiveType int int int Int32
    // 11C TotalIndices                             ModelPrimitiveType int int int Int32
    // 120 M_TextInfo                               ModelClassType TextInfo TextInfo TextInfo Pointer
    public partial class UIRStylePainter : DataModel
    {
        public RenderChain?                             M_Owner                                 { get; set; }
        public List<Entry>?                             M_Entries                               { get; set; }
        public AtlasBase?                               M_Atlas                                 { get; set; }
        public VectorImageManager?                      M_VectorImageManager                    { get; set; }
        public Entry                                    M_CurrentEntry                          { get; set; }
        public ClosingInfo                              M_ClosingInfo                           { get; set; }
        public int                                      M_MaskDepth                             { get; set; }
        public int                                      M_StencilRef                            { get; set; }
        public BMPAlloc                                 M_ClipRectID                            { get; set; }
        public int                                      M_SVGBackgroundEntryIndex               { get; set; }
        public List<MeshWriteData>?                     M_MeshWriteDataPool                     { get; set; }
        public int                                      M_NextMeshWriteDataPoolItem             { get; set; }
        public Allocator?                               M_AllocRawVertsIndicesDelegate          { get; set; }
        public Allocator?                               M_AllocThroughDrawMeshDelegate          { get; set; }
        public MeshGenerationContext?                   MeshGenerationContext                   { get; set; }
        public VisualElement?                           CurrentElement                          { get; set; }
        public int                                      TotalVertices                           { get; set; }
        public int                                      TotalIndices                            { get; set; }
        public TextInfo?                                M_TextInfo                              { get; set; }

        public static UIRStylePainter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRStylePainter() { Pointer= p0 };

            value.M_Owner                                   = GetObject<RenderChain>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderChain.FromPointer); // 0x10 M_Owner                     ( ModelClassType RenderChain RenderChain RenderChain Pointer )
            value.M_Entries                                 = GetEnumList<Entry>(new IntPtr(p + 0x018)); // 0x18 M_Entries                   ( ModelEnumListType List`1<Entry> List`1<Entry> List<Entry> Pointer )
            value.M_Atlas                                   = GetObject<AtlasBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.AtlasBase.FromPointer); // 0x20 M_Atlas                     ( ModelClassType AtlasBase AtlasBase AtlasBase Pointer )
            value.M_VectorImageManager                      = GetObject<VectorImageManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.VectorImageManager.FromPointer); // 0x28 M_VectorImageManager        ( ModelClassType VectorImageManager VectorImageManager VectorImageManager Pointer )
            value.M_CurrentEntry                            = (Entry)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_CurrentEntry              ( ModelEnumType Entry Entry Entry Int32 )
            value.M_ClosingInfo                             = (ClosingInfo)GetInt32(new IntPtr(p + 0x080)); // 0x80 M_ClosingInfo               ( ModelEnumType ClosingInfo ClosingInfo ClosingInfo Int32 )
            value.M_MaskDepth                               = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_MaskDepth                 ( ModelPrimitiveType int int int Int32 )
            value.M_StencilRef                              = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_StencilRef                ( ModelPrimitiveType int int int Int32 )
            value.M_ClipRectID                              = (BMPAlloc)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 M_ClipRectID                ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.M_SVGBackgroundEntryIndex                 = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_SVGBackgroundEntryIndex   ( ModelPrimitiveType int int int Int32 )
            value.M_MeshWriteDataPool                       = GetObjectList<MeshWriteData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.MeshWriteData.FromPointer); // 0xE0 M_MeshWriteDataPool         ( ModelClassListType List`1<MeshWriteData> List`1<MeshWriteData> List<MeshWriteData> Pointer )
            value.M_NextMeshWriteDataPoolItem               = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_NextMeshWriteDataPoolItem ( ModelPrimitiveType int int int Int32 )
            value.M_AllocRawVertsIndicesDelegate            = GetObject<Allocator>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Allocator.FromPointer); // 0xF8 M_AllocRawVertsIndicesDelegate ( ModelClassType Allocator Allocator Allocator Pointer )
            value.M_AllocThroughDrawMeshDelegate            = GetObject<Allocator>(new IntPtr(p + 0x100), ReversePrism.DataModels.Allocator.FromPointer); // 0x100 M_AllocThroughDrawMeshDelegate ( ModelClassType Allocator Allocator Allocator Pointer )
            value.MeshGenerationContext                     = GetObject<MeshGenerationContext>(new IntPtr(p + 0x108), ReversePrism.DataModels.MeshGenerationContext.FromPointer); // 0x108 MeshGenerationContext       ( ModelClassType MeshGenerationContext MeshGenerationContext MeshGenerationContext Pointer )
            value.CurrentElement                            = GetObject<VisualElement>(new IntPtr(p + 0x110), ReversePrism.DataModels.VisualElement.FromPointer); // 0x110 CurrentElement              ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.TotalVertices                             = GetInt32(new IntPtr(p + 0x118)); // 0x118 TotalVertices               ( ModelPrimitiveType int int int Int32 )
            value.TotalIndices                              = GetInt32(new IntPtr(p + 0x11C)); // 0x11C TotalIndices                ( ModelPrimitiveType int int int Int32 )
            value.M_TextInfo                                = GetObject<TextInfo>(new IntPtr(p + 0x120), ReversePrism.DataModels.TextInfo.FromPointer); // 0x120 M_TextInfo                  ( ModelClassType TextInfo TextInfo TextInfo Pointer )

            return value;
        }
    }
}
