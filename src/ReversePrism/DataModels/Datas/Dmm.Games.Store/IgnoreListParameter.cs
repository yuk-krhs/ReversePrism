using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Guid                                     ModelPrimitiveType string string string String
    // 030 Selector                                 ModelPrimitiveType string string string String
    // 038 Pid                                      ModelPrimitiveType string string string String
    // 040 Count                                    ModelPrimitiveType int int int Int32
    // 044 StartIndex                               ModelPrimitiveType int int int Int32
    public partial class IgnoreListParameter : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Selector                                { get; set; }
        public string                                   Pid                                     { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      StartIndex                              { get; set; }

        public static IgnoreListParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IgnoreListParameter() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Guid                        ( ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x030)); // 0x30 Selector                    ( ModelPrimitiveType string string string String )
            value.Pid                                       = GetString(new IntPtr(p + 0x038)); // 0x38 Pid                         ( ModelPrimitiveType string string string String )
            value.Count                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Count                       ( ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x044)); // 0x44 StartIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
