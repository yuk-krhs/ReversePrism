using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ControlCount                           ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_InteractionCount                       ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_ProcessorCount                         ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_MapIndex                               ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_Flags                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_PartIndex                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 M_ActionIndex                            ModelPrimitiveType ushort ushort ushort UInt16
    // 018 M_CompositeOrCompositeBindingIndex       ModelPrimitiveType ushort ushort ushort UInt16
    // 01A M_ProcessorStartIndex                    ModelPrimitiveType ushort ushort ushort UInt16
    // 01C M_InteractionStartIndex                  ModelPrimitiveType ushort ushort ushort UInt16
    // 01E M_ControlStartIndex                      ModelPrimitiveType ushort ushort ushort UInt16
    // 020 M_PressTime                              ModelPrimitiveType double double double Double
    // 028 M_TriggerEventIdForComposite             ModelPrimitiveType int int int Int32
    // 02C Padding                                  ModelPrimitiveType int int int Int32
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

            value.M_ControlCount                            = GetSByte(new IntPtr(p + 0x010)); // 0x10 M_ControlCount              ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_InteractionCount                        = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_InteractionCount          ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ProcessorCount                          = GetSByte(new IntPtr(p + 0x012)); // 0x12 M_ProcessorCount            ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_MapIndex                                = GetSByte(new IntPtr(p + 0x013)); // 0x13 M_MapIndex                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Flags                                   = GetSByte(new IntPtr(p + 0x014)); // 0x14 M_Flags                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_PartIndex                               = GetSByte(new IntPtr(p + 0x015)); // 0x15 M_PartIndex                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ActionIndex                             = GetUInt16(new IntPtr(p + 0x016)); // 0x16 M_ActionIndex               ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_CompositeOrCompositeBindingIndex        = GetUInt16(new IntPtr(p + 0x018)); // 0x18 M_CompositeOrCompositeBindingIndex ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_ProcessorStartIndex                     = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A M_ProcessorStartIndex       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_InteractionStartIndex                   = GetUInt16(new IntPtr(p + 0x01C)); // 0x1C M_InteractionStartIndex     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_ControlStartIndex                       = GetUInt16(new IntPtr(p + 0x01E)); // 0x1E M_ControlStartIndex         ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_PressTime                               = GetDouble(new IntPtr(p + 0x020)); // 0x20 M_PressTime                 ( ModelPrimitiveType double double double Double )
            value.M_TriggerEventIdForComposite              = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_TriggerEventIdForComposite ( ModelPrimitiveType int int int Int32 )
            value.Padding                                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Padding                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
