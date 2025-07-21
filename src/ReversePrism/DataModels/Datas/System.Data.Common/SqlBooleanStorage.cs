using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelEnumListType SqlBoolean[] SqlBoolean[] List<SqlBoolean> Pointer
    public partial class SqlBooleanStorage : DataModel
    {
        public List<SqlBoolean>?                        Values                                  { get; set; }

        public static SqlBooleanStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlBooleanStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlBoolean>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType SqlBoolean[] SqlBoolean[] List<SqlBoolean> Pointer )

            return value;
        }
    }
}
