using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA50A8 ModelEnumListType SqlByte[] SqlByte[] List<SqlByte> Pointer
    public partial class SqlByteStorage : DataModel
    {
        public List<SqlByte>?                           Values                                  { get; set; }

        public static SqlByteStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlByteStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<SqlByte>(new IntPtr(p + 0x050)); // 024668A447A8 0x50 Values                      ( 000185CA50A8 ModelEnumListType SqlByte[] SqlByte[] List<SqlByte> Pointer )

            return value;
        }
    }
}
