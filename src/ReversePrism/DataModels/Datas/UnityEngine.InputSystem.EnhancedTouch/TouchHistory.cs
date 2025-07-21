using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_History                                InputStateHistory`1<TouchState> IL2CPP_TYPE_GENERICINST
    // 018 M_Finger                                 ModelClassType Finger Finger Finger Pointer
    // 020 M_Count                                  ModelPrimitiveType int int int Int32
    // 024 M_StartIndex                             ModelPrimitiveType int int int Int32
    // 028 M_Version                                ModelPrimitiveType uint uint uint UInt32
    public partial class TouchHistory : DataModel
    {
        public Finger?                                  M_Finger                                { get; set; }
        public int                                      M_Count                                 { get; set; }
        public int                                      M_StartIndex                            { get; set; }
        public uint                                     M_Version                               { get; set; }

        public static TouchHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchHistory() { Pointer= p0 };

            value.M_Finger                                  = GetObject<Finger>(new IntPtr(p + 0x018), ReversePrism.DataModels.Finger.FromPointer); // 0x18 M_Finger                    ( ModelClassType Finger Finger Finger Pointer )
            value.M_Count                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Count                     ( ModelPrimitiveType int int int Int32 )
            value.M_StartIndex                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_StartIndex                ( ModelPrimitiveType int int int Int32 )
            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x028)); // 0x28 M_Version                   ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
