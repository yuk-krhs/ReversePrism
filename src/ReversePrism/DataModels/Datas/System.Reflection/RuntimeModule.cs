using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _impl                                    <int> IL2CPP_TYPE_I
    // 018 Assembly                                 00018658B170 ModelClassType Assembly Assembly Assembly Pointer
    // 020 Fqname                                   000186671BA0 ModelPrimitiveType string string string String
    // 028 Name                                     000186671BA0 ModelPrimitiveType string string string String
    // 030 Scopename                                000186671BA0 ModelPrimitiveType string string string String
    // 038 Is_resource                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 03C Token                                    0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.Assembly                                  = GetObject<Assembly>(new IntPtr(p + 0x018), ReversePrism.DataModels.Assembly.FromPointer); // 0245A3CC1188 0x18 Assembly                    ( 00018658B170 ModelClassType Assembly Assembly Assembly Pointer )
            value.Fqname                                    = GetString(new IntPtr(p + 0x020)); // 0245A3CC11A8 0x20 Fqname                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0245A3CC11C8 0x28 Name                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Scopename                                 = GetString(new IntPtr(p + 0x030)); // 0245A3CC11E8 0x30 Scopename                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Is_resource                               = GetBool(new IntPtr(p + 0x038)); // 0245A3CC1208 0x38 Is_resource                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Token                                     = GetInt32(new IntPtr(p + 0x03C)); // 0245A3CC1228 0x3C Token                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
