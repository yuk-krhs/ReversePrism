using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Array                                    0001865A4BE0 ModelEnumType LocalDefinition LocalDefinition LocalDefinition Int32
    // 028 Index                                    0001865A4BE0 ModelEnumType LocalDefinition LocalDefinition LocalDefinition Int32
    public partial class ArrayByRefUpdater
    {
        public LocalDefinition                          Array                                   { get; set; }
        public LocalDefinition                          Index                                   { get; set; }

        public static ArrayByRefUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayByRefUpdater();

            value.Array                                     = (LocalDefinition)GetInt32(new IntPtr(p + 0x018)); // 0270DA00C6C0 0x18 Array                       ( 0001865A4BE0 ModelEnumType LocalDefinition LocalDefinition LocalDefinition Int32 )
            value.Index                                     = (LocalDefinition)GetInt32(new IntPtr(p + 0x028)); // 0270DA00C6E0 0x28 Index                       ( 0001865A4BE0 ModelEnumType LocalDefinition LocalDefinition LocalDefinition Int32 )

            return value;
        }
    }
}
