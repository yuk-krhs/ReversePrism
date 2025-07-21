using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Calls                                  ModelClassListType List`1<PersistentCall> List`1<PersistentCall> List<PersistentCall> Pointer
    public partial class PersistentCallGroup : DataModel
    {
        public List<PersistentCall>?                    M_Calls                                 { get; set; }

        public static PersistentCallGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersistentCallGroup() { Pointer= p0 };

            value.M_Calls                                   = GetObjectList<PersistentCall>(new IntPtr(p + 0x010), ReversePrism.DataModels.PersistentCall.FromPointer); // 0x10 M_Calls                     ( ModelClassListType List`1<PersistentCall> List`1<PersistentCall> List<PersistentCall> Pointer )

            return value;
        }
    }
}
