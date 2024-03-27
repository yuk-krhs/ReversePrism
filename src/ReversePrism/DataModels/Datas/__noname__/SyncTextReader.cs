using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 In                                       000186645720 ModelClassType TextReader TextReader TextReader Pointer
    public partial class SyncTextReader
    {
        public TextReader?                              In                                      { get; set; }

        public static SyncTextReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncTextReader();

            value.In                                        = GetObject<TextReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextReader.FromPointer); // 0270D6E1FA48 0x18 In                          ( 000186645720 ModelClassType TextReader TextReader TextReader Pointer )

            return value;
        }
    }
}
