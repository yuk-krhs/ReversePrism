using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Enabled                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_ReadMask                               ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_WriteMask                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_Padding                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_CompareFunctionFront                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_PassOperationFront                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 M_FailOperationFront                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 M_ZFailOperationFront                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 M_CompareFunctionBack                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 M_PassOperationBack                      ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A M_FailOperationBack                      ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B M_ZFailOperationBack                     ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class StencilState : DataModel
    {
        public sbyte                                    M_Enabled                               { get; set; }
        public sbyte                                    M_ReadMask                              { get; set; }
        public sbyte                                    M_WriteMask                             { get; set; }
        public sbyte                                    M_Padding                               { get; set; }
        public sbyte                                    M_CompareFunctionFront                  { get; set; }
        public sbyte                                    M_PassOperationFront                    { get; set; }
        public sbyte                                    M_FailOperationFront                    { get; set; }
        public sbyte                                    M_ZFailOperationFront                   { get; set; }
        public sbyte                                    M_CompareFunctionBack                   { get; set; }
        public sbyte                                    M_PassOperationBack                     { get; set; }
        public sbyte                                    M_FailOperationBack                     { get; set; }
        public sbyte                                    M_ZFailOperationBack                    { get; set; }

        public static StencilState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StencilState() { Pointer= p0 };

            value.M_Enabled                                 = GetSByte(new IntPtr(p + 0x010)); // 0x10 M_Enabled                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ReadMask                                = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_ReadMask                  ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_WriteMask                               = GetSByte(new IntPtr(p + 0x012)); // 0x12 M_WriteMask                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Padding                                 = GetSByte(new IntPtr(p + 0x013)); // 0x13 M_Padding                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_CompareFunctionFront                    = GetSByte(new IntPtr(p + 0x014)); // 0x14 M_CompareFunctionFront      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_PassOperationFront                      = GetSByte(new IntPtr(p + 0x015)); // 0x15 M_PassOperationFront        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_FailOperationFront                      = GetSByte(new IntPtr(p + 0x016)); // 0x16 M_FailOperationFront        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ZFailOperationFront                     = GetSByte(new IntPtr(p + 0x017)); // 0x17 M_ZFailOperationFront       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_CompareFunctionBack                     = GetSByte(new IntPtr(p + 0x018)); // 0x18 M_CompareFunctionBack       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_PassOperationBack                       = GetSByte(new IntPtr(p + 0x019)); // 0x19 M_PassOperationBack         ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_FailOperationBack                       = GetSByte(new IntPtr(p + 0x01A)); // 0x1A M_FailOperationBack         ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ZFailOperationBack                      = GetSByte(new IntPtr(p + 0x01B)); // 0x1B M_ZFailOperationBack        ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
