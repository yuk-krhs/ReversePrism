using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA5268 ModelClassListType SqlBytes[] SqlBytes[] List<SqlBytes> Pointer
    public partial class SqlBytesStorage : DataModel
    {
        public List<SqlBytes>?                          Values                                  { get; set; }

        public static SqlBytesStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlBytesStorage() { Pointer= p0 };

            value.Values                                    = GetObjectList<SqlBytes>(new IntPtr(p + 0x050), ReversePrism.DataModels.SqlBytes.FromPointer); // 024668A44E28 0x50 Values                      ( 000185CA5268 ModelClassListType SqlBytes[] SqlBytes[] List<SqlBytes> Pointer )

            return value;
        }
    }
}
