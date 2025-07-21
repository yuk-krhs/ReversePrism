using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Extension                                ModelClassType Extension Extension Extension Pointer
    // 018 Helper                                   ModelClassType IExtensionReflectionHelper IExtensionReflectionHelper IExtensionReflectionHelper Pointer
    // 020 Descriptor                               ModelClassType FieldDescriptor FieldDescriptor FieldDescriptor Pointer
    public partial class ExtensionAccessor : DataModel
    {
        public Extension?                               Extension                               { get; set; }
        public IExtensionReflectionHelper?              Helper                                  { get; set; }
        public FieldDescriptor?                         Descriptor                              { get; set; }

        public static ExtensionAccessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionAccessor() { Pointer= p0 };

            value.Extension                                 = GetObject<Extension>(new IntPtr(p + 0x010), ReversePrism.DataModels.Extension.FromPointer); // 0x10 Extension                   ( ModelClassType Extension Extension Extension Pointer )
            value.Helper                                    = GetObject<IExtensionReflectionHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtensionReflectionHelper.FromPointer); // 0x18 Helper                      ( ModelClassType IExtensionReflectionHelper IExtensionReflectionHelper IExtensionReflectionHelper Pointer )
            value.Descriptor                                = GetObject<FieldDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.FieldDescriptor.FromPointer); // 0x20 Descriptor                  ( ModelClassType FieldDescriptor FieldDescriptor FieldDescriptor Pointer )

            return value;
        }
    }
}
