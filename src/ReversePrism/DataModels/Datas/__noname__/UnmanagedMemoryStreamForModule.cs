using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Module                                   000186614A60 ModelClassType Module Module Module Pointer
    public partial class UnmanagedMemoryStreamForModule
    {
        public Module?                                  Module                                  { get; set; }

        public static UnmanagedMemoryStreamForModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnmanagedMemoryStreamForModule();

            value.Module                                    = GetObject<Module>(new IntPtr(p + 0x068), ReversePrism.DataModels.Module.FromPointer); // 0270D0E92350 0x68 Module                      ( 000186614A60 ModelClassType Module Module Module Pointer )

            return value;
        }
    }
}
