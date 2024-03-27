using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_rectWorldCorners                       Vector3[] IL2CPP_TYPE_SZARRAY
    // 000 k_lookupStringL                          string IL2CPP_TYPE_STRING
    // 000 k_lookupStringU                          string IL2CPP_TYPE_STRING
    public partial class TMP_TextUtilities
    {

        public static TMP_TextUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_TextUtilities();


            return value;
        }
    }
}
