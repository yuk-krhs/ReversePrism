using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NotificationHour                         int IL2CPP_TYPE_I4
    // 010 Month                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Day                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Birthday                                 000186671910 ModelPrimitiveType string string string String
    public partial class BirthdayNotification
    {
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }
        public string                                   Birthday                                { get; set; }

        public static BirthdayNotification? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BirthdayNotification();

            value.Month                                     = GetInt32(new IntPtr(p + 0x010)); // 027003AC3EB8 0x10 Month                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x014)); // 027003AC3ED8 0x14 Day                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Birthday                                  = GetString(new IntPtr(p + 0x018)); // 027003AC3EF8 0x18 Birthday                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
