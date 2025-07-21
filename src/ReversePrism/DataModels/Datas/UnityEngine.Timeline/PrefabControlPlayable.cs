using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Instance                               ModelClassType GameObject GameObject GameObject Pointer
    public partial class PrefabControlPlayable : DataModel
    {
        public GameObject?                              M_Instance                              { get; set; }

        public static PrefabControlPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrefabControlPlayable() { Pointer= p0 };

            value.M_Instance                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 M_Instance                  ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
