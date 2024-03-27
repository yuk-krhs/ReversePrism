using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865C9B00 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    // 014 Keyword                                  0001865C82A0 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32
    // 018 value                                    <object> IL2CPP_TYPE_OBJECT
    public partial class StyleValueManaged
    {
        public StylePropertyId                          Id                                      { get; set; }
        public StyleKeyword                             Keyword                                 { get; set; }

        public static StyleValueManaged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleValueManaged();

            value.Id                                        = (StylePropertyId)GetInt32(new IntPtr(p + 0x010)); // 027006886F70 0x10 Id                          ( 0001865C9B00 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )
            value.Keyword                                   = (StyleKeyword)GetInt32(new IntPtr(p + 0x014)); // 027006886F90 0x14 Keyword                     ( 0001865C82A0 ModelEnumType StyleKeyword StyleKeyword StyleKeyword Int32 )

            return value;
        }
    }
}
