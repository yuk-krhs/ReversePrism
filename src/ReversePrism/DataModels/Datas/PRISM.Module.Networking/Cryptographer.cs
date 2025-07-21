using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 IvLength                                 int IL2CPP_TYPE_I4
    // 010 CtrProvider                              ModelClassType AESCTRCrypt AESCTRCrypt AESCTRCrypt Pointer
    // 018 Random                                   ModelClassType Random Random Random Pointer
    public partial class Cryptographer : DataModel
    {
        public AESCTRCrypt?                             CtrProvider                             { get; set; }
        public Random?                                  Random                                  { get; set; }

        public static Cryptographer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cryptographer() { Pointer= p0 };

            value.CtrProvider                               = GetObject<AESCTRCrypt>(new IntPtr(p + 0x010), ReversePrism.DataModels.AESCTRCrypt.FromPointer); // 0x10 CtrProvider                 ( ModelClassType AESCTRCrypt AESCTRCrypt AESCTRCrypt Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x018), ReversePrism.DataModels.Random.FromPointer); // 0x18 Random                      ( ModelClassType Random Random Random Pointer )

            return value;
        }
    }
}
