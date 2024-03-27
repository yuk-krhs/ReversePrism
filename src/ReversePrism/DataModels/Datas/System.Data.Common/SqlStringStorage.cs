using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA67C8 ModelEnumListType SqlString[] SqlString[] List<SqlString> Pointer
    public partial class SqlStringStorage
    {
        public List<SqlString>?                         Values                                  { get; set; }

        public static SqlStringStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlStringStorage();

            value.Values                                    = GetEnumList<SqlString>(new IntPtr(p + 0x050)); // 0270D89EE8D0 0x50 Values                      ( 000185CA67C8 ModelEnumListType SqlString[] SqlString[] List<SqlString> Pointer )

            return value;
        }
    }
}
