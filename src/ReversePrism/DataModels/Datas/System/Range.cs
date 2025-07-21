using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelEnumType Index Index Index Int32
    // 014 End                                      ModelEnumType Index Index Index Int32
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

            value.Start                                     = (Index)GetInt32(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelEnumType Index Index Index Int32 )
            value.End                                       = (Index)GetInt32(new IntPtr(p + 0x014)); // 0x14 End                         ( ModelEnumType Index Index Index Int32 )

            return value;
        }
    }
}
