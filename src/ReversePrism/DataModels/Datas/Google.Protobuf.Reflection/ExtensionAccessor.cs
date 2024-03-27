using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Extension                                0001865CFEB0 ModelClassType Extension Extension Extension Pointer
    // 018 Helper                                   0001866BF630 ModelClassType IExtensionReflectionHelper IExtensionReflectionHelper IExtensionReflectionHelper Pointer
    // 020 Descriptor                               000186571FF0 ModelClassType FieldDescriptor FieldDescriptor FieldDescriptor Pointer
    public partial class ExtensionAccessor
    {
        public Extension?                               Extension                               { get; set; }
        public IExtensionReflectionHelper?              Helper                                  { get; set; }
        public FieldDescriptor?                         Descriptor                              { get; set; }

        public static ExtensionAccessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionAccessor();

            value.Extension                                 = GetObject<Extension>(new IntPtr(p + 0x010), ReversePrism.DataModels.Extension.FromPointer); // 0270D0D4EC40 0x10 Extension                   ( 0001865CFEB0 ModelClassType Extension Extension Extension Pointer )
            value.Helper                                    = GetObject<IExtensionReflectionHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtensionReflectionHelper.FromPointer); // 0270D0D4EC60 0x18 Helper                      ( 0001866BF630 ModelClassType IExtensionReflectionHelper IExtensionReflectionHelper IExtensionReflectionHelper Pointer )
            value.Descriptor                                = GetObject<FieldDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.FieldDescriptor.FromPointer); // 0270D0D4EC80 0x20 Descriptor                  ( 000186571FF0 ModelClassType FieldDescriptor FieldDescriptor FieldDescriptor Pointer )

            return value;
        }
    }
}
