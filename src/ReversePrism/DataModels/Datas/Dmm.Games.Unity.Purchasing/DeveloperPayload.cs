using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DmmGamesTerms                            ModelClassType DmmGamesTerms DmmGamesTerms DmmGamesTerms Pointer
    public partial class DeveloperPayload : DataModel
    {
        public DmmGamesTerms?                           DmmGamesTerms                           { get; set; }

        public static DeveloperPayload? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeveloperPayload() { Pointer= p0 };

            value.DmmGamesTerms                             = GetObject<DmmGamesTerms>(new IntPtr(p + 0x010), ReversePrism.DataModels.DmmGamesTerms.FromPointer); // 0x10 DmmGamesTerms               ( ModelClassType DmmGamesTerms DmmGamesTerms DmmGamesTerms Pointer )

            return value;
        }
    }
}
