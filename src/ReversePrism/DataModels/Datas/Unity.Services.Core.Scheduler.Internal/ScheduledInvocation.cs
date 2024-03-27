using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   000186679A00 ModelClassType Action Action Action Pointer
    // 018 InvocationTime                           0001865B97F0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 ActionId                                 0001865F7E40 ModelPrimitiveType long long long Int64
    public partial class ScheduledInvocation
    {
        public Action?                                  Action                                  { get; set; }
        public DateTime                                 InvocationTime                          { get; set; }
        public long                                     ActionId                                { get; set; }

        public static ScheduledInvocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduledInvocation();

            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0270066276A8 0x10 Action                      ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.InvocationTime                            = GetDateTime(new IntPtr(p + 0x018)); // 0270066276C8 0x18 InvocationTime              ( 0001865B97F0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ActionId                                  = GetInt64(new IntPtr(p + 0x020)); // 0270066276E8 0x20 ActionId                    ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
