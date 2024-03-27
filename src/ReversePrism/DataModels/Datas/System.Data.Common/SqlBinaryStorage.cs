using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185CA4C78 ModelEnumListType SqlBinary[] SqlBinary[] List<SqlBinary> Pointer
    public partial class SqlBinaryStorage
    {
        public List<SqlBinary>?                         Values                                  { get; set; }

        public static SqlBinaryStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlBinaryStorage();

            value.Values                                    = GetEnumList<SqlBinary>(new IntPtr(p + 0x050)); // 0270D89E9520 0x50 Values                      ( 000185CA4C78 ModelEnumListType SqlBinary[] SqlBinary[] List<SqlBinary> Pointer )

            return value;
        }
    }
}
