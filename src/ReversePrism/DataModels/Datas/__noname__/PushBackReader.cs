using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   000186645510 ModelClassType TextReader TextReader TextReader Pointer
    // 018 nextChar                                 Nullable`1<char> IL2CPP_TYPE_GENERICINST
    public partial class PushBackReader : DataModel
    {
        public TextReader?                              Reader                                  { get; set; }

        public static PushBackReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PushBackReader() { Pointer= p0 };

            value.Reader                                    = GetObject<TextReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextReader.FromPointer); // 02466A47E288 0x10 Reader                      ( 000186645510 ModelClassType TextReader TextReader TextReader Pointer )

            return value;
        }
    }
}
