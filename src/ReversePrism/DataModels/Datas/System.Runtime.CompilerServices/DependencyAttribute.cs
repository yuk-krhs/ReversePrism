using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DependentAssembly                        ModelPrimitiveType string string string String
    // 018 LoadHint                                 ModelEnumType LoadHint LoadHint LoadHint Int32
    public partial class DependencyAttribute : DataModel
    {
        public string                                   DependentAssembly                       { get; set; }
        public LoadHint                                 LoadHint                                { get; set; }

        public static DependencyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DependencyAttribute() { Pointer= p0 };

            value.DependentAssembly                         = GetString(new IntPtr(p + 0x010)); // 0x10 DependentAssembly           ( ModelPrimitiveType string string string String )
            value.LoadHint                                  = (LoadHint)GetInt32(new IntPtr(p + 0x018)); // 0x18 LoadHint                    ( ModelEnumType LoadHint LoadHint LoadHint Int32 )

            return value;
        }
    }
}
