using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OwnerThreadId                            ModelPrimitiveType int int int Int32
    // 018 queue                                    Queue`1<Action> IL2CPP_TYPE_GENERICINST
    public partial class Dispatcher : DataModel
    {
        public int                                      OwnerThreadId                           { get; set; }

        public static Dispatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Dispatcher() { Pointer= p0 };

            value.OwnerThreadId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 OwnerThreadId               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
