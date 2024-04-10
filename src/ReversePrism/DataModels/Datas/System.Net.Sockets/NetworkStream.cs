using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 StreamSocket                             000186521A10 ModelClassType Socket Socket Socket Pointer
    // 030 OwnsSocket                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 031 Readable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 Writeable                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 CloseTimeout                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 CleanedUp                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C CurrentReadTimeout                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 CurrentWriteTimeout                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class NetworkStream : DataModel
    {
        public Socket?                                  StreamSocket                            { get; set; }
        public bool                                     OwnsSocket                              { get; set; }
        public bool                                     Readable                                { get; set; }
        public bool                                     Writeable                               { get; set; }
        public int                                      CloseTimeout                            { get; set; }
        public bool                                     CleanedUp                               { get; set; }
        public int                                      CurrentReadTimeout                      { get; set; }
        public int                                      CurrentWriteTimeout                     { get; set; }

        public static NetworkStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetworkStream() { Pointer= p0 };

            value.StreamSocket                              = GetObject<Socket>(new IntPtr(p + 0x028), ReversePrism.DataModels.Socket.FromPointer); // 0246679A2B70 0x28 StreamSocket                ( 000186521A10 ModelClassType Socket Socket Socket Pointer )
            value.OwnsSocket                                = GetBool(new IntPtr(p + 0x030)); // 0246679A2B90 0x30 OwnsSocket                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Readable                                  = GetBool(new IntPtr(p + 0x031)); // 0246679A2BB0 0x31 Readable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Writeable                                 = GetBool(new IntPtr(p + 0x032)); // 0246679A2BD0 0x32 Writeable                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CloseTimeout                              = GetInt32(new IntPtr(p + 0x034)); // 0246679A2BF0 0x34 CloseTimeout                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CleanedUp                                 = GetBool(new IntPtr(p + 0x038)); // 0246679A2C10 0x38 CleanedUp                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentReadTimeout                        = GetInt32(new IntPtr(p + 0x03C)); // 0246679A2C30 0x3C CurrentReadTimeout          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentWriteTimeout                       = GetInt32(new IntPtr(p + 0x040)); // 0246679A2C50 0x40 CurrentWriteTimeout         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
