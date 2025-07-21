using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _array                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 018 Head                                     ModelPrimitiveType int int int Int32
    // 01C Tail                                     ModelPrimitiveType int int int Int32
    // 020 Size                                     ModelPrimitiveType int int int Int32
    // 024 GrowFactor                               ModelPrimitiveType int int int Int32
    // 028 Version                                  ModelPrimitiveType int int int Int32
    // 030 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class Queue : DataModel
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
            var value   = new Queue() { Pointer= p0 };

            value.Head                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Head                        ( ModelPrimitiveType int int int Int32 )
            value.Tail                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Tail                        ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType int int int Int32 )
            value.GrowFactor                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 GrowFactor                  ( ModelPrimitiveType int int int Int32 )
            value.Version                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 Version                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
