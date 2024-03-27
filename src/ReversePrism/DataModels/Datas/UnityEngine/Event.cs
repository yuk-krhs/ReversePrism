using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 000 s_Current                                Event IL2CPP_TYPE_CLASS
    // 008 s_MasterEvent                            Event IL2CPP_TYPE_CLASS
    public partial class Event
    {

        public static Event? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Event();


            return value;
        }
    }
}
