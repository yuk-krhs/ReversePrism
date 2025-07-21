using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_configuredTaskAwaiter                  ModelEnumType ConfiguredTaskAwaiter ConfiguredTaskAwaiter ConfiguredTaskAwaiter Int32
    public partial class ConfiguredTaskAwaitable : DataModel
    {
        public ConfiguredTaskAwaiter                    M_configuredTaskAwaiter                 { get; set; }

        public static ConfiguredTaskAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfiguredTaskAwaitable() { Pointer= p0 };

            value.M_configuredTaskAwaiter                   = (ConfiguredTaskAwaiter)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_configuredTaskAwaiter     ( ModelEnumType ConfiguredTaskAwaiter ConfiguredTaskAwaiter ConfiguredTaskAwaiter Int32 )

            return value;
        }
    }
}
