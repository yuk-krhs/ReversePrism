using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Elements                                 ModelClassListType LensFlareDataElementSRP[] LensFlareDataElementSRP[] List<LensFlareDataElementSRP> Pointer
    public partial class LensFlareDataSRP : DataModel
    {
        public List<LensFlareDataElementSRP>?           Elements                                { get; set; }

        public static LensFlareDataSRP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensFlareDataSRP() { Pointer= p0 };

            value.Elements                                  = GetObjectList<LensFlareDataElementSRP>(new IntPtr(p + 0x018), ReversePrism.DataModels.LensFlareDataElementSRP.FromPointer); // 0x18 Elements                    ( ModelClassListType LensFlareDataElementSRP[] LensFlareDataElementSRP[] List<LensFlareDataElementSRP> Pointer )

            return value;
        }
    }
}
