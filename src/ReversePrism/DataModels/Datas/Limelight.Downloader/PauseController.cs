using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Paused                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 mutex                                    <object> IL2CPP_TYPE_OBJECT
    public partial class PauseController : DataModel
    {
        public bool                                     Paused                                  { get; set; }

        public static PauseController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PauseController() { Pointer= p0 };

            value.Paused                                    = GetBool(new IntPtr(p + 0x010)); // 0245A3E2DA60 0x10 Paused                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
