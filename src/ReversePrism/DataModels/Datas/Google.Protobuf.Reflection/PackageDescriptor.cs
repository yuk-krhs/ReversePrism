using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 FullName                                 ModelPrimitiveType string string string String
    // 020 File                                     ModelClassType FileDescriptor FileDescriptor FileDescriptor Pointer
    public partial class PackageDescriptor : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   FullName                                { get; set; }
        public FileDescriptor?                          File                                    { get; set; }

        public static PackageDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PackageDescriptor() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.FullName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 FullName                    ( ModelPrimitiveType string string string String )
            value.File                                      = GetObject<FileDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.FileDescriptor.FromPointer); // 0x20 File                        ( ModelClassType FileDescriptor FileDescriptor FileDescriptor Pointer )

            return value;
        }
    }
}
