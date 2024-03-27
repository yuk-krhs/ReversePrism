using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <isInitialized>k__BackingField           bool IL2CPP_TYPE_BOOLEAN
    // 001 <isCrcEnabled>k__BackingField            bool IL2CPP_TYPE_BOOLEAN
    // 000 InvalidHttpStatusCode                    int IL2CPP_TYPE_I4
    // 000 InvalidContentsSize                      long IL2CPP_TYPE_I8
    // 020 handle                                   <int> IL2CPP_TYPE_I
    public partial class CriFsWebInstaller
    {

        public static CriFsWebInstaller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsWebInstaller();


            return value;
        }
    }
}
