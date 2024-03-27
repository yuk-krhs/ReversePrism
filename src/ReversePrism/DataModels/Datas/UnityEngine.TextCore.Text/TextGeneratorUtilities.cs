using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 largePositiveVector2                     Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 largeNegativeVector2                     Vector2 IL2CPP_TYPE_VALUETYPE
    public partial class TextGeneratorUtilities
    {

        public static TextGeneratorUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextGeneratorUtilities();


            return value;
        }
    }
}
