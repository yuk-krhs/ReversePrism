using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferPos                                ModelPrimitiveType int int int Int32
    // 014 BufferSize                               ModelPrimitiveType int int int Int32
    // 018 BufferSizeAfterLimit                     ModelPrimitiveType int int int Int32
    // 01C CurrentLimit                             ModelPrimitiveType int int int Int32
    // 020 TotalBytesRetired                        ModelPrimitiveType int int int Int32
    // 024 RecursionDepth                           ModelPrimitiveType int int int Int32
    // 028 SegmentedBufferHelper                    ModelEnumType SegmentedBufferHelper SegmentedBufferHelper SegmentedBufferHelper Int32
    // 070 LastTag                                  ModelPrimitiveType uint uint uint UInt32
    // 074 NextTag                                  ModelPrimitiveType uint uint uint UInt32
    // 078 HasNextTag                               ModelPrimitiveType bool bool bool Bool
    // 07C SizeLimit                                ModelPrimitiveType int int int Int32
    // 080 RecursionLimit                           ModelPrimitiveType int int int Int32
    // 084 DiscardUnknownFields                     ModelPrimitiveType bool bool bool Bool
    // 088 ExtensionRegistry                        ModelClassType ExtensionRegistry ExtensionRegistry ExtensionRegistry Pointer
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

            value.BufferPos                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 BufferPos                   ( ModelPrimitiveType int int int Int32 )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 BufferSize                  ( ModelPrimitiveType int int int Int32 )
            value.BufferSizeAfterLimit                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 BufferSizeAfterLimit        ( ModelPrimitiveType int int int Int32 )
            value.CurrentLimit                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurrentLimit                ( ModelPrimitiveType int int int Int32 )
            value.TotalBytesRetired                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalBytesRetired           ( ModelPrimitiveType int int int Int32 )
            value.RecursionDepth                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 RecursionDepth              ( ModelPrimitiveType int int int Int32 )
            value.SegmentedBufferHelper                     = (SegmentedBufferHelper)GetInt32(new IntPtr(p + 0x028)); // 0x28 SegmentedBufferHelper       ( ModelEnumType SegmentedBufferHelper SegmentedBufferHelper SegmentedBufferHelper Int32 )
            value.LastTag                                   = GetUInt32(new IntPtr(p + 0x070)); // 0x70 LastTag                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.NextTag                                   = GetUInt32(new IntPtr(p + 0x074)); // 0x74 NextTag                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.HasNextTag                                = GetBool(new IntPtr(p + 0x078)); // 0x78 HasNextTag                  ( ModelPrimitiveType bool bool bool Bool )
            value.SizeLimit                                 = GetInt32(new IntPtr(p + 0x07C)); // 0x7C SizeLimit                   ( ModelPrimitiveType int int int Int32 )
            value.RecursionLimit                            = GetInt32(new IntPtr(p + 0x080)); // 0x80 RecursionLimit              ( ModelPrimitiveType int int int Int32 )
            value.DiscardUnknownFields                      = GetBool(new IntPtr(p + 0x084)); // 0x84 DiscardUnknownFields        ( ModelPrimitiveType bool bool bool Bool )
            value.ExtensionRegistry                         = GetObject<ExtensionRegistry>(new IntPtr(p + 0x088), ReversePrism.DataModels.ExtensionRegistry.FromPointer); // 0x88 ExtensionRegistry           ( ModelClassType ExtensionRegistry ExtensionRegistry ExtensionRegistry Pointer )

            return value;
        }
    }
}
