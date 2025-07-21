using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EntityChunks                             ModelClassListType List`1<DecalEntityChunk> List`1<DecalEntityChunk> List<DecalEntityChunk> Pointer
    // 018 CachedChunks                             ModelClassListType List`1<DecalCachedChunk> List`1<DecalCachedChunk> List<DecalCachedChunk> Pointer
    // 020 CulledChunks                             ModelClassListType List`1<DecalCulledChunk> List`1<DecalCulledChunk> List<DecalCulledChunk> Pointer
    // 028 DrawCallChunks                           ModelClassListType List`1<DecalDrawCallChunk> List`1<DecalDrawCallChunk> List<DecalDrawCallChunk> Pointer
    // 030 ChunkCount                               ModelPrimitiveType int int int Int32
    // 038 M_AddDecalSampler                        ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 040 M_ResizeChunks                           ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 048 M_SortChunks                             ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 050 M_DecalEntityIndexer                     ModelClassType DecalEntityIndexer DecalEntityIndexer DecalEntityIndexer Pointer
    // 058 m_MaterialToChunkIndex                   Dictionary`2<Material, int> IL2CPP_TYPE_GENERICINST
    // 060 M_CombinedChunks                         ModelEnumListType List`1<CombinedChunks> List`1<CombinedChunks> List<CombinedChunks> Pointer
    // 068 M_CombinedChunkRemmap                    ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 070 M_ErrorMaterial                          ModelClassType Material Material Material Pointer
    // 078 M_DecalProjectorMesh                     ModelClassType Mesh Mesh Mesh Pointer
    public partial class DecalEntityManager : DataModel
    {
        public List<DecalEntityChunk>?                  EntityChunks                            { get; set; }
        public List<DecalCachedChunk>?                  CachedChunks                            { get; set; }
        public List<DecalCulledChunk>?                  CulledChunks                            { get; set; }
        public List<DecalDrawCallChunk>?                DrawCallChunks                          { get; set; }
        public int                                      ChunkCount                              { get; set; }
        public ProfilingSampler?                        M_AddDecalSampler                       { get; set; }
        public ProfilingSampler?                        M_ResizeChunks                          { get; set; }
        public ProfilingSampler?                        M_SortChunks                            { get; set; }
        public DecalEntityIndexer?                      M_DecalEntityIndexer                    { get; set; }
        public List<CombinedChunks>?                    M_CombinedChunks                        { get; set; }
        public List<int>?                               M_CombinedChunkRemmap                   { get; set; }
        public Material?                                M_ErrorMaterial                         { get; set; }
        public Mesh?                                    M_DecalProjectorMesh                    { get; set; }

        public static DecalEntityManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalEntityManager() { Pointer= p0 };

            value.EntityChunks                              = GetObjectList<DecalEntityChunk>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecalEntityChunk.FromPointer); // 0x10 EntityChunks                ( ModelClassListType List`1<DecalEntityChunk> List`1<DecalEntityChunk> List<DecalEntityChunk> Pointer )
            value.CachedChunks                              = GetObjectList<DecalCachedChunk>(new IntPtr(p + 0x018), ReversePrism.DataModels.DecalCachedChunk.FromPointer); // 0x18 CachedChunks                ( ModelClassListType List`1<DecalCachedChunk> List`1<DecalCachedChunk> List<DecalCachedChunk> Pointer )
            value.CulledChunks                              = GetObjectList<DecalCulledChunk>(new IntPtr(p + 0x020), ReversePrism.DataModels.DecalCulledChunk.FromPointer); // 0x20 CulledChunks                ( ModelClassListType List`1<DecalCulledChunk> List`1<DecalCulledChunk> List<DecalCulledChunk> Pointer )
            value.DrawCallChunks                            = GetObjectList<DecalDrawCallChunk>(new IntPtr(p + 0x028), ReversePrism.DataModels.DecalDrawCallChunk.FromPointer); // 0x28 DrawCallChunks              ( ModelClassListType List`1<DecalDrawCallChunk> List`1<DecalDrawCallChunk> List<DecalDrawCallChunk> Pointer )
            value.ChunkCount                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 ChunkCount                  ( ModelPrimitiveType int int int Int32 )
            value.M_AddDecalSampler                         = GetObject<ProfilingSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x38 M_AddDecalSampler           ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ResizeChunks                            = GetObject<ProfilingSampler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x40 M_ResizeChunks              ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_SortChunks                              = GetObject<ProfilingSampler>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x48 M_SortChunks                ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_DecalEntityIndexer                      = GetObject<DecalEntityIndexer>(new IntPtr(p + 0x050), ReversePrism.DataModels.DecalEntityIndexer.FromPointer); // 0x50 M_DecalEntityIndexer        ( ModelClassType DecalEntityIndexer DecalEntityIndexer DecalEntityIndexer Pointer )
            value.M_CombinedChunks                          = GetEnumList<CombinedChunks>(new IntPtr(p + 0x060)); // 0x60 M_CombinedChunks            ( ModelEnumListType List`1<CombinedChunks> List`1<CombinedChunks> List<CombinedChunks> Pointer )
            value.M_CombinedChunkRemmap                     = GetInt32List(new IntPtr(p + 0x068)); // 0x68 M_CombinedChunkRemmap       ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_ErrorMaterial                           = GetObject<Material>(new IntPtr(p + 0x070), ReversePrism.DataModels.Material.FromPointer); // 0x70 M_ErrorMaterial             ( ModelClassType Material Material Material Pointer )
            value.M_DecalProjectorMesh                      = GetObject<Mesh>(new IntPtr(p + 0x078), ReversePrism.DataModels.Mesh.FromPointer); // 0x78 M_DecalProjectorMesh        ( ModelClassType Mesh Mesh Mesh Pointer )

            return value;
        }
    }
}
