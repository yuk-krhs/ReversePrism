using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_configuredTaskAwaiter                  0001865165B0 ModelEnumType ConfiguredTaskAwaiter ConfiguredTaskAwaiter ConfiguredTaskAwaiter Int32
    public partial class ConfiguredTaskAwaitable
    {
        public ConfiguredTaskAwaiter                    M_configuredTaskAwaiter                 { get; set; }

        public static ConfiguredTaskAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfiguredTaskAwaitable();

            value.M_configuredTaskAwaiter                   = (ConfiguredTaskAwaiter)GetInt32(new IntPtr(p + 0x010)); // 02700756C368 0x10 M_configuredTaskAwaiter     ( 0001865165B0 ModelEnumType ConfiguredTaskAwaiter ConfiguredTaskAwaiter ConfiguredTaskAwaiter Int32 )

            return value;
        }
    }
}
