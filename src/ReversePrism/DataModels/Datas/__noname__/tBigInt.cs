using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 c_BigInt_MaxBlocks                       int IL2CPP_TYPE_I4
    // 010 M_length                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 M_blocks                                 0001867681A0 ModelEnumType <m_blocks>e__FixedBuffer <m_blocks>e__FixedBuffer <m_blocks>e__FixedBuffer Int32
    public partial class tBigInt
    {
        public int                                      M_length                                { get; set; }
        public <m_blocks>e__FixedBuffer                 M_blocks                                { get; set; }

        public static tBigInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new tBigInt();

            value.M_length                                  = GetInt32(new IntPtr(p + 0x010)); // 0270DA8AA860 0x10 M_length                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_blocks                                  = (<m_blocks>e__FixedBuffer)GetInt32(new IntPtr(p + 0x014)); // 0270DA8AA880 0x14 M_blocks                    ( 0001867681A0 ModelEnumType <m_blocks>e__FixedBuffer <m_blocks>e__FixedBuffer <m_blocks>e__FixedBuffer Int32 )

            return value;
        }
    }
}
