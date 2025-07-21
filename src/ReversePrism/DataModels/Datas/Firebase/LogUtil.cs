using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                LogUtil IL2CPP_TYPE_CLASS
    // 008 InitializeLoggingLock                    <object> IL2CPP_TYPE_OBJECT
    // 010 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class LogUtil : DataModel
    {
        public bool                                     Disposed                                { get; set; }

        public static LogUtil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogUtil() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
