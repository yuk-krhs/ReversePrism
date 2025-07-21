using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType GameObject GameObject GameObject Pointer
    // 018 Behaviour                                ModelEnumType LinkBehaviour LinkBehaviour LinkBehaviour Int32
    // 01C LastSeenActive                           ModelPrimitiveType bool bool bool Bool
    public partial class TweenLink : DataModel
    {
        public GameObject?                              Target                                  { get; set; }
        public LinkBehaviour                            Behaviour                               { get; set; }
        public bool                                     LastSeenActive                          { get; set; }

        public static TweenLink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenLink() { Pointer= p0 };

            value.Target                                    = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 Target                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Behaviour                                 = (LinkBehaviour)GetInt32(new IntPtr(p + 0x018)); // 0x18 Behaviour                   ( ModelEnumType LinkBehaviour LinkBehaviour LinkBehaviour Int32 )
            value.LastSeenActive                            = GetBool(new IntPtr(p + 0x01C)); // 0x1C LastSeenActive              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
