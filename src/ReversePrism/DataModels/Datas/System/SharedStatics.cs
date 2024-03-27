using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _sharedStatics                           SharedStatics IL2CPP_TYPE_CLASS
    // 010 Maker                                    000186714EA0 ModelClassType StringMaker StringMaker StringMaker Pointer
    public partial class SharedStatics
    {
        public StringMaker?                             Maker                                   { get; set; }

        public static SharedStatics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SharedStatics();

            value.Maker                                     = GetObject<StringMaker>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringMaker.FromPointer); // 0270D6A624C8 0x10 Maker                       ( 000186714EA0 ModelClassType StringMaker StringMaker StringMaker Pointer )

            return value;
        }
    }
}
