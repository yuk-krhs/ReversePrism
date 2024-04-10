using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 streamingMipmapsPriorityMin              int IL2CPP_TYPE_I4
    // 000 streamingMipmapsPriorityMax              int IL2CPP_TYPE_I4
    public partial class Texture2D : DataModel
    {

        public static Texture2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Texture2D() { Pointer= p0 };


            return value;
        }
    }
}
