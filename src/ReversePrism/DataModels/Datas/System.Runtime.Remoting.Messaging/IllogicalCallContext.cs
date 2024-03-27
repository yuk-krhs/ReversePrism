using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Datastore                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 m_HostContext                            <object> IL2CPP_TYPE_OBJECT
    public partial class IllogicalCallContext
    {
        public Hashtable?                               M_Datastore                             { get; set; }

        public static IllogicalCallContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IllogicalCallContext();

            value.M_Datastore                               = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6ACB8D0 0x10 M_Datastore                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
