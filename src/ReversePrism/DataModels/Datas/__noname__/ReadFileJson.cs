using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Actions                                  000185CBC648 ModelEnumListType ReadActionJson[] ReadActionJson[] List<ReadActionJson> Pointer
    // 018 Maps                                     000185CBC868 ModelEnumListType ReadMapJson[] ReadMapJson[] List<ReadMapJson> Pointer
    public partial class ReadFileJson
    {
        public List<ReadActionJson>?                    Actions                                 { get; set; }
        public List<ReadMapJson>?                       Maps                                    { get; set; }

        public static ReadFileJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadFileJson();

            value.Actions                                   = GetEnumList<ReadActionJson>(new IntPtr(p + 0x010)); // 0270D764FC58 0x10 Actions                     ( 000185CBC648 ModelEnumListType ReadActionJson[] ReadActionJson[] List<ReadActionJson> Pointer )
            value.Maps                                      = GetEnumList<ReadMapJson>(new IntPtr(p + 0x018)); // 0270D764FC78 0x18 Maps                        ( 000185CBC868 ModelEnumListType ReadMapJson[] ReadMapJson[] List<ReadMapJson> Pointer )

            return value;
        }
    }
}
