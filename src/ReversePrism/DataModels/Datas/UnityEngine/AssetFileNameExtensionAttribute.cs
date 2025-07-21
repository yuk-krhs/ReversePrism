using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PreferredExtension                       ModelPrimitiveType string string string String
    // 018 <otherExtensions>k__BackingField         IEnumerable`1<string> IL2CPP_TYPE_GENERICINST
    public partial class AssetFileNameExtensionAttribute : DataModel
    {
        public string                                   PreferredExtension                      { get; set; }

        public static AssetFileNameExtensionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetFileNameExtensionAttribute() { Pointer= p0 };

            value.PreferredExtension                        = GetString(new IntPtr(p + 0x010)); // 0x10 PreferredExtension          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
