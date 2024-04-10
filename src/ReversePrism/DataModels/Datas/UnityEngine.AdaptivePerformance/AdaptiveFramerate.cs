using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultFPS                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AdaptiveFramerate : DataModel
    {
        public int                                      M_DefaultFPS                            { get; set; }

        public static AdaptiveFramerate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveFramerate() { Pointer= p0 };

            value.M_DefaultFPS                              = GetInt32(new IntPtr(p + 0x040)); // 02466B715CD8 0x40 M_DefaultFPS                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
