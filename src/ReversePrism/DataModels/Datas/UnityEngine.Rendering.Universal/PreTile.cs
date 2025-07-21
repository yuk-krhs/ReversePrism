using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlaneLeft                                ModelEnumType float4 float4 float4 Int32
    // 020 PlaneRight                               ModelEnumType float4 float4 float4 Int32
    // 030 PlaneBottom                              ModelEnumType float4 float4 float4 Int32
    // 040 PlaneTop                                 ModelEnumType float4 float4 float4 Int32
    public partial class PreTile : DataModel
    {
        public float4                                   PlaneLeft                               { get; set; }
        public float4                                   PlaneRight                              { get; set; }
        public float4                                   PlaneBottom                             { get; set; }
        public float4                                   PlaneTop                                { get; set; }

        public static PreTile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreTile() { Pointer= p0 };

            value.PlaneLeft                                 = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 PlaneLeft                   ( ModelEnumType float4 float4 float4 Int32 )
            value.PlaneRight                                = (float4)GetInt32(new IntPtr(p + 0x020)); // 0x20 PlaneRight                  ( ModelEnumType float4 float4 float4 Int32 )
            value.PlaneBottom                               = (float4)GetInt32(new IntPtr(p + 0x030)); // 0x30 PlaneBottom                 ( ModelEnumType float4 float4 float4 Int32 )
            value.PlaneTop                                  = (float4)GetInt32(new IntPtr(p + 0x040)); // 0x40 PlaneTop                    ( ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
