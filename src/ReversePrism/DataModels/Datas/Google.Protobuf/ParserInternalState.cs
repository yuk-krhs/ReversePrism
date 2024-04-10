using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferPos                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 BufferSize                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 BufferSizeAfterLimit                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C CurrentLimit                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 TotalBytesRetired                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 RecursionDepth                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 SegmentedBufferHelper                    000186661E40 ModelEnumType SegmentedBufferHelper SegmentedBufferHelper SegmentedBufferHelper Int32
    // 070 LastTag                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 074 NextTag                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 078 HasNextTag                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 07C SizeLimit                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 080 RecursionLimit                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 084 DiscardUnknownFields                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 ExtensionRegistry                        000186532AA0 ModelClassType ExtensionRegistry ExtensionRegistry ExtensionRegistry Pointer
    public partial class ParserInternalState : DataModel
    {
        public int                                      BufferPos                               { get; set; }
        public int                                      BufferSize                              { get; set; }
        public int                                      BufferSizeAfterLimit                    { get; set; }
        public int                                      CurrentLimit                            { get; set; }
        public int                                      TotalBytesRetired                       { get; set; }
        public int                                      RecursionDepth                          { get; set; }
        public SegmentedBufferHelper                    SegmentedBufferHelper                   { get; set; }
        public uint                                     LastTag                                 { get; set; }
        public uint                                     NextTag                                 { get; set; }
        public bool                                     HasNextTag                              { get; set; }
        public int                                      SizeLimit                               { get; set; }
        public int                                      RecursionLimit                          { get; set; }
        public bool                                     DiscardUnknownFields                    { get; set; }
        public ExtensionRegistry?                       ExtensionRegistry                       { get; set; }

        public static ParserInternalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParserInternalState() { Pointer= p0 };

            value.BufferPos                                 = GetInt32(new IntPtr(p + 0x010)); // 0245A1F49590 0x10 BufferPos                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x014)); // 0245A1F495B0 0x14 BufferSize                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BufferSizeAfterLimit                      = GetInt32(new IntPtr(p + 0x018)); // 0245A1F495D0 0x18 BufferSizeAfterLimit        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CurrentLimit                              = GetInt32(new IntPtr(p + 0x01C)); // 0245A1F495F0 0x1C CurrentLimit                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TotalBytesRetired                         = GetInt32(new IntPtr(p + 0x020)); // 0245A1F49610 0x20 TotalBytesRetired           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.RecursionDepth                            = GetInt32(new IntPtr(p + 0x024)); // 0245A1F49630 0x24 RecursionDepth              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SegmentedBufferHelper                     = (SegmentedBufferHelper)GetInt32(new IntPtr(p + 0x028)); // 0245A1F49650 0x28 SegmentedBufferHelper       ( 000186661E40 ModelEnumType SegmentedBufferHelper SegmentedBufferHelper SegmentedBufferHelper Int32 )
            value.LastTag                                   = GetUInt32(new IntPtr(p + 0x070)); // 0245A1F49670 0x70 LastTag                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.NextTag                                   = GetUInt32(new IntPtr(p + 0x074)); // 0245A1F49690 0x74 NextTag                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.HasNextTag                                = GetBool(new IntPtr(p + 0x078)); // 0245A1F496B0 0x78 HasNextTag                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.SizeLimit                                 = GetInt32(new IntPtr(p + 0x07C)); // 0245A1F496D0 0x7C SizeLimit                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.RecursionLimit                            = GetInt32(new IntPtr(p + 0x080)); // 0245A1F496F0 0x80 RecursionLimit              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DiscardUnknownFields                      = GetBool(new IntPtr(p + 0x084)); // 0245A1F49710 0x84 DiscardUnknownFields        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExtensionRegistry                         = GetObject<ExtensionRegistry>(new IntPtr(p + 0x088), ReversePrism.DataModels.ExtensionRegistry.FromPointer); // 0245A1F49730 0x88 ExtensionRegistry           ( 000186532AA0 ModelClassType ExtensionRegistry ExtensionRegistry ExtensionRegistry Pointer )

            return value;
        }
    }
}
