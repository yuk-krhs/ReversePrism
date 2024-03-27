using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DirectMessageId                          000186671910 ModelPrimitiveType string string string String
    // 018 Title                                    000186671910 ModelPrimitiveType string string string String
    // 020 Body                                     000186671910 ModelPrimitiveType string string string String
    // 028 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DirectMessageModel
    {
        public string                                   DirectMessageId                         { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Body                                    { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public bool                                     IsNew                                   { get; set; }

        public static DirectMessageModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageModel();

            value.DirectMessageId                           = GetString(new IntPtr(p + 0x010)); // 0270D4CA3C70 0x10 DirectMessageId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0270D4CA3C90 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x020)); // 0270D4CA3CB0 0x20 Body                        ( 000186671910 ModelPrimitiveType string string string String )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x028)); // 0270D4CA3CD0 0x28 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x038)); // 0270D4CA3CF0 0x38 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
