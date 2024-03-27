using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <activeMeshIndices>k__BackingField       List`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 s_CachedInstance                         List`1<CombineInstanceEx> IL2CPP_TYPE_GENERICINST
    // 010 Count                                    0001865F38E0 ModelPrimitiveType int int int Int32
    public partial class MeshHelper
    {
        public int                                      Count                                   { get; set; }

        public static MeshHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshHelper();

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 027003C5C8A8 0x10 Count                       ( 0001865F38E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
