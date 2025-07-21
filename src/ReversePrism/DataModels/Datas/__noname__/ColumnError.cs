using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Column                                   ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 Error                                    ModelPrimitiveType string string string String
    public partial class ColumnError : DataModel
    {
        public DataColumn?                              Column                                  { get; set; }
        public string                                   Error                                   { get; set; }

        public static ColumnError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnError() { Pointer= p0 };

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0x10 Column                      ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Error                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Error                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
