using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArgumentIndex                            0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ByRefUpdater
    {
        public int                                      ArgumentIndex                           { get; set; }

        public static ByRefUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByRefUpdater();

            value.ArgumentIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0270D9FA0B18 0x10 ArgumentIndex               ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
