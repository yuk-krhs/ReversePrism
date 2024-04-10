using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keyword                                  00018658FD70 ModelEnumType BackgroundPositionKeyword BackgroundPositionKeyword BackgroundPositionKeyword Int32
    // 014 Offset                                   0001866063F0 ModelEnumType Length Length Length Int32
    public partial class BackgroundPosition : DataModel
    {
        public BackgroundPositionKeyword                Keyword                                 { get; set; }
        public Length                                   Offset                                  { get; set; }

        public static BackgroundPosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackgroundPosition() { Pointer= p0 };

            value.Keyword                                   = (BackgroundPositionKeyword)GetInt32(new IntPtr(p + 0x010)); // 0245A3F2D420 0x10 Keyword                     ( 00018658FD70 ModelEnumType BackgroundPositionKeyword BackgroundPositionKeyword BackgroundPositionKeyword Int32 )
            value.Offset                                    = (Length)GetInt32(new IntPtr(p + 0x014)); // 0245A3F2D440 0x14 Offset                      ( 0001866063F0 ModelEnumType Length Length Length Int32 )

            return value;
        }
    }
}
