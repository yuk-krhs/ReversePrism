using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Column                                   ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 IsDescending                             ModelPrimitiveType bool bool bool Bool
    public partial class IndexField : DataModel
    {
        public DataColumn?                              Column                                  { get; set; }
        public bool                                     IsDescending                            { get; set; }

        public static IndexField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexField() { Pointer= p0 };

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0x10 Column                      ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.IsDescending                              = GetBool(new IntPtr(p + 0x018)); // 0x18 IsDescending                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
