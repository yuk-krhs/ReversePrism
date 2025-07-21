using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _pointer                                 IntPtr IL2CPP_TYPE_PTR
    // 018 Handle                                   ModelEnumType GCHandle GCHandle GCHandle Int32
    // 020 Pinnable                                 ModelClassType IPinnable IPinnable IPinnable Pointer
    public partial class MemoryHandle : DataModel
    {
        public GCHandle                                 Handle                                  { get; set; }
        public IPinnable?                               Pinnable                                { get; set; }

        public static MemoryHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryHandle() { Pointer= p0 };

            value.Handle                                    = (GCHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 Handle                      ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.Pinnable                                  = GetObject<IPinnable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPinnable.FromPointer); // 0x20 Pinnable                    ( ModelClassType IPinnable IPinnable IPinnable Pointer )

            return value;
        }
    }
}
