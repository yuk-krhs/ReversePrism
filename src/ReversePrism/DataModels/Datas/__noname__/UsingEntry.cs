using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 comparer                                 IComparer`1<UsingEntry> IL2CPP_TYPE_GENERICINST
    // 010 Alias                                    0001866722E0 ModelPrimitiveType string string string String
    // 018 Path                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Asset                                    00018652C4B0 ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer
    public partial class UsingEntry : DataModel
    {
        public string                                   Alias                                   { get; set; }
        public string                                   Path                                    { get; set; }
        public VisualTreeAsset?                         Asset                                   { get; set; }

        public static UsingEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsingEntry() { Pointer= p0 };

            value.Alias                                     = GetString(new IntPtr(p + 0x010)); // 0245A6815A30 0x10 Alias                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x018)); // 0245A6815A50 0x18 Path                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Asset                                     = GetObject<VisualTreeAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualTreeAsset.FromPointer); // 0245A6815A70 0x20 Asset                       ( 00018652C4B0 ModelClassType VisualTreeAsset VisualTreeAsset VisualTreeAsset Pointer )

            return value;
        }
    }
}
