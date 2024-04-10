using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001866DF940 ModelEnumType Index Index Index Int32
    // 014 End                                      0001866DF940 ModelEnumType Index Index Index Int32
    public partial class Range : DataModel
    {
        public Index                                    Start                                   { get; set; }
        public Index                                    End                                     { get; set; }

        public static Range? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Range() { Pointer= p0 };

            value.Start                                     = (Index)GetInt32(new IntPtr(p + 0x010)); // 024666A14850 0x10 Start                       ( 0001866DF940 ModelEnumType Index Index Index Int32 )
            value.End                                       = (Index)GetInt32(new IntPtr(p + 0x014)); // 024666A14870 0x14 End                         ( 0001866DF940 ModelEnumType Index Index Index Int32 )

            return value;
        }
    }
}
