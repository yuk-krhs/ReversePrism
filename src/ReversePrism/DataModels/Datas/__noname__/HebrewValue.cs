using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Token                                    ModelEnumType HebrewToken HebrewToken HebrewToken Int32
    // 012 Value                                    ModelPrimitiveType short short short Int16
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

            value.Token                                     = (HebrewToken)GetInt32(new IntPtr(p + 0x010)); // 0x10 Token                       ( ModelEnumType HebrewToken HebrewToken HebrewToken Int32 )
            value.Value                                     = GetInt16(new IntPtr(p + 0x012)); // 0x12 Value                       ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
