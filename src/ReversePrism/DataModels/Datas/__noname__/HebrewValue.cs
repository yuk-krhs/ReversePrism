using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Token                                    000186535F80 ModelEnumType HebrewToken HebrewToken HebrewToken Int32
    // 012 Value                                    0001865F12C0 ModelPrimitiveType short short short Int16
    public partial class HebrewValue : DataModel
    {
        public HebrewToken                              Token                                   { get; set; }
        public short                                    Value                                   { get; set; }

        public static HebrewValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HebrewValue() { Pointer= p0 };

            value.Token                                     = (HebrewToken)GetInt32(new IntPtr(p + 0x010)); // 024666D8A4E8 0x10 Token                       ( 000186535F80 ModelEnumType HebrewToken HebrewToken HebrewToken Int32 )
            value.Value                                     = GetInt16(new IntPtr(p + 0x012)); // 024666D8A508 0x12 Value                       ( 0001865F12C0 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
