using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SilhouetteId                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstChallengeTourRival : DataModel
    {
        public int                                      SilhouetteId                            { get; set; }

        public static MstChallengeTourRival? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChallengeTourRival() { Pointer= p0 };

            value.SilhouetteId                              = GetInt32(new IntPtr(p + 0x010)); // 0245A46250E8 0x10 SilhouetteId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
