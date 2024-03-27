using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WebProxy                                 00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 000 classSyncObject                          <object> IL2CPP_TYPE_OBJECT
    public partial class DefaultProxySectionInternal
    {
        public IWebProxy?                               WebProxy                                { get; set; }

        public static DefaultProxySectionInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultProxySectionInternal();

            value.WebProxy                                  = GetObject<IWebProxy>(new IntPtr(p + 0x010), ReversePrism.DataModels.IWebProxy.FromPointer); // 0270D7AE3A88 0x10 WebProxy                    ( 00018669AB30 ModelClassType IWebProxy IWebProxy IWebProxy Pointer )

            return value;
        }
    }
}
