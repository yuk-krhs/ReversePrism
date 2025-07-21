using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_MipPadding                             ModelPrimitiveType int int int Int32
    // 000 k_MipmapFactorApprox                     float IL2CPP_TYPE_R4
    // 050 m_RequestedTextures                      Dictionary`2<int, Vector2Int> IL2CPP_TYPE_GENERICINST
    public partial class PowerOfTwoTextureAtlas : DataModel
    {
        public int                                      M_MipPadding                            { get; set; }

        public static PowerOfTwoTextureAtlas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PowerOfTwoTextureAtlas() { Pointer= p0 };

            value.M_MipPadding                              = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_MipPadding                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
