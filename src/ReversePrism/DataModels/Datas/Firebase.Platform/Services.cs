using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <AppConfig>k__BackingField               IAppConfigExtensions IL2CPP_TYPE_CLASS
    // 008 <Clock>k__BackingField                   IClockService IL2CPP_TYPE_CLASS
    // 010 Logging                                  ModelClassType ILoggingService ILoggingService ILoggingService Pointer
    public partial class Services : DataModel
    {
        public ILoggingService?                         Logging                                 { get; set; }

        public static Services? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Services() { Pointer= p0 };

            value.Logging                                   = GetObject<ILoggingService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILoggingService.FromPointer); // 0x10 Logging                     ( ModelClassType ILoggingService ILoggingService ILoggingService Pointer )

            return value;
        }
    }
}
