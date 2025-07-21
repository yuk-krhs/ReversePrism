using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType DisplayType DisplayType DisplayType Int32
    public partial class CharacterTopArgument : DataModel
    {
        public DisplayType                              Type                                    { get; set; }

        public static CharacterTopArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopArgument() { Pointer= p0 };

            value.Type                                      = (DisplayType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType DisplayType DisplayType DisplayType Int32 )

            return value;
        }
    }
}
