using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 logPublisher                             Subject`1<LogEntry> IL2CPP_TYPE_GENERICINST
    // 008 Listener                                 ObservableLogger IL2CPP_TYPE_CLASS
    public partial class ObservableLogger
    {

        public static ObservableLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableLogger();


            return value;
        }
    }
}
