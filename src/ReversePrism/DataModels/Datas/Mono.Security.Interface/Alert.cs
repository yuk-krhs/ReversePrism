using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Level                                    0001866A18A0 ModelEnumType AlertLevel AlertLevel AlertLevel Int32
    // 011 Description                              0001866A0EE0 ModelEnumType AlertDescription AlertDescription AlertDescription Int32
    public partial class Alert : DataModel
    {
        public AlertLevel                               Level                                   { get; set; }
        public AlertDescription                         Description                             { get; set; }

        public static Alert? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Alert() { Pointer= p0 };

            value.Level                                     = (AlertLevel)GetInt32(new IntPtr(p + 0x010)); // 02466B40DA58 0x10 Level                       ( 0001866A18A0 ModelEnumType AlertLevel AlertLevel AlertLevel Int32 )
            value.Description                               = (AlertDescription)GetInt32(new IntPtr(p + 0x011)); // 02466B40DA78 0x11 Description                 ( 0001866A0EE0 ModelEnumType AlertDescription AlertDescription AlertDescription Int32 )

            return value;
        }
    }
}
