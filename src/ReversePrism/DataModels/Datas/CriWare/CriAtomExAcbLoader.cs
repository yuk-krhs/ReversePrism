using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 gch                                      Nullable`1<GCHandle> IL2CPP_TYPE_GENERICINST
    public partial class CriAtomExAcbLoader
    {

        public static CriAtomExAcbLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExAcbLoader();


            return value;
        }
    }
}
