using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Result                                   ModelEnumType Result Result Result Int32
    public partial class SQLiteException : DataModel
    {
        public Result                                   Result                                  { get; set; }

        public static SQLiteException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteException() { Pointer= p0 };

            value.Result                                    = (Result)GetInt32(new IntPtr(p + 0x090)); // 0x90 Result                      ( ModelEnumType Result Result Result Int32 )

            return value;
        }
    }
}
