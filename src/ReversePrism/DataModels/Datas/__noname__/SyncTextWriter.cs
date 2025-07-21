using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Out                                      ModelClassType TextWriter TextWriter TextWriter Pointer
    public partial class SyncTextWriter : DataModel
    {
        public TextWriter?                              Out                                     { get; set; }

        public static SyncTextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncTextWriter() { Pointer= p0 };

            value.Out                                       = GetObject<TextWriter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextWriter.FromPointer); // 0x30 Out                         ( ModelClassType TextWriter TextWriter TextWriter Pointer )

            return value;
        }
    }
}
