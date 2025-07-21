using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelPrimitiveType string string string String
    // 018 M_IsReadOnly                             ModelPrimitiveType bool bool bool Bool
    public partial class ConfigurationEntry : DataModel
    {
        public string                                   M_Value                                 { get; set; }
        public bool                                     M_IsReadOnly                            { get; set; }

        public static ConfigurationEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfigurationEntry() { Pointer= p0 };

            value.M_Value                                   = GetString(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelPrimitiveType string string string String )
            value.M_IsReadOnly                              = GetBool(new IntPtr(p + 0x018)); // 0x18 M_IsReadOnly                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
