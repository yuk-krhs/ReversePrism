using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SystemRoot                               ModelClassType GameObject GameObject GameObject Pointer
    public partial class SceneMainBase : DataModel
    {
        public GameObject?                              SystemRoot                              { get; set; }

        public static SceneMainBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneMainBase() { Pointer= p0 };

            value.SystemRoot                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 SystemRoot                  ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
