using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 heightmapChanged                         HeightmapChangedCallback IL2CPP_TYPE_CLASS
    // 008 textureChanged                           TextureChangedCallback IL2CPP_TYPE_CLASS
    public partial class TerrainCallbacks : DataModel
    {

        public static TerrainCallbacks? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TerrainCallbacks() { Pointer= p0 };


            return value;
        }
    }
}
