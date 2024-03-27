using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hangle                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Vangle                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C NeckRate                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 HandIKOn                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 NeckLerpFrame                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class NeckIKData
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
            var value   = new NeckIKData();

            value.Hangle                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D4D85F30 0x10 Hangle                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Vangle                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D4D85F50 0x14 Vangle                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0270D4D85F70 0x18 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NeckRate                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D4D85F90 0x1C NeckRate                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HandIKOn                                  = GetBool(new IntPtr(p + 0x020)); // 0270D4D85FB0 0x20 HandIKOn                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeckLerpFrame                             = GetInt32(new IntPtr(p + 0x024)); // 0270D4D85FD0 0x24 NeckLerpFrame               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
