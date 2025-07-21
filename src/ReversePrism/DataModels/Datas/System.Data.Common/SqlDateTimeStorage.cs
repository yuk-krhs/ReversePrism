using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelEnumListType SqlDateTime[] SqlDateTime[] List<SqlDateTime> Pointer
    public partial class SqlDateTimeStorage : DataModel
    {
        public List<SqlDateTime>?                       Values                                  { get; set; }

        public static SqlDateTimeStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDateTimeStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlDateTime>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType SqlDateTime[] SqlDateTime[] List<SqlDateTime> Pointer )

            return value;
        }
    }
}
