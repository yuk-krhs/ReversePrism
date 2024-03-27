using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _array                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 018 Head                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Tail                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 GrowFactor                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class Queue
    {
        public int                                      Head                                    { get; set; }
        public int                                      Tail                                    { get; set; }
        public int                                      Size                                    { get; set; }
        public int                                      GrowFactor                              { get; set; }
        public int                                      Version                                 { get; set; }

        public static Queue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Queue();

            value.Head                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D6BBDE30 0x18 Head                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Tail                                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D6BBDE50 0x1C Tail                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D6BBDE70 0x20 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrowFactor                                = GetInt32(new IntPtr(p + 0x024)); // 0270D6BBDE90 0x24 GrowFactor                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D6BBDEB0 0x28 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
