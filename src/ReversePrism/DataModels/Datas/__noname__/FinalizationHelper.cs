using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SlotArray                                LinkedSlotVolatile<<var>>[] IL2CPP_TYPE_SZARRAY
    // 000 m_trackAllValues                         bool IL2CPP_TYPE_BOOLEAN
    public partial class FinalizationHelper
    {

        public static FinalizationHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinalizationHelper();


            return value;
        }
    }
}
