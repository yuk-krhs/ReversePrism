using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumType Level Level Level Int32
    public partial class DocumentationSortingAttribute : DataModel
    {
        public Level                                    Category                                { get; set; }

        public static DocumentationSortingAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DocumentationSortingAttribute() { Pointer= p0 };

            value.Category                                  = (Level)GetInt32(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelEnumType Level Level Level Int32 )

            return value;
        }
    }
}
