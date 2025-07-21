using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   ModelClassType Camera Camera Camera Pointer
    public partial class Billboard : DataModel
    {
        public Camera?                                  Camera                                  { get; set; }

        public static Billboard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Billboard() { Pointer= p0 };

            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 Camera                      ( ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
