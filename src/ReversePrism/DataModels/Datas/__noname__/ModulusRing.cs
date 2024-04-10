using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mod                                      00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 018 Constant                                 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    public partial class ModulusRing : DataModel
    {
        public BigInteger?                              Mod                                     { get; set; }
        public BigInteger?                              Constant                                { get; set; }

        public static ModulusRing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModulusRing() { Pointer= p0 };

            value.Mod                                       = GetObject<BigInteger>(new IntPtr(p + 0x010), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B43A298 0x10 Mod                         ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Constant                                  = GetObject<BigInteger>(new IntPtr(p + 0x018), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B43A2B8 0x18 Constant                    ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )

            return value;
        }
    }
}
