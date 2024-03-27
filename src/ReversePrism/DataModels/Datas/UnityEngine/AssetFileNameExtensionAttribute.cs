using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PreferredExtension                       000186672F10 ModelPrimitiveType string string string String
    // 018 <otherExtensions>k__BackingField         IEnumerable`1<string> IL2CPP_TYPE_GENERICINST
    public partial class AssetFileNameExtensionAttribute
    {
        public string                                   PreferredExtension                      { get; set; }

        public static AssetFileNameExtensionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetFileNameExtensionAttribute();

            value.PreferredExtension                        = GetString(new IntPtr(p + 0x010)); // 027006978958 0x10 PreferredExtension          ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
