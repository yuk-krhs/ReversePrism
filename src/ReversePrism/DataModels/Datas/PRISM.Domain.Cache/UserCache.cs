using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 User                                     0001866347C0 ModelClassType ISelfStatus ISelfStatus ISelfStatus Pointer
    // 018 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UserCache : DataModel
    {
        public ISelfStatus?                             User                                    { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static UserCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserCache() { Pointer= p0 };

            value.User                                      = GetObject<ISelfStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISelfStatus.FromPointer); // 0245A4AE2478 0x10 User                        ( 0001866347C0 ModelClassType ISelfStatus ISelfStatus ISelfStatus Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 0245A4AE2498 0x18 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
