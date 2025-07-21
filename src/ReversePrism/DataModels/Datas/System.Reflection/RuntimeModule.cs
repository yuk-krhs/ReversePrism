using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _impl                                    <int> IL2CPP_TYPE_I
    // 018 Assembly                                 ModelClassType Assembly Assembly Assembly Pointer
    // 020 Fqname                                   ModelPrimitiveType string string string String
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 Scopename                                ModelPrimitiveType string string string String
    // 038 Is_resource                              ModelPrimitiveType bool bool bool Bool
    // 03C Token                                    ModelPrimitiveType int int int Int32
    public partial class RuntimeModule : DataModel
    {
        public Assembly?                                Assembly                                { get; set; }
        public string                                   Fqname                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Scopename                               { get; set; }
        public bool                                     Is_resource                             { get; set; }
        public int                                      Token                                   { get; set; }

        public static RuntimeModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeModule() { Pointer= p0 };

            value.Assembly                                  = GetObject<Assembly>(new IntPtr(p + 0x018), ReversePrism.DataModels.Assembly.FromPointer); // 0x18 Assembly                    ( ModelClassType Assembly Assembly Assembly Pointer )
            value.Fqname                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Fqname                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.Scopename                                 = GetString(new IntPtr(p + 0x030)); // 0x30 Scopename                   ( ModelPrimitiveType string string string String )
            value.Is_resource                               = GetBool(new IntPtr(p + 0x038)); // 0x38 Is_resource                 ( ModelPrimitiveType bool bool bool Bool )
            value.Token                                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Token                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
