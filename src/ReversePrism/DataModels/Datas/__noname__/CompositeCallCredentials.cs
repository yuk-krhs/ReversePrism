using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Credentials                              ModelClassListType IReadOnlyList`1<CallCredentials> IReadOnlyList`1<CallCredentials> List<CallCredentials> Pointer
    public partial class CompositeCallCredentials : DataModel
    {
        public List<CallCredentials>?                   Credentials                             { get; set; }

        public static CompositeCallCredentials? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompositeCallCredentials() { Pointer= p0 };

            value.Credentials                               = GetObjectList<CallCredentials>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallCredentials.FromPointer); // 0x10 Credentials                 ( ModelClassListType IReadOnlyList`1<CallCredentials> IReadOnlyList`1<CallCredentials> List<CallCredentials> Pointer )

            return value;
        }
    }
}
