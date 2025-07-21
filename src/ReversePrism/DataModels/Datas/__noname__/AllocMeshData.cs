using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Alloc                                    ModelClassType Allocator Allocator Allocator Pointer
    // 018 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 020 SvgTexture                               ModelEnumType TextureId TextureId TextureId Int32
    // 028 Material                                 ModelClassType Material Material Material Pointer
    // 030 Flags                                    ModelEnumType MeshFlags MeshFlags MeshFlags Int32
    // 034 ColorAlloc                               ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    public partial class AllocMeshData : DataModel
    {
        public Allocator?                               Alloc                                   { get; set; }
        public Texture?                                 Texture                                 { get; set; }
        public TextureId                                SvgTexture                              { get; set; }
        public Material?                                Material                                { get; set; }
        public MeshFlags                                Flags                                   { get; set; }
        public BMPAlloc                                 ColorAlloc                              { get; set; }

        public static AllocMeshData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllocMeshData() { Pointer= p0 };

            value.Alloc                                     = GetObject<Allocator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Allocator.FromPointer); // 0x10 Alloc                       ( ModelClassType Allocator Allocator Allocator Pointer )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture.FromPointer); // 0x18 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.SvgTexture                                = (TextureId)GetInt32(new IntPtr(p + 0x020)); // 0x20 SvgTexture                  ( ModelEnumType TextureId TextureId TextureId Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 Material                    ( ModelClassType Material Material Material Pointer )
            value.Flags                                     = (MeshFlags)GetInt32(new IntPtr(p + 0x030)); // 0x30 Flags                       ( ModelEnumType MeshFlags MeshFlags MeshFlags Int32 )
            value.ColorAlloc                                = (BMPAlloc)GetInt32(new IntPtr(p + 0x034)); // 0x34 ColorAlloc                  ( ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )

            return value;
        }
    }
}
