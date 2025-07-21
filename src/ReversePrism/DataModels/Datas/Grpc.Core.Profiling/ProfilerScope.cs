using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Profiler                                 ModelClassType IProfiler IProfiler IProfiler Pointer
    // 018 Tag                                      ModelPrimitiveType string string string String
    public partial class ProfilerScope : DataModel
    {
        public IProfiler?                               Profiler                                { get; set; }
        public string                                   Tag                                     { get; set; }

        public static ProfilerScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerScope() { Pointer= p0 };

            value.Profiler                                  = GetObject<IProfiler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProfiler.FromPointer); // 0x10 Profiler                    ( ModelClassType IProfiler IProfiler IProfiler Pointer )
            value.Tag                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Tag                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
