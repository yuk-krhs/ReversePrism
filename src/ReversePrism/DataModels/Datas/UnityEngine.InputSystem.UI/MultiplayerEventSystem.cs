using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_PlayerRoot                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class MultiplayerEventSystem
    {
        public GameObject?                              M_PlayerRoot                            { get; set; }

        public static MultiplayerEventSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiplayerEventSystem();

            value.M_PlayerRoot                              = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D77B32C0 0x60 M_PlayerRoot                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
