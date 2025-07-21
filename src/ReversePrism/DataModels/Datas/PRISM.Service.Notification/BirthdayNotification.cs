using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NotificationHour                         int IL2CPP_TYPE_I4
    // 010 Month                                    ModelPrimitiveType int int int Int32
    // 014 Day                                      ModelPrimitiveType int int int Int32
    // 018 Birthday                                 ModelPrimitiveType string string string String
    public partial class BirthdayNotification : DataModel
    {
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }
        public string                                   Birthday                                { get; set; }

        public static BirthdayNotification? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BirthdayNotification() { Pointer= p0 };

            value.Month                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Month                       ( ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 Day                         ( ModelPrimitiveType int int int Int32 )
            value.Birthday                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Birthday                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
