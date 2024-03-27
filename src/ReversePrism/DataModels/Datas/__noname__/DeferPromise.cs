using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    // 018 Task                                     00018669FD00 ModelEnumType UniTask UniTask UniTask Int32
    // 028 Awaiter                                  000186716C40 ModelEnumType Awaiter Awaiter Awaiter Int32
    public partial class DeferPromise
    {
        public UniTask                                  Task                                    { get; set; }
        public Awaiter                                  Awaiter                                 { get; set; }

        public static DeferPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeferPromise();

            value.Task                                      = (UniTask)GetInt32(new IntPtr(p + 0x018)); // 0270D8BED5E0 0x18 Task                        ( 00018669FD00 ModelEnumType UniTask UniTask UniTask Int32 )
            value.Awaiter                                   = (Awaiter)GetInt32(new IntPtr(p + 0x028)); // 0270D8BED600 0x28 Awaiter                     ( 000186716C40 ModelEnumType Awaiter Awaiter Awaiter Int32 )

            return value;
        }
    }
}
