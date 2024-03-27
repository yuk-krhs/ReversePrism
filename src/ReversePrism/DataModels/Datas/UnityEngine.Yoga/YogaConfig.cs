using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  YogaConfig IL2CPP_TYPE_CLASS
    // 010 _ygConfig                                <int> IL2CPP_TYPE_I
    // 018 Logger                                   0001865B1F80 ModelClassType Logger Logger Logger Pointer
    public partial class YogaConfig
    {
        public Logger?                                  Logger                                  { get; set; }

        public static YogaConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YogaConfig();

            value.Logger                                    = GetObject<Logger>(new IntPtr(p + 0x018), ReversePrism.DataModels.Logger.FromPointer); // 0270066DB498 0x18 Logger                      ( 0001865B1F80 ModelClassType Logger Logger Logger Pointer )

            return value;
        }
    }
}
