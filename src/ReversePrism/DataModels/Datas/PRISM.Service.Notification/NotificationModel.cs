using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    ModelPrimitiveType string string string String
    // 018 Message                                  ModelPrimitiveType string string string String
    // 020 Kind                                     ModelEnumType Kind Kind Kind Int32
    // 028 NotificationTime                         ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 IsShowForeground                         ModelPrimitiveType bool bool bool Bool
    public partial class NotificationModel : DataModel
    {
        public string                                   Title                                   { get; set; }
        public string                                   Message                                 { get; set; }
        public Kind                                     Kind                                    { get; set; }
        public DateTime                                 NotificationTime                        { get; set; }
        public bool                                     IsShowForeground                        { get; set; }

        public static NotificationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotificationModel() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Title                       ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Message                     ( ModelPrimitiveType string string string String )
            value.Kind                                      = (Kind)GetInt32(new IntPtr(p + 0x020)); // 0x20 Kind                        ( ModelEnumType Kind Kind Kind Int32 )
            value.NotificationTime                          = GetDateTime(new IntPtr(p + 0x028)); // 0x28 NotificationTime            ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsShowForeground                          = GetBool(new IntPtr(p + 0x038)); // 0x38 IsShowForeground            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
