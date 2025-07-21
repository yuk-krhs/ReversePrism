using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_sizeOfGuid                             int IL2CPP_TYPE_I4
    // 008 s_rgiGuidOrder                           int[] IL2CPP_TYPE_SZARRAY
    // 010 M_value                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 010 Null                                     ModelEnumType SqlGuid SqlGuid SqlGuid Int32
    public partial class SqlGuid : DataModel
    {
        public List<sbyte>?                             M_value                                 { get; set; }
        public SqlGuid                                  Null                                    { get; set; }

        public static SqlGuid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlGuid() { Pointer= p0 };

            value.M_value                                   = GetSByteList(new IntPtr(p + 0x010)); // 0x10 M_value                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Null                                      = (SqlGuid)GetInt32(new IntPtr(p + 0x010)); // 0x10 Null                        ( ModelEnumType SqlGuid SqlGuid SqlGuid Int32 )

            return value;
        }
    }
}
