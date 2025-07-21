using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelPrimitiveType string string string String
    // 018 CheckId                                  ModelPrimitiveType string string string String
    // 020 Scope                                    ModelPrimitiveType string string string String
    // 028 Target                                   ModelPrimitiveType string string string String
    // 030 MessageId                                ModelPrimitiveType string string string String
    // 038 Justification                            ModelPrimitiveType string string string String
    public partial class UnconditionalSuppressMessageAttribute : DataModel
    {
        public string                                   Category                                { get; set; }
        public string                                   CheckId                                 { get; set; }
        public string                                   Scope                                   { get; set; }
        public string                                   Target                                  { get; set; }
        public string                                   MessageId                               { get; set; }
        public string                                   Justification                           { get; set; }

        public static UnconditionalSuppressMessageAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnconditionalSuppressMessageAttribute() { Pointer= p0 };

            value.Category                                  = GetString(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelPrimitiveType string string string String )
            value.CheckId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CheckId                     ( ModelPrimitiveType string string string String )
            value.Scope                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Scope                       ( ModelPrimitiveType string string string String )
            value.Target                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Target                      ( ModelPrimitiveType string string string String )
            value.MessageId                                 = GetString(new IntPtr(p + 0x030)); // 0x30 MessageId                   ( ModelPrimitiveType string string string String )
            value.Justification                             = GetString(new IntPtr(p + 0x038)); // 0x38 Justification               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
