using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Calls                                  000185CF9058 ModelClassListType List`1<PersistentCall> List`1<PersistentCall> List<PersistentCall> Pointer
    public partial class PersistentCallGroup
    {
        public List<PersistentCall>?                    M_Calls                                 { get; set; }

        public static PersistentCallGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersistentCallGroup();

            value.M_Calls                                   = GetObjectList<PersistentCall>(new IntPtr(p + 0x010), ReversePrism.DataModels.PersistentCall.FromPointer); // 0270D0935470 0x10 M_Calls                     ( 000185CF9058 ModelClassListType List`1<PersistentCall> List`1<PersistentCall> List<PersistentCall> Pointer )

            return value;
        }
    }
}
