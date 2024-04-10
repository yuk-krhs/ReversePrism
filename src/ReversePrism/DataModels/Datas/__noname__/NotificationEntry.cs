using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     0001865C2E50 ModelPrimitiveType double double double Double
    // 018 Payload                                  0001865C1240 ModelClassType INotification INotification INotification Pointer
    // 020 NotificationFired                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 022 Flags                                    0001866B1BA0 ModelEnumType NotificationFlags NotificationFlags NotificationFlags Int32
    public partial class NotificationEntry : DataModel
    {
        public double                                   Time                                    { get; set; }
        public INotification?                           Payload                                 { get; set; }
        public bool                                     NotificationFired                       { get; set; }
        public NotificationFlags                        Flags                                   { get; set; }

        public static NotificationEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationEntry() { Pointer= p0 };

            value.Time                                      = GetDouble(new IntPtr(p + 0x010)); // 02466B30B038 0x10 Time                        ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Payload                                   = GetObject<INotification>(new IntPtr(p + 0x018), ReversePrism.DataModels.INotification.FromPointer); // 02466B30B058 0x18 Payload                     ( 0001865C1240 ModelClassType INotification INotification INotification Pointer )
            value.NotificationFired                         = GetBool(new IntPtr(p + 0x020)); // 02466B30B078 0x20 NotificationFired           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Flags                                     = (NotificationFlags)GetInt32(new IntPtr(p + 0x022)); // 02466B30B098 0x22 Flags                       ( 0001866B1BA0 ModelEnumType NotificationFlags NotificationFlags NotificationFlags Int32 )

            return value;
        }
    }
}
