using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA5A38 ModelEnumListType SqlDouble[] SqlDouble[] List<SqlDouble> Pointer
    public partial class SqlDoubleStorage
    {
        public List<SqlDouble>?                         Values                                  { get; set; }

        public static SqlDoubleStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDoubleStorage();

            value.Values                                    = GetEnumList<SqlDouble>(new IntPtr(p + 0x050)); // 0270D89EBB50 0x50 Values                      ( 000185CA5A38 ModelEnumListType SqlDouble[] SqlDouble[] List<SqlDouble> Pointer )

            return value;
        }
    }
}
