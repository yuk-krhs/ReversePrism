using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_types                                  Type[] IL2CPP_TYPE_SZARRAY
    // 010 Values                                   00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer
    public partial class ColumnTypeConverter
    {
        public StandardValuesCollection?                Values                                  { get; set; }

        public static ColumnTypeConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnTypeConverter();

            value.Values                                    = GetObject<StandardValuesCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.StandardValuesCollection.FromPointer); // 0270D889BA40 0x10 Values                      ( 00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer )

            return value;
        }
    }
}
