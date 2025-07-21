using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    public partial class StylePropertyName : DataModel
    {
        public StylePropertyId                          Id                                      { get; set; }
        public string                                   Name                                    { get; set; }

        public static StylePropertyName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyName() { Pointer= p0 };

            value.Id                                        = (StylePropertyId)GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
