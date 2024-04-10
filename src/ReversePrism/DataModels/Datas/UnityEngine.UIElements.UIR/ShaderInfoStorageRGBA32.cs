using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Convert                                Func`2<Color, Color32> IL2CPP_TYPE_GENERICINST
    public partial class ShaderInfoStorageRGBA32 : DataModel
    {

        public static ShaderInfoStorageRGBA32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderInfoStorageRGBA32() { Pointer= p0 };


            return value;
        }
    }
}
