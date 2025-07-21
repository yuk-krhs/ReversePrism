using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Store                                    ModelClassType DmmGamesIapStore DmmGamesIapStore DmmGamesIapStore Pointer
    public partial class DmmGamesIapStoreExtension : DataModel
    {
        public DmmGamesIapStore?                        Store                                   { get; set; }

        public static DmmGamesIapStoreExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStoreExtension() { Pointer= p0 };

            value.Store                                     = GetObject<DmmGamesIapStore>(new IntPtr(p + 0x010), ReversePrism.DataModels.DmmGamesIapStore.FromPointer); // 0x10 Store                       ( ModelClassType DmmGamesIapStore DmmGamesIapStore DmmGamesIapStore Pointer )

            return value;
        }
    }
}
