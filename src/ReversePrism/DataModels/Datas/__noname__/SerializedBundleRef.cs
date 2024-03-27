using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemblyQualifiedName                    0001866722E0 ModelPrimitiveType string string string String
    // 018 Bundle                                   00018676A300 ModelClassType PostProcessBundle PostProcessBundle PostProcessBundle Pointer
    public partial class SerializedBundleRef
    {
        public string                                   AssemblyQualifiedName                   { get; set; }
        public PostProcessBundle?                       Bundle                                  { get; set; }

        public static SerializedBundleRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializedBundleRef();

            value.AssemblyQualifiedName                     = GetString(new IntPtr(p + 0x010)); // 0270D3357390 0x10 AssemblyQualifiedName       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Bundle                                    = GetObject<PostProcessBundle>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessBundle.FromPointer); // 0270D33573B0 0x18 Bundle                      ( 00018676A300 ModelClassType PostProcessBundle PostProcessBundle PostProcessBundle Pointer )

            return value;
        }
    }
}
