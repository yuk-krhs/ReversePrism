using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     IntPtr IL2CPP_TYPE_PTR
    // 018 Data                                     ModelEnumType <Data>e__FixedBuffer <Data>e__FixedBuffer <Data>e__FixedBuffer Int32
    public partial class UnsafeStreamBlock : DataModel
    {
        public <Data>e__FixedBuffer                     Data                                    { get; set; }

        public static UnsafeStreamBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeStreamBlock() { Pointer= p0 };

            value.Data                                      = (<Data>e__FixedBuffer)GetInt32(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelEnumType <Data>e__FixedBuffer <Data>e__FixedBuffer <Data>e__FixedBuffer Int32 )

            return value;
        }
    }
}
