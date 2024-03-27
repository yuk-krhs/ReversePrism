using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ProjectConfig                          000186600AC0 ModelClassType IProjectConfiguration IProjectConfiguration IProjectConfiguration Pointer
    // 018 <CommonTags>k__BackingField              IReadOnlyDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 020 Handler                                  000186616B60 ModelClassType MetricsHandler MetricsHandler MetricsHandler Pointer
    public partial class MetricsFactory
    {
        public IProjectConfiguration?                   M_ProjectConfig                         { get; set; }
        public MetricsHandler?                          Handler                                 { get; set; }

        public static MetricsFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MetricsFactory();

            value.M_ProjectConfig                           = GetObject<IProjectConfiguration>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProjectConfiguration.FromPointer); // 0270066AFAF0 0x10 M_ProjectConfig             ( 000186600AC0 ModelClassType IProjectConfiguration IProjectConfiguration IProjectConfiguration Pointer )
            value.Handler                                   = GetObject<MetricsHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.MetricsHandler.FromPointer); // 0270066AFB30 0x20 Handler                     ( 000186616B60 ModelClassType MetricsHandler MetricsHandler MetricsHandler Pointer )

            return value;
        }
    }
}
