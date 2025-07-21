using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DirectMessageId                          ModelPrimitiveType string string string String
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 Body                                     ModelPrimitiveType string string string String
    // 028 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 IsNew                                    ModelPrimitiveType bool bool bool Bool
    public partial class DirectMessageModel : DataModel
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
            var value   = new DirectMessageModel() { Pointer= p0 };

            value.DirectMessageId                           = GetString(new IntPtr(p + 0x010)); // 0x10 DirectMessageId             ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Body                        ( ModelPrimitiveType string string string String )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x028)); // 0x28 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x038)); // 0x38 IsNew                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
