using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     00018668BF00 ModelEnumType NativeListDispose NativeListDispose NativeListDispose Int32
    public partial class NativeListDisposeJob : DataModel
    {
        public NativeListDispose                        Data                                    { get; set; }

        public static NativeListDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeListDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeListDispose)GetInt32(new IntPtr(p + 0x010)); // 0245A3568428 0x10 Data                        ( 00018668BF00 ModelEnumType NativeListDispose NativeListDispose NativeListDispose Int32 )

            return value;
        }
    }
}
