using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA65C8 ModelEnumListType SqlSingle[] SqlSingle[] List<SqlSingle> Pointer
    public partial class SqlSingleStorage
    {
        public List<SqlSingle>?                         Values                                  { get; set; }

        public static SqlSingleStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlSingleStorage();

            value.Values                                    = GetEnumList<SqlSingle>(new IntPtr(p + 0x050)); // 0270D89EE250 0x50 Values                      ( 000185CA65C8 ModelEnumListType SqlSingle[] SqlSingle[] List<SqlSingle> Pointer )

            return value;
        }
    }
}
