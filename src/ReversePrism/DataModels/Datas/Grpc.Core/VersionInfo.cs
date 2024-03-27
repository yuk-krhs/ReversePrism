using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CurrentAssemblyVersion                   string IL2CPP_TYPE_STRING
    // 000 CurrentAssemblyFileVersion               string IL2CPP_TYPE_STRING
    // 000 CurrentVersion                           string IL2CPP_TYPE_STRING
    public partial class VersionInfo
    {

        public static VersionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VersionInfo();


            return value;
        }
    }
}
