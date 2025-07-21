using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelClassListType SqlChars[] SqlChars[] List<SqlChars> Pointer
    public partial class SqlCharsStorage : DataModel
    {
        public List<SqlChars>?                          Values                                  { get; set; }

        public static SqlCharsStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlCharsStorage() { Pointer= p0 };

            value.Values                                    = GetObjectList<SqlChars>(new IntPtr(p + 0x050), ReversePrism.DataModels.SqlChars.FromPointer); // 0x50 Values                      ( ModelClassListType SqlChars[] SqlChars[] List<SqlChars> Pointer )

            return value;
        }
    }
}
