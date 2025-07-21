using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _keyChar                                 char IL2CPP_TYPE_CHAR
    // 014 Key                                      ModelEnumType ConsoleKey ConsoleKey ConsoleKey Int32
    // 018 Mods                                     ModelEnumType ConsoleModifiers ConsoleModifiers ConsoleModifiers Int32
    public partial class ConsoleKeyInfo : DataModel
    {
        public ConsoleKey                               Key                                     { get; set; }
        public ConsoleModifiers                         Mods                                    { get; set; }

        public static ConsoleKeyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsoleKeyInfo() { Pointer= p0 };

            value.Key                                       = (ConsoleKey)GetInt32(new IntPtr(p + 0x014)); // 0x14 Key                         ( ModelEnumType ConsoleKey ConsoleKey ConsoleKey Int32 )
            value.Mods                                      = (ConsoleModifiers)GetInt32(new IntPtr(p + 0x018)); // 0x18 Mods                        ( ModelEnumType ConsoleModifiers ConsoleModifiers ConsoleModifiers Int32 )

            return value;
        }
    }
}
