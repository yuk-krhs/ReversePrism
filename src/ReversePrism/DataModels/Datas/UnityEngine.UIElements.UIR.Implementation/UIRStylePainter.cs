using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Owner                                  00018664F650 ModelClassType RenderChain RenderChain RenderChain Pointer
    // 018 M_Entries                                000185D2F528 ModelEnumListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    // 020 M_Atlas                                  00018670BF90 ModelClassType AtlasBase AtlasBase AtlasBase Pointer
    // 028 M_VectorImageManager                     000186509820 ModelClassType VectorImageManager VectorImageManager VectorImageManager Pointer
    // 030 M_CurrentEntry                           000186660C10 ModelEnumType Entry Entry Entry Int32
    // 080 M_ClosingInfo                            000186660760 ModelEnumType ClosingInfo ClosingInfo ClosingInfo Int32
    // 0B8 M_MaskDepth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0BC M_StencilRef                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C0 M_ClipRectID                             000186732230 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 0C8 M_SVGBackgroundEntryIndex                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 m_VertsPool                              TempAllocator`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 0D8 m_IndicesPool                            TempAllocator`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0E0 M_MeshWriteDataPool                      000185CF3288 ModelClassListType List`1<MeshWriteData> List`1<MeshWriteData> List<MeshWriteData> Pointer
    // 0E8 M_NextMeshWriteDataPoolItem              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0F0 m_RepeatRectUVList                       List`1<RepeatRectUV>[] IL2CPP_TYPE_SZARRAY
    // 0F8 M_AllocRawVertsIndicesDelegate           00018653AFD0 ModelClassType Allocator Allocator Allocator Pointer
    // 100 M_AllocThroughDrawMeshDelegate           00018653AFD0 ModelClassType Allocator Allocator Allocator Pointer
    // 108 MeshGenerationContext                    000186601AD0 ModelClassType MeshGenerationContext MeshGenerationContext MeshGenerationContext Pointer
    // 110 CurrentElement                           0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 118 TotalVertices                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 11C TotalIndices                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 120 M_TextInfo                               00018663E490 ModelClassType TextInfo TextInfo TextInfo Pointer
    public partial class UIRStylePainter
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
            var value   = new UIRStylePainter();

            value.M_Owner                                   = GetObject<RenderChain>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderChain.FromPointer); // 02700687F428 0x10 M_Owner                     ( 00018664F650 ModelClassType RenderChain RenderChain RenderChain Pointer )
            value.M_Entries                                 = GetEnumList<Entry>(new IntPtr(p + 0x018)); // 02700687F448 0x18 M_Entries                   ( 000185D2F528 ModelEnumListType List`1<Entry> List`1<Entry> List<Entry> Pointer )
            value.M_Atlas                                   = GetObject<AtlasBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.AtlasBase.FromPointer); // 02700687F468 0x20 M_Atlas                     ( 00018670BF90 ModelClassType AtlasBase AtlasBase AtlasBase Pointer )
            value.M_VectorImageManager                      = GetObject<VectorImageManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.VectorImageManager.FromPointer); // 02700687F488 0x28 M_VectorImageManager        ( 000186509820 ModelClassType VectorImageManager VectorImageManager VectorImageManager Pointer )
            value.M_CurrentEntry                            = (Entry)GetInt32(new IntPtr(p + 0x030)); // 02700687F4A8 0x30 M_CurrentEntry              ( 000186660C10 ModelEnumType Entry Entry Entry Int32 )
            value.M_ClosingInfo                             = (ClosingInfo)GetInt32(new IntPtr(p + 0x080)); // 02700687F4C8 0x80 M_ClosingInfo               ( 000186660760 ModelEnumType ClosingInfo ClosingInfo ClosingInfo Int32 )
            value.M_MaskDepth                               = GetInt32(new IntPtr(p + 0x0B8)); // 02700687F4E8 0xB8 M_MaskDepth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_StencilRef                              = GetInt32(new IntPtr(p + 0x0BC)); // 02700687F508 0xBC M_StencilRef                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ClipRectID                              = (BMPAlloc)GetInt32(new IntPtr(p + 0x0C0)); // 02700687F528 0xC0 M_ClipRectID                ( 000186732230 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.M_SVGBackgroundEntryIndex                 = GetInt32(new IntPtr(p + 0x0C8)); // 02700687F548 0xC8 M_SVGBackgroundEntryIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MeshWriteDataPool                       = GetObjectList<MeshWriteData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.MeshWriteData.FromPointer); // 02700687F5A8 0xE0 M_MeshWriteDataPool         ( 000185CF3288 ModelClassListType List`1<MeshWriteData> List`1<MeshWriteData> List<MeshWriteData> Pointer )
            value.M_NextMeshWriteDataPoolItem               = GetInt32(new IntPtr(p + 0x0E8)); // 02700687F5C8 0xE8 M_NextMeshWriteDataPoolItem ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_AllocRawVertsIndicesDelegate            = GetObject<Allocator>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Allocator.FromPointer); // 02700687F608 0xF8 M_AllocRawVertsIndicesDelegate ( 00018653AFD0 ModelClassType Allocator Allocator Allocator Pointer )
            value.M_AllocThroughDrawMeshDelegate            = GetObject<Allocator>(new IntPtr(p + 0x100), ReversePrism.DataModels.Allocator.FromPointer); // 02700687F628 0x100 M_AllocThroughDrawMeshDelegate ( 00018653AFD0 ModelClassType Allocator Allocator Allocator Pointer )
            value.MeshGenerationContext                     = GetObject<MeshGenerationContext>(new IntPtr(p + 0x108), ReversePrism.DataModels.MeshGenerationContext.FromPointer); // 02700687F648 0x108 MeshGenerationContext       ( 000186601AD0 ModelClassType MeshGenerationContext MeshGenerationContext MeshGenerationContext Pointer )
            value.CurrentElement                            = GetObject<VisualElement>(new IntPtr(p + 0x110), ReversePrism.DataModels.VisualElement.FromPointer); // 02700687F668 0x110 CurrentElement              ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.TotalVertices                             = GetInt32(new IntPtr(p + 0x118)); // 02700687F688 0x118 TotalVertices               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalIndices                              = GetInt32(new IntPtr(p + 0x11C)); // 02700687F6A8 0x11C TotalIndices                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_TextInfo                                = GetObject<TextInfo>(new IntPtr(p + 0x120), ReversePrism.DataModels.TextInfo.FromPointer); // 02700687F6C8 0x120 M_TextInfo                  ( 00018663E490 ModelClassType TextInfo TextInfo TextInfo Pointer )

            return value;
        }
    }
}
