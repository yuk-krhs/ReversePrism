using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RowError                                 ModelPrimitiveType string string string String
    // 018 Count                                    ModelPrimitiveType int int int Int32
    // 020 ErrorList                                ModelEnumListType ColumnError[] ColumnError[] List<ColumnError> Pointer
    public partial class DataError : DataModel
    {
        public string                                   RowError                                { get; set; }
        public int                                      Count                                   { get; set; }
        public List<ColumnError>?                       ErrorList                               { get; set; }

        public static DataError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataError() { Pointer= p0 };

            value.RowError                                  = GetString(new IntPtr(p + 0x010)); // 0x10 RowError                    ( ModelPrimitiveType string string string String )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )
            value.ErrorList                                 = GetEnumList<ColumnError>(new IntPtr(p + 0x020)); // 0x20 ErrorList                   ( ModelEnumListType ColumnError[] ColumnError[] List<ColumnError> Pointer )

            return value;
        }
    }
}
