using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 0001866E7400 ModelEnumType Category Category Category Int32
    public partial class CategorizedLogger
    {
        public Category                                 Category                                { get; set; }

        public static CategorizedLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategorizedLogger();

            value.Category                                  = (Category)GetInt32(new IntPtr(p + 0x010)); // 027003CBB6A8 0x10 Category                    ( 0001866E7400 ModelEnumType Category Category Category Int32 )

            return value;
        }
    }
}
