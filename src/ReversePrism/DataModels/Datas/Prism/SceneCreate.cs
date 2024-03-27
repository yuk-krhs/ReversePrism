using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 postName                                 string IL2CPP_TYPE_STRING
    // 000 savePostName                             string IL2CPP_TYPE_STRING
    public partial class SceneCreate
    {

        public static SceneCreate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneCreate();


            return value;
        }
    }
}
