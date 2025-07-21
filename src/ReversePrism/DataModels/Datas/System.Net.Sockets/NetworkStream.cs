using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 StreamSocket                             ModelClassType Socket Socket Socket Pointer
    // 030 OwnsSocket                               ModelPrimitiveType bool bool bool Bool
    // 031 Readable                                 ModelPrimitiveType bool bool bool Bool
    // 032 Writeable                                ModelPrimitiveType bool bool bool Bool
    // 034 CloseTimeout                             ModelPrimitiveType int int int Int32
    // 038 CleanedUp                                ModelPrimitiveType bool bool bool Bool
    // 03C CurrentReadTimeout                       ModelPrimitiveType int int int Int32
    // 040 CurrentWriteTimeout                      ModelPrimitiveType int int int Int32
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

            value.StreamSocket                              = GetObject<Socket>(new IntPtr(p + 0x028), ReversePrism.DataModels.Socket.FromPointer); // 0x28 StreamSocket                ( ModelClassType Socket Socket Socket Pointer )
            value.OwnsSocket                                = GetBool(new IntPtr(p + 0x030)); // 0x30 OwnsSocket                  ( ModelPrimitiveType bool bool bool Bool )
            value.Readable                                  = GetBool(new IntPtr(p + 0x031)); // 0x31 Readable                    ( ModelPrimitiveType bool bool bool Bool )
            value.Writeable                                 = GetBool(new IntPtr(p + 0x032)); // 0x32 Writeable                   ( ModelPrimitiveType bool bool bool Bool )
            value.CloseTimeout                              = GetInt32(new IntPtr(p + 0x034)); // 0x34 CloseTimeout                ( ModelPrimitiveType int int int Int32 )
            value.CleanedUp                                 = GetBool(new IntPtr(p + 0x038)); // 0x38 CleanedUp                   ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentReadTimeout                        = GetInt32(new IntPtr(p + 0x03C)); // 0x3C CurrentReadTimeout          ( ModelPrimitiveType int int int Int32 )
            value.CurrentWriteTimeout                       = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentWriteTimeout         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
