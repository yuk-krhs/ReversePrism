using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 FullName                                 000186672F10 ModelPrimitiveType string string string String
    // 020 File                                     000186579C90 ModelClassType FileDescriptor FileDescriptor FileDescriptor Pointer
    public partial class DescriptorBase
    {
        public int                                      Index                                   { get; set; }
        public string                                   FullName                                { get; set; }
        public FileDescriptor?                          File                                    { get; set; }

        public static DescriptorBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DescriptorBase();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 02700404CFD0 0x10 Index                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FullName                                  = GetString(new IntPtr(p + 0x018)); // 02700404CFF0 0x18 FullName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.File                                      = GetObject<FileDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.FileDescriptor.FromPointer); // 02700404D010 0x20 File                        ( 000186579C90 ModelClassType FileDescriptor FileDescriptor FileDescriptor Pointer )

            return value;
        }
    }
}
