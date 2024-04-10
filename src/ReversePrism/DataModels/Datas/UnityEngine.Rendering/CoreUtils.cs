using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lookAtList                               Vector3[] IL2CPP_TYPE_SZARRAY
    // 008 upVectorList                             Vector3[] IL2CPP_TYPE_SZARRAY
    // 000 obsoletePriorityMessage                  string IL2CPP_TYPE_STRING
    // 000 editMenuPriority1                        int IL2CPP_TYPE_I4
    // 000 editMenuPriority2                        int IL2CPP_TYPE_I4
    // 000 editMenuPriority3                        int IL2CPP_TYPE_I4
    // 000 editMenuPriority4                        int IL2CPP_TYPE_I4
    // 000 assetCreateMenuPriority1                 int IL2CPP_TYPE_I4
    // 000 assetCreateMenuPriority2                 int IL2CPP_TYPE_I4
    // 000 assetCreateMenuPriority3                 int IL2CPP_TYPE_I4
    // 000 gameObjectMenuPriority                   int IL2CPP_TYPE_I4
    // 010 M_BlackCubeTexture                       000186661D00 ModelClassType Cubemap Cubemap Cubemap Pointer
    // 018 M_MagentaCubeTexture                     000186661D00 ModelClassType Cubemap Cubemap Cubemap Pointer
    // 020 M_MagentaCubeTextureArray                0001866621E0 ModelClassType CubemapArray CubemapArray CubemapArray Pointer
    // 028 M_WhiteCubeTexture                       000186661D00 ModelClassType Cubemap Cubemap Cubemap Pointer
    // 030 M_EmptyUAV                               0001866566D0 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 038 M_BlackVolumeTexture                     00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer
    // 040 m_AssemblyTypes                          IEnumerable`1<Type> IL2CPP_TYPE_GENERICINST
    public partial class CoreUtils : DataModel
    {
        public Cubemap?                                 M_BlackCubeTexture                      { get; set; }
        public Cubemap?                                 M_MagentaCubeTexture                    { get; set; }
        public CubemapArray?                            M_MagentaCubeTextureArray               { get; set; }
        public Cubemap?                                 M_WhiteCubeTexture                      { get; set; }
        public RenderTexture?                           M_EmptyUAV                              { get; set; }
        public Texture3D?                               M_BlackVolumeTexture                    { get; set; }

        public static CoreUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreUtils() { Pointer= p0 };

            value.M_BlackCubeTexture                        = GetObject<Cubemap>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cubemap.FromPointer); // 0245A3FECD20 0x10 M_BlackCubeTexture          ( 000186661D00 ModelClassType Cubemap Cubemap Cubemap Pointer )
            value.M_MagentaCubeTexture                      = GetObject<Cubemap>(new IntPtr(p + 0x018), ReversePrism.DataModels.Cubemap.FromPointer); // 0245A3FECD40 0x18 M_MagentaCubeTexture        ( 000186661D00 ModelClassType Cubemap Cubemap Cubemap Pointer )
            value.M_MagentaCubeTextureArray                 = GetObject<CubemapArray>(new IntPtr(p + 0x020), ReversePrism.DataModels.CubemapArray.FromPointer); // 0245A3FECD60 0x20 M_MagentaCubeTextureArray   ( 0001866621E0 ModelClassType CubemapArray CubemapArray CubemapArray Pointer )
            value.M_WhiteCubeTexture                        = GetObject<Cubemap>(new IntPtr(p + 0x028), ReversePrism.DataModels.Cubemap.FromPointer); // 0245A3FECD80 0x28 M_WhiteCubeTexture          ( 000186661D00 ModelClassType Cubemap Cubemap Cubemap Pointer )
            value.M_EmptyUAV                                = GetObject<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A3FECDA0 0x30 M_EmptyUAV                  ( 0001866566D0 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_BlackVolumeTexture                      = GetObject<Texture3D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture3D.FromPointer); // 0245A3FECDC0 0x38 M_BlackVolumeTexture        ( 00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer )

            return value;
        }
    }
}
