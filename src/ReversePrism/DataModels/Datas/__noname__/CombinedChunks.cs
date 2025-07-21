using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EntityChunk                              ModelClassType DecalEntityChunk DecalEntityChunk DecalEntityChunk Pointer
    // 018 CachedChunk                              ModelClassType DecalCachedChunk DecalCachedChunk DecalCachedChunk Pointer
    // 020 CulledChunk                              ModelClassType DecalCulledChunk DecalCulledChunk DecalCulledChunk Pointer
    // 028 DrawCallChunk                            ModelClassType DecalDrawCallChunk DecalDrawCallChunk DecalDrawCallChunk Pointer
    // 030 PreviousChunkIndex                       ModelPrimitiveType int int int Int32
    // 034 Valid                                    ModelPrimitiveType bool bool bool Bool
    public partial class CombinedChunks : DataModel
    {
        public DecalEntityChunk?                        EntityChunk                             { get; set; }
        public DecalCachedChunk?                        CachedChunk                             { get; set; }
        public DecalCulledChunk?                        CulledChunk                             { get; set; }
        public DecalDrawCallChunk?                      DrawCallChunk                           { get; set; }
        public int                                      PreviousChunkIndex                      { get; set; }
        public bool                                     Valid                                   { get; set; }

        public static CombinedChunks? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CombinedChunks() { Pointer= p0 };

            value.EntityChunk                               = GetObject<DecalEntityChunk>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecalEntityChunk.FromPointer); // 0x10 EntityChunk                 ( ModelClassType DecalEntityChunk DecalEntityChunk DecalEntityChunk Pointer )
            value.CachedChunk                               = GetObject<DecalCachedChunk>(new IntPtr(p + 0x018), ReversePrism.DataModels.DecalCachedChunk.FromPointer); // 0x18 CachedChunk                 ( ModelClassType DecalCachedChunk DecalCachedChunk DecalCachedChunk Pointer )
            value.CulledChunk                               = GetObject<DecalCulledChunk>(new IntPtr(p + 0x020), ReversePrism.DataModels.DecalCulledChunk.FromPointer); // 0x20 CulledChunk                 ( ModelClassType DecalCulledChunk DecalCulledChunk DecalCulledChunk Pointer )
            value.DrawCallChunk                             = GetObject<DecalDrawCallChunk>(new IntPtr(p + 0x028), ReversePrism.DataModels.DecalDrawCallChunk.FromPointer); // 0x28 DrawCallChunk               ( ModelClassType DecalDrawCallChunk DecalDrawCallChunk DecalDrawCallChunk Pointer )
            value.PreviousChunkIndex                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 PreviousChunkIndex          ( ModelPrimitiveType int int int Int32 )
            value.Valid                                     = GetBool(new IntPtr(p + 0x034)); // 0x34 Valid                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
