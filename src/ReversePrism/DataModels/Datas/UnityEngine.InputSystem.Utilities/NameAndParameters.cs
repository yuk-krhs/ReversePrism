using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 <parameters>k__BackingField              ReadOnlyArray`1<NamedValue> IL2CPP_TYPE_GENERICINST
    public partial class NameAndParameters : DataModel
    {
        public string                                   Name                                    { get; set; }

        public static NameAndParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameAndParameters() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0246676FC918 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
