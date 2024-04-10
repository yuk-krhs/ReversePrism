using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ControlCount                           00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_InteractionCount                       00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_ProcessorCount                         00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_MapIndex                               00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_Flags                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_PartIndex                              00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 M_ActionIndex                            000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 M_CompositeOrCompositeBindingIndex       000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A M_ProcessorStartIndex                    000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C M_InteractionStartIndex                  000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E M_ControlStartIndex                      000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 020 M_PressTime                              0001865C2950 ModelPrimitiveType double double double Double
    // 028 M_TriggerEventIdForComposite             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C Padding                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BindingState : DataModel
    {
        public sbyte                                    M_ControlCount                          { get; set; }
        public sbyte                                    M_InteractionCount                      { get; set; }
        public sbyte                                    M_ProcessorCount                        { get; set; }
        public sbyte                                    M_MapIndex                              { get; set; }
        public sbyte                                    M_Flags                                 { get; set; }
        public sbyte                                    M_PartIndex                             { get; set; }
        public ushort                                   M_ActionIndex                           { get; set; }
        public ushort                                   M_CompositeOrCompositeBindingIndex      { get; set; }
        public ushort                                   M_ProcessorStartIndex                   { get; set; }
        public ushort                                   M_InteractionStartIndex                 { get; set; }
        public ushort                                   M_ControlStartIndex                     { get; set; }
        public double                                   M_PressTime                             { get; set; }
        public int                                      M_TriggerEventIdForComposite            { get; set; }
        public int                                      Padding                                 { get; set; }

        public static BindingState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindingState() { Pointer= p0 };

            value.M_ControlCount                            = GetSByte(new IntPtr(p + 0x010)); // 0246676DBF70 0x10 M_ControlCount              ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_InteractionCount                        = GetSByte(new IntPtr(p + 0x011)); // 0246676DBF90 0x11 M_InteractionCount          ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ProcessorCount                          = GetSByte(new IntPtr(p + 0x012)); // 0246676DBFB0 0x12 M_ProcessorCount            ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_MapIndex                                = GetSByte(new IntPtr(p + 0x013)); // 0246676DBFD0 0x13 M_MapIndex                  ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Flags                                   = GetSByte(new IntPtr(p + 0x014)); // 0246676DBFF0 0x14 M_Flags                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_PartIndex                               = GetSByte(new IntPtr(p + 0x015)); // 0246676DC010 0x15 M_PartIndex                 ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ActionIndex                             = GetUInt16(new IntPtr(p + 0x016)); // 0246676DC030 0x16 M_ActionIndex               ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_CompositeOrCompositeBindingIndex        = GetUInt16(new IntPtr(p + 0x018)); // 0246676DC050 0x18 M_CompositeOrCompositeBindingIndex ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_ProcessorStartIndex                     = GetUInt16(new IntPtr(p + 0x01A)); // 0246676DC070 0x1A M_ProcessorStartIndex       ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_InteractionStartIndex                   = GetUInt16(new IntPtr(p + 0x01C)); // 0246676DC090 0x1C M_InteractionStartIndex     ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_ControlStartIndex                       = GetUInt16(new IntPtr(p + 0x01E)); // 0246676DC0B0 0x1E M_ControlStartIndex         ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_PressTime                               = GetDouble(new IntPtr(p + 0x020)); // 0246676DC0D0 0x20 M_PressTime                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_TriggerEventIdForComposite              = GetInt32(new IntPtr(p + 0x028)); // 0246676DC0F0 0x28 M_TriggerEventIdForComposite ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Padding                                   = GetInt32(new IntPtr(p + 0x02C)); // 0246676DC110 0x2C Padding                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
