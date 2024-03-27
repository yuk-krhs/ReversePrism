using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 listPool                                 List`1<KeyValuePair`2<IUniTaskSource, ValueTuple`4<string, int, DateTime, string>>> IL2CPP_TYPE_GENERICINST
    // 008 tracking                                 WeakDictionary`2<IUniTaskSource, ValueTuple`4<string, int, DateTime, string>> IL2CPP_TYPE_GENERICINST
    // 010 Dirty                                    000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class TaskTracker
    {
        public bool                                     Dirty                                   { get; set; }

        public static TaskTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskTracker();

            value.Dirty                                     = GetBool(new IntPtr(p + 0x010)); // 0270D8BD0E68 0x10 Dirty                       ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
