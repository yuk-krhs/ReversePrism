using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Screen                                   0001866955E0 ModelClassType Touchscreen Touchscreen Touchscreen Pointer
    // 018 Index                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 020 m_StateHistory                           InputStateHistory`1<TouchState> IL2CPP_TYPE_GENERICINST
    public partial class Finger : DataModel
    {
        public Touchscreen?                             Screen                                  { get; set; }
        public int                                      Index                                   { get; set; }

        public static Finger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Finger() { Pointer= p0 };

            value.Screen                                    = GetObject<Touchscreen>(new IntPtr(p + 0x010), ReversePrism.DataModels.Touchscreen.FromPointer); // 024667832708 0x10 Screen                      ( 0001866955E0 ModelClassType Touchscreen Touchscreen Touchscreen Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 024667832728 0x18 Index                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
