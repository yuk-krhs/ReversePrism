using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NormalOutlineString                      string IL2CPP_TYPE_STRING
    // 000 NormalOutline                            Shader IL2CPP_TYPE_CLASS
    public partial class CharaShader : DataModel
    {

        public static CharaShader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharaShader() { Pointer= p0 };


            return value;
        }
    }
}
