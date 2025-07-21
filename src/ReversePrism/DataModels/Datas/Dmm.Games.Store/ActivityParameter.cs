using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Guid                                     ModelPrimitiveType string string string String
    // 030 Selector                                 ModelPrimitiveType string string string String
    // 038 AppId                                    ModelPrimitiveType string string string String
    // 040 Title                                    ModelPrimitiveType string string string String
    // 048 Url                                      ModelPrimitiveType string string string String
    // 050 MobileUrl                                ModelPrimitiveType string string string String
    // 058 TouchUrl                                 ModelPrimitiveType string string string String
    public partial class ActivityParameter : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Selector                                { get; set; }
        public string                                   AppId                                   { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Url                                     { get; set; }
        public string                                   MobileUrl                               { get; set; }
        public string                                   TouchUrl                                { get; set; }

        public static ActivityParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivityParameter() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Guid                        ( ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x030)); // 0x30 Selector                    ( ModelPrimitiveType string string string String )
            value.AppId                                     = GetString(new IntPtr(p + 0x038)); // 0x38 AppId                       ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Title                       ( ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x048)); // 0x48 Url                         ( ModelPrimitiveType string string string String )
            value.MobileUrl                                 = GetString(new IntPtr(p + 0x050)); // 0x50 MobileUrl                   ( ModelPrimitiveType string string string String )
            value.TouchUrl                                  = GetString(new IntPtr(p + 0x058)); // 0x58 TouchUrl                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
