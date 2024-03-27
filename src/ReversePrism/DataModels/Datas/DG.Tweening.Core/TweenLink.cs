using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001865D8B30 ModelClassType GameObject GameObject GameObject Pointer
    // 018 Behaviour                                0001865316A0 ModelEnumType LinkBehaviour LinkBehaviour LinkBehaviour Int32
    // 01C LastSeenActive                           000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TweenLink
    {
        public GameObject?                              Target                                  { get; set; }
        public LinkBehaviour                            Behaviour                               { get; set; }
        public bool                                     LastSeenActive                          { get; set; }

        public static TweenLink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenLink();

            value.Target                                    = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 02700434E078 0x10 Target                      ( 0001865D8B30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Behaviour                                 = (LinkBehaviour)GetInt32(new IntPtr(p + 0x018)); // 02700434E098 0x18 Behaviour                   ( 0001865316A0 ModelEnumType LinkBehaviour LinkBehaviour LinkBehaviour Int32 )
            value.LastSeenActive                            = GetBool(new IntPtr(p + 0x01C)); // 02700434E0B8 0x1C LastSeenActive              ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
