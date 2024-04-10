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
    public partial class SerializedBundleRef : DataModel
    {
        public string                                   AssemblyQualifiedName                   { get; set; }
        public PostProcessBundle?                       Bundle                                  { get; set; }

        public static SerializedBundleRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializedBundleRef() { Pointer= p0 };

            value.AssemblyQualifiedName                     = GetString(new IntPtr(p + 0x010)); // 024663333C88 0x10 AssemblyQualifiedName       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Bundle                                    = GetObject<PostProcessBundle>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessBundle.FromPointer); // 024663333CA8 0x18 Bundle                      ( 00018676A300 ModelClassType PostProcessBundle PostProcessBundle PostProcessBundle Pointer )

            return value;
        }
    }
}
