using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Acc                                      ModelPrimitiveType ulong ulong ulong UInt64
    // 050 Buffer                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 150 IsHash64                                 ModelPrimitiveType int int int Int32
    // 154 BufferedSize                             ModelPrimitiveType int int int Int32
    // 158 NbStripesSoFar                           ModelPrimitiveType int int int Int32
    // 160 TotalLength                              ModelPrimitiveType long long long Int64
    // 168 Seed                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 170 SecretKey                                ModelPrimitiveType sbyte sbyte sbyte SByte
    // 22C PadEnd                                   ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class StreamingStateData : DataModel
    {
        public ulong                                    Acc                                     { get; set; }
        public sbyte                                    Buffer                                  { get; set; }
        public int                                      IsHash64                                { get; set; }
        public int                                      BufferedSize                            { get; set; }
        public int                                      NbStripesSoFar                          { get; set; }
        public long                                     TotalLength                             { get; set; }
        public ulong                                    Seed                                    { get; set; }
        public sbyte                                    SecretKey                               { get; set; }
        public sbyte                                    PadEnd                                  { get; set; }

        public static StreamingStateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamingStateData() { Pointer= p0 };

            value.Acc                                       = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Acc                         ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Buffer                                    = GetSByte(new IntPtr(p + 0x050)); // 0x50 Buffer                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.IsHash64                                  = GetInt32(new IntPtr(p + 0x150)); // 0x150 IsHash64                    ( ModelPrimitiveType int int int Int32 )
            value.BufferedSize                              = GetInt32(new IntPtr(p + 0x154)); // 0x154 BufferedSize                ( ModelPrimitiveType int int int Int32 )
            value.NbStripesSoFar                            = GetInt32(new IntPtr(p + 0x158)); // 0x158 NbStripesSoFar              ( ModelPrimitiveType int int int Int32 )
            value.TotalLength                               = GetInt64(new IntPtr(p + 0x160)); // 0x160 TotalLength                 ( ModelPrimitiveType long long long Int64 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x168)); // 0x168 Seed                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SecretKey                                 = GetSByte(new IntPtr(p + 0x170)); // 0x170 SecretKey                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.PadEnd                                    = GetSByte(new IntPtr(p + 0x22C)); // 0x22C PadEnd                      ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
