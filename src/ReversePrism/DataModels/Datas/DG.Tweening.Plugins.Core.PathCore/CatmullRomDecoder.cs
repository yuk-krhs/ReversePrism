using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _PartialControlPs                        ControlPoint[] IL2CPP_TYPE_SZARRAY
    // 008 _PartialWps                              Vector3[] IL2CPP_TYPE_SZARRAY
    public partial class CatmullRomDecoder
    {

        public static CatmullRomDecoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CatmullRomDecoder();


            return value;
        }
    }
}
