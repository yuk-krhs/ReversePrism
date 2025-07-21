using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Configuration                            ModelClassType DmmGamesIapStoreConfiguration DmmGamesIapStoreConfiguration DmmGamesIapStoreConfiguration Pointer
    public partial class DmmGamesIapModule : DataModel
    {
        public DmmGamesIapStoreConfiguration?           Configuration                           { get; set; }

        public static DmmGamesIapModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapModule() { Pointer= p0 };

            value.Configuration                             = GetObject<DmmGamesIapStoreConfiguration>(new IntPtr(p + 0x018), ReversePrism.DataModels.DmmGamesIapStoreConfiguration.FromPointer); // 0x18 Configuration               ( ModelClassType DmmGamesIapStoreConfiguration DmmGamesIapStoreConfiguration DmmGamesIapStoreConfiguration Pointer )

            return value;
        }
    }
}
