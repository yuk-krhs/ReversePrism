using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GyroIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Gyroscope
    {
        public int                                      M_GyroIndex                             { get; set; }

        public static Gyroscope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Gyroscope();

            value.M_GyroIndex                               = GetInt32(new IntPtr(p + 0x010)); // 027003A52A58 0x10 M_GyroIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
