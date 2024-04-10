using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LegacyShaderTagIds                       List`1<ShaderTagId> IL2CPP_TYPE_GENERICINST
    // 008 ErrorMaterial                            Material IL2CPP_TYPE_CLASS
    public partial class DrawUnsupportedPass : DataModel
    {

        public static DrawUnsupportedPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawUnsupportedPass() { Pointer= p0 };


            return value;
        }
    }
}
