using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CameraStacking                           ModelPrimitiveType bool bool bool Bool
    // 011 Msaa                                     ModelPrimitiveType bool bool bool Bool
    public partial class RenderingFeatures : DataModel
    {
        public bool                                     CameraStacking                          { get; set; }
        public bool                                     Msaa                                    { get; set; }

        public static RenderingFeatures? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingFeatures() { Pointer= p0 };

            value.CameraStacking                            = GetBool(new IntPtr(p + 0x010)); // 0x10 CameraStacking              ( ModelPrimitiveType bool bool bool Bool )
            value.Msaa                                      = GetBool(new IntPtr(p + 0x011)); // 0x11 Msaa                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
