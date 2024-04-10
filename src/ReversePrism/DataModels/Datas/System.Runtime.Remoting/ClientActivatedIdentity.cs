using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 TargetThis                               0001865D6F20 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer
    public partial class ClientActivatedIdentity : DataModel
    {
        public MarshalByRefObject?                      TargetThis                              { get; set; }

        public static ClientActivatedIdentity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientActivatedIdentity() { Pointer= p0 };

            value.TargetThis                                = GetObject<MarshalByRefObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.MarshalByRefObject.FromPointer); // 024666C30808 0x70 TargetThis                  ( 0001865D6F20 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer )

            return value;
        }
    }
}
