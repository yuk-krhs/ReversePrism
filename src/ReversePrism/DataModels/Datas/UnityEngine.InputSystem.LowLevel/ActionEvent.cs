using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseEvent                                ModelEnumType InputEvent InputEvent InputEvent Int32
    // 024 M_ControlIndex                           ModelPrimitiveType ushort ushort ushort UInt16
    // 026 M_BindingIndex                           ModelPrimitiveType ushort ushort ushort UInt16
    // 028 M_InteractionIndex                       ModelPrimitiveType ushort ushort ushort UInt16
    // 02A M_StateIndex                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02B M_Phase                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02C M_StartTime                              ModelPrimitiveType double double double Double
    // 034 M_ValueData                              ModelEnumType <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer Int32
    public partial class ActionEvent : DataModel
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
            var value   = new ActionEvent() { Pointer= p0 };

            value.BaseEvent                                 = (InputEvent)GetInt32(new IntPtr(p + 0x010)); // 0x10 BaseEvent                   ( ModelEnumType InputEvent InputEvent InputEvent Int32 )
            value.M_ControlIndex                            = GetUInt16(new IntPtr(p + 0x024)); // 0x24 M_ControlIndex              ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_BindingIndex                            = GetUInt16(new IntPtr(p + 0x026)); // 0x26 M_BindingIndex              ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_InteractionIndex                        = GetUInt16(new IntPtr(p + 0x028)); // 0x28 M_InteractionIndex          ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_StateIndex                              = GetSByte(new IntPtr(p + 0x02A)); // 0x2A M_StateIndex                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Phase                                   = GetSByte(new IntPtr(p + 0x02B)); // 0x2B M_Phase                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_StartTime                               = GetDouble(new IntPtr(p + 0x02C)); // 0x2C M_StartTime                 ( ModelPrimitiveType double double double Double )
            value.M_ValueData                               = (<m_ValueData>e__FixedBuffer)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_ValueData                 ( ModelEnumType <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer <m_ValueData>e__FixedBuffer Int32 )

            return value;
        }
    }
}
