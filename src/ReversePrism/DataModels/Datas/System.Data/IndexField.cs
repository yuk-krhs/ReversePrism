using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Column                                   0001866763C0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 IsDescending                             000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class IndexField
    {
        public DataColumn?                              Column                                  { get; set; }
        public bool                                     IsDescending                            { get; set; }

        public static IndexField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexField();

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88BF490 0x10 Column                      ( 0001866763C0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.IsDescending                              = GetBool(new IntPtr(p + 0x018)); // 0270D88BF4B0 0x18 IsDescending                ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
