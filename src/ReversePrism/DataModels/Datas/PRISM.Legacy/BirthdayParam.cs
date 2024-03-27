using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DateTimeFormat                           string IL2CPP_TYPE_STRING
    // 000 MonthAndDayStartIndex                    int IL2CPP_TYPE_I4
    // 000 YearAndMonthStartIndex                   int IL2CPP_TYPE_I4
    // 010 BirthYear                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 BirthMonth                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 BirthDay                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BirthdayParam
    {
        public int                                      BirthYear                               { get; set; }
        public int                                      BirthMonth                              { get; set; }
        public int                                      BirthDay                                { get; set; }

        public static BirthdayParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BirthdayParam();

            value.BirthYear                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D50B2460 0x10 BirthYear                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BirthMonth                                = GetInt32(new IntPtr(p + 0x014)); // 0270D50B2480 0x14 BirthMonth                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BirthDay                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D50B24A0 0x18 BirthDay                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
