using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultAPI                             SceneManagerAPI IL2CPP_TYPE_CLASS
    // 008 <overrideAPI>k__BackingField             SceneManagerAPI IL2CPP_TYPE_CLASS
    public partial class SceneManagerAPI : DataModel
    {

        public static SceneManagerAPI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneManagerAPI() { Pointer= p0 };


            return value;
        }
    }
}
