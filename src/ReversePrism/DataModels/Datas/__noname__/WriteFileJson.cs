using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Maps                                     000185CBCC88 ModelEnumListType WriteMapJson[] WriteMapJson[] List<WriteMapJson> Pointer
    public partial class WriteFileJson : DataModel
    {
        public List<WriteMapJson>?                      Maps                                    { get; set; }

        public static WriteFileJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteFileJson() { Pointer= p0 };

            value.Maps                                      = GetEnumList<WriteMapJson>(new IntPtr(p + 0x010)); // 0246676BFAE8 0x10 Maps                        ( 000185CBCC88 ModelEnumListType WriteMapJson[] WriteMapJson[] List<WriteMapJson> Pointer )

            return value;
        }
    }
}
