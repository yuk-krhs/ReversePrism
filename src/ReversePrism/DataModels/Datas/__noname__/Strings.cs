using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 none                                     string IL2CPP_TYPE_STRING
    // 008 camera                                   string IL2CPP_TYPE_STRING
    // 010 Parameter                                ModelPrimitiveType string string string String
    // 018 Component                                ModelPrimitiveType string string string String
    // 020 DebugViewNotSupported                    ModelPrimitiveType string string string String
    // 028 VolumeInfo                               ModelPrimitiveType string string string String
    // 030 InterpolatedValue                        ModelPrimitiveType string string string String
    // 038 DefaultValue                             ModelPrimitiveType string string string String
    // 040 Global                                   ModelPrimitiveType string string string String
    // 048 Local                                    ModelPrimitiveType string string string String
    public partial class Strings : DataModel
    {
        public string                                   Parameter                               { get; set; }
        public string                                   Component                               { get; set; }
        public string                                   DebugViewNotSupported                   { get; set; }
        public string                                   VolumeInfo                              { get; set; }
        public string                                   InterpolatedValue                       { get; set; }
        public string                                   DefaultValue                            { get; set; }
        public string                                   Global                                  { get; set; }
        public string                                   Local                                   { get; set; }

        public static Strings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Strings() { Pointer= p0 };

            value.Parameter                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Parameter                   ( ModelPrimitiveType string string string String )
            value.Component                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Component                   ( ModelPrimitiveType string string string String )
            value.DebugViewNotSupported                     = GetString(new IntPtr(p + 0x020)); // 0x20 DebugViewNotSupported       ( ModelPrimitiveType string string string String )
            value.VolumeInfo                                = GetString(new IntPtr(p + 0x028)); // 0x28 VolumeInfo                  ( ModelPrimitiveType string string string String )
            value.InterpolatedValue                         = GetString(new IntPtr(p + 0x030)); // 0x30 InterpolatedValue           ( ModelPrimitiveType string string string String )
            value.DefaultValue                              = GetString(new IntPtr(p + 0x038)); // 0x38 DefaultValue                ( ModelPrimitiveType string string string String )
            value.Global                                    = GetString(new IntPtr(p + 0x040)); // 0x40 Global                      ( ModelPrimitiveType string string string String )
            value.Local                                     = GetString(new IntPtr(p + 0x048)); // 0x48 Local                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
