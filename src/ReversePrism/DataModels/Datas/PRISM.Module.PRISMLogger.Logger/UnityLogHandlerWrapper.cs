using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 UnityLogHandlerWrapper IL2CPP_TYPE_CLASS
    // 010 BaseLogger                               00018659FF20 ModelClassType ILogHandler ILogHandler ILogHandler Pointer
    public partial class UnityLogHandlerWrapper
    {
        public ILogHandler?                             BaseLogger                              { get; set; }

        public static UnityLogHandlerWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityLogHandlerWrapper();

            value.BaseLogger                                = GetObject<ILogHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILogHandler.FromPointer); // 0270DBEE72D0 0x10 BaseLogger                  ( 00018659FF20 ModelClassType ILogHandler ILogHandler ILogHandler Pointer )

            return value;
        }
    }
}
