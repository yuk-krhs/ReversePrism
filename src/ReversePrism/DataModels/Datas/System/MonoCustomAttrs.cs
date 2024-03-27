using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 corlib                                   Assembly IL2CPP_TYPE_CLASS
    // FFFFFFFF usage_cache                              Dictionary`2<Type, AttributeUsageAttribute> IL2CPP_TYPE_GENERICINST
    // 008 DefaultAttributeUsage                    AttributeUsageAttribute IL2CPP_TYPE_CLASS
    public partial class MonoCustomAttrs
    {

        public static MonoCustomAttrs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoCustomAttrs();


            return value;
        }
    }
}
