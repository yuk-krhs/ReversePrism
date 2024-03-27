using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SizeType                               000186734DE0 ModelEnumType BackgroundSizeType BackgroundSizeType BackgroundSizeType Int32
    // 014 M_X                                      0001866061D0 ModelEnumType Length Length Length Int32
    // 01C M_Y                                      0001866061D0 ModelEnumType Length Length Length Int32
    public partial class BackgroundSize
    {
        public BackgroundSizeType                       M_SizeType                              { get; set; }
        public Length                                   M_X                                     { get; set; }
        public Length                                   M_Y                                     { get; set; }

        public static BackgroundSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackgroundSize();

            value.M_SizeType                                = (BackgroundSizeType)GetInt32(new IntPtr(p + 0x010)); // 027003F2D4A0 0x10 M_SizeType                  ( 000186734DE0 ModelEnumType BackgroundSizeType BackgroundSizeType BackgroundSizeType Int32 )
            value.M_X                                       = (Length)GetInt32(new IntPtr(p + 0x014)); // 027003F2D4C0 0x14 M_X                         ( 0001866061D0 ModelEnumType Length Length Length Int32 )
            value.M_Y                                       = (Length)GetInt32(new IntPtr(p + 0x01C)); // 027003F2D4E0 0x1C M_Y                         ( 0001866061D0 ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
