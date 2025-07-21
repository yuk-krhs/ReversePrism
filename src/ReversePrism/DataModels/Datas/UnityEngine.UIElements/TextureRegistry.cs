using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Textures                               ModelEnumListType List`1<TextureInfo> List`1<TextureInfo> List<TextureInfo> Pointer
    // 018 m_TextureToId                            Dictionary`2<Texture, TextureId> IL2CPP_TYPE_GENERICINST
    // 020 m_FreeIds                                Stack`1<TextureId> IL2CPP_TYPE_GENERICINST
    // 000 maxTextures                              int IL2CPP_TYPE_I4
    // 000 <instance>k__BackingField                TextureRegistry IL2CPP_TYPE_CLASS
    public partial class TextureRegistry : DataModel
    {
        public List<TextureInfo>?                       M_Textures                              { get; set; }

        public static TextureRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureRegistry() { Pointer= p0 };

            value.M_Textures                                = GetEnumList<TextureInfo>(new IntPtr(p + 0x010)); // 0x10 M_Textures                  ( ModelEnumListType List`1<TextureInfo> List`1<TextureInfo> List<TextureInfo> Pointer )

            return value;
        }
    }
}
