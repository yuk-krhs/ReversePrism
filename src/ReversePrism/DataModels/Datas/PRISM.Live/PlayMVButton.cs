using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 LockIcon                                 ModelClassType GameObject GameObject GameObject Pointer
    public partial class PlayMVButton : DataModel
    {
        public GameObject?                              LockIcon                                { get; set; }

        public static PlayMVButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayMVButton() { Pointer= p0 };

            value.LockIcon                                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 LockIcon                    ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
