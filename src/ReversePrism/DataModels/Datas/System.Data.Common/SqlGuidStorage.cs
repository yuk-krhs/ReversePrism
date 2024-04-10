using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA5C28 ModelEnumListType SqlGuid[] SqlGuid[] List<SqlGuid> Pointer
    public partial class SqlGuidStorage : DataModel
    {
        public List<SqlGuid>?                           Values                                  { get; set; }

        public static SqlGuidStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlGuidStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlGuid>(new IntPtr(p + 0x050)); // 024668A46DD8 0x50 Values                      ( 000185CA5C28 ModelEnumListType SqlGuid[] SqlGuid[] List<SqlGuid> Pointer )

            return value;
        }
    }
}
