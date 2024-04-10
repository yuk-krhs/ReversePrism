using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     0001865C2E50 ModelPrimitiveType double double double Double
    // 018 Version                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C ControlIndex                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C M_StateWithoutControlIndex               00018652A0E0 ModelEnumType <m_StateWithoutControlIndex>e__FixedBuffer <m_StateWithoutControlIndex>e__FixedBuffer <m_StateWithoutControlIndex>e__FixedBuffer Int32
    // 020 M_StateWithControlIndex                  000186529BC0 ModelEnumType <m_StateWithControlIndex>e__FixedBuffer <m_StateWithControlIndex>e__FixedBuffer <m_StateWithControlIndex>e__FixedBuffer Int32
    // 000 kSizeWithControlIndex                    int IL2CPP_TYPE_I4
    // 000 kSizeWithoutControlIndex                 int IL2CPP_TYPE_I4
    public partial class RecordHeader : DataModel
    {
        public double                                   Time                                    { get; set; }
        public uint                                     Version                                 { get; set; }
        public int                                      ControlIndex                            { get; set; }
        public <m_StateWithoutControlIndex>e__FixedBuffer M_StateWithoutControlIndex              { get; set; }
        public <m_StateWithControlIndex>e__FixedBuffer  M_StateWithControlIndex                 { get; set; }

        public static RecordHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordHeader() { Pointer= p0 };

            value.Time                                      = GetDouble(new IntPtr(p + 0x010)); // 02466788AA90 0x10 Time                        ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Version                                   = GetUInt32(new IntPtr(p + 0x018)); // 02466788AAB0 0x18 Version                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ControlIndex                              = GetInt32(new IntPtr(p + 0x01C)); // 02466788AAD0 0x1C ControlIndex                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_StateWithoutControlIndex                = (<m_StateWithoutControlIndex>e__FixedBuffer)GetInt32(new IntPtr(p + 0x01C)); // 02466788AAF0 0x1C M_StateWithoutControlIndex  ( 00018652A0E0 ModelEnumType <m_StateWithoutControlIndex>e__FixedBuffer <m_StateWithoutControlIndex>e__FixedBuffer <m_StateWithoutControlIndex>e__FixedBuffer Int32 )
            value.M_StateWithControlIndex                   = (<m_StateWithControlIndex>e__FixedBuffer)GetInt32(new IntPtr(p + 0x020)); // 02466788AB10 0x20 M_StateWithControlIndex     ( 000186529BC0 ModelEnumType <m_StateWithControlIndex>e__FixedBuffer <m_StateWithControlIndex>e__FixedBuffer <m_StateWithControlIndex>e__FixedBuffer Int32 )

            return value;
        }
    }
}
