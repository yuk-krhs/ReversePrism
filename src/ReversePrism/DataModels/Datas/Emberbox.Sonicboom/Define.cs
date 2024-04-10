using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DownloadErrorFileMask                    SonicboomDownloadErrorFlag IL2CPP_TYPE_VALUETYPE
    // 000 DownloadErrorChecksumMask                SonicboomDownloadErrorFlag IL2CPP_TYPE_VALUETYPE
    // 000 DownloadErrorCurlMask                    SonicboomDownloadErrorFlag IL2CPP_TYPE_VALUETYPE
    public partial class Define : DataModel
    {

        public static Define? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Define() { Pointer= p0 };


            return value;
        }
    }
}
