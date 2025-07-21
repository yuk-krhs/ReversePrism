using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 WithoutRowId                             ModelPrimitiveType bool bool bool Bool
    public partial class TableAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     WithoutRowId                            { get; set; }

        public static TableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TableAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.WithoutRowId                              = GetBool(new IntPtr(p + 0x018)); // 0x18 WithoutRowId                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
