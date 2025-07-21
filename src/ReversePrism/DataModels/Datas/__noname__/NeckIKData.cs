using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hangle                                   ModelPrimitiveType int int int Int32
    // 014 Vangle                                   ModelPrimitiveType int int int Int32
    // 018 StartFrame                               ModelPrimitiveType int int int Int32
    // 01C NeckRate                                 ModelPrimitiveType int int int Int32
    // 020 HandIKOn                                 ModelPrimitiveType bool bool bool Bool
    // 024 NeckLerpFrame                            ModelPrimitiveType int int int Int32
    public partial class NeckIKData : DataModel
    {
        public int                                      Hangle                                  { get; set; }
        public int                                      Vangle                                  { get; set; }
        public int                                      StartFrame                              { get; set; }
        public int                                      NeckRate                                { get; set; }
        public bool                                     HandIKOn                                { get; set; }
        public int                                      NeckLerpFrame                           { get; set; }

        public static NeckIKData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NeckIKData() { Pointer= p0 };

            value.Hangle                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Hangle                      ( ModelPrimitiveType int int int Int32 )
            value.Vangle                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Vangle                      ( ModelPrimitiveType int int int Int32 )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartFrame                  ( ModelPrimitiveType int int int Int32 )
            value.NeckRate                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NeckRate                    ( ModelPrimitiveType int int int Int32 )
            value.HandIKOn                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 HandIKOn                    ( ModelPrimitiveType bool bool bool Bool )
            value.NeckLerpFrame                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 NeckLerpFrame               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
