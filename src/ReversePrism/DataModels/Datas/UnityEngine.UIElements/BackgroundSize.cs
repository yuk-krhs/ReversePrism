using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SizeType                               ModelEnumType BackgroundSizeType BackgroundSizeType BackgroundSizeType Int32
    // 014 M_X                                      ModelEnumType Length Length Length Int32
    // 01C M_Y                                      ModelEnumType Length Length Length Int32
    public partial class BackgroundSize : DataModel
    {
        public BackgroundSizeType                       M_SizeType                              { get; set; }
        public Length                                   M_X                                     { get; set; }
        public Length                                   M_Y                                     { get; set; }

        public static BackgroundSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackgroundSize() { Pointer= p0 };

            value.M_SizeType                                = (BackgroundSizeType)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_SizeType                  ( ModelEnumType BackgroundSizeType BackgroundSizeType BackgroundSizeType Int32 )
            value.M_X                                       = (Length)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_X                         ( ModelEnumType Length Length Length Int32 )
            value.M_Y                                       = (Length)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Y                         ( ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
