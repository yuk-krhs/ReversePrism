using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 248 ObjectOn                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 250 ObjectOff                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class PlayAndStopToggleButton
    {
        public GameObject?                              ObjectOn                                { get; set; }
        public GameObject?                              ObjectOff                               { get; set; }

        public static PlayAndStopToggleButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayAndStopToggleButton();

            value.ObjectOn                                  = GetObject<GameObject>(new IntPtr(p + 0x248), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4C093A0 0x248 ObjectOn                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ObjectOff                                 = GetObject<GameObject>(new IntPtr(p + 0x250), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4C093C0 0x250 ObjectOff                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
