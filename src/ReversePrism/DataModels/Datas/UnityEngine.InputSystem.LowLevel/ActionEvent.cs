using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseEvent                                0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32
    // 024 M_ControlIndex                           000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 026 M_BindingIndex                           000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 028 M_InteractionIndex                       000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 02A M_StateIndex                             00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B M_Phase                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C M_StartTime                              0001865C2950 ModelPrimitiveType double double double Double
    // 034 M_ValueData                              000186688830 ModelEnumType <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer Int32
    public partial class ActionEvent
    {
        public InputEvent                               BaseEvent                               { get; set; }
        public ushort                                   M_ControlIndex                          { get; set; }
        public ushort                                   M_BindingIndex                          { get; set; }
        public ushort                                   M_InteractionIndex                      { get; set; }
        public sbyte                                    M_StateIndex                            { get; set; }
        public sbyte                                    M_Phase                                 { get; set; }
        public double                                   M_StartTime                             { get; set; }
        public <m_ValueData>e__FixedBuffer              M_ValueData                             { get; set; }

        public static ActionEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionEvent();

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0270D77FF1F0 0x10 BaseEvent                   ( 0001866FCF10 ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.M_ControlIndex                            = GetUInt16(new IntPtr(p + 0x024)); // 0270D77FF210 0x24 M_ControlIndex              ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_BindingIndex                            = GetUInt16(new IntPtr(p + 0x026)); // 0270D77FF230 0x26 M_BindingIndex              ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_InteractionIndex                        = GetUInt16(new IntPtr(p + 0x028)); // 0270D77FF250 0x28 M_InteractionIndex          ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_StateIndex                              = GetSByte(new IntPtr(p + 0x02A)); // 0270D77FF270 0x2A M_StateIndex                ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Phase                                   = GetSByte(new IntPtr(p + 0x02B)); // 0270D77FF290 0x2B M_Phase                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_StartTime                               = GetDouble(new IntPtr(p + 0x02C)); // 0270D77FF2B0 0x2C M_StartTime                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_ValueData                               = (<m_ValueData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x034)); // 0270D77FF2D0 0x34 M_ValueData                 ( 000186688830 ModelEnumType <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
