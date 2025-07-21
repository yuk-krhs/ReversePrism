using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType GameObject GameObject GameObject Pointer
    // 018 Camera                                   ModelClassType Camera Camera Camera Pointer
    public partial class HitInfo : DataModel
    {
        public GameObject?                              Target                                  { get; set; }
        public Camera?                                  Camera                                  { get; set; }

        public static HitInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HitInfo() { Pointer= p0 };

            value.Target                                    = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 Target                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x018), ReversePrism.DataModels.Camera.FromPointer); // 0x18 Camera                      ( ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
