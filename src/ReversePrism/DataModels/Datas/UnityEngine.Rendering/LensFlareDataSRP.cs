using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Elements                                 000185B8FEA0 ModelClassListType LensFlareDataElementSRP[] LensFlareDataElementSRP[] List<LensFlareDataElementSRP> Pointer
    public partial class LensFlareDataSRP
    {
        public List<LensFlareDataElementSRP>?           Elements                                { get; set; }

        public static LensFlareDataSRP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensFlareDataSRP();

            value.Elements                                  = GetObjectList<LensFlareDataElementSRP>(new IntPtr(p + 0x018), ReversePrism.DataModels.LensFlareDataElementSRP.FromPointer); // 0270D925ACD8 0x18 Elements                    ( 000185B8FEA0 ModelClassListType LensFlareDataElementSRP[] LensFlareDataElementSRP[] List<LensFlareDataElementSRP> Pointer )

            return value;
        }
    }
}
