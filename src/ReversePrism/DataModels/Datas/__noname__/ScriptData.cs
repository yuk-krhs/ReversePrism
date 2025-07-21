using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Command                                  ModelPrimitiveType int int int Int32
    // 014 Idata1                                   ModelPrimitiveType int int int Int32
    // 014 Fdata1                                   ModelPrimitiveType float float float Single
    // 018 Idata2                                   ModelPrimitiveType int int int Int32
    // 018 Fdata2                                   ModelPrimitiveType float float float Single
    // 01C Idata3                                   ModelPrimitiveType int int int Int32
    // 01C Fdata3                                   ModelPrimitiveType float float float Single
    // 020 Idata4                                   ModelPrimitiveType int int int Int32
    // 020 Fdata4                                   ModelPrimitiveType float float float Single
    public partial class ScriptData : DataModel
    {
        public int                                      Command                                 { get; set; }
        public int                                      Idata1                                  { get; set; }
        public float                                    Fdata1                                  { get; set; }
        public int                                      Idata2                                  { get; set; }
        public float                                    Fdata2                                  { get; set; }
        public int                                      Idata3                                  { get; set; }
        public float                                    Fdata3                                  { get; set; }
        public int                                      Idata4                                  { get; set; }
        public float                                    Fdata4                                  { get; set; }

        public static ScriptData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptData() { Pointer= p0 };

            value.Command                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 Command                     ( ModelPrimitiveType int int int Int32 )
            value.Idata1                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Idata1                      ( ModelPrimitiveType int int int Int32 )
            value.Fdata1                                    = GetSingle(new IntPtr(p + 0x014)); // 0x14 Fdata1                      ( ModelPrimitiveType float float float Single )
            value.Idata2                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Idata2                      ( ModelPrimitiveType int int int Int32 )
            value.Fdata2                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 Fdata2                      ( ModelPrimitiveType float float float Single )
            value.Idata3                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Idata3                      ( ModelPrimitiveType int int int Int32 )
            value.Fdata3                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Fdata3                      ( ModelPrimitiveType float float float Single )
            value.Idata4                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Idata4                      ( ModelPrimitiveType int int int Int32 )
            value.Fdata4                                    = GetSingle(new IntPtr(p + 0x020)); // 0x20 Fdata4                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
