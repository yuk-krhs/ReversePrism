using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_Technique                              ModelEnumType DecalTechnique DecalTechnique DecalTechnique Int32
    public partial class DecalDrawErrorSystem : DataModel
    {
        public DecalTechnique                           M_Technique                             { get; set; }

        public static DecalDrawErrorSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalDrawErrorSystem() { Pointer= p0 };

            value.M_Technique                               = (DecalTechnique)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_Technique                 ( ModelEnumType DecalTechnique DecalTechnique DecalTechnique Int32 )

            return value;
        }
    }
}
