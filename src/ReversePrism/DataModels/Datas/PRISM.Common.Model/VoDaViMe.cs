using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vo                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 VoAdditional                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Da                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C DaAdditional                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Vi                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 ViAdditional                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Me                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C MeAdditional                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Cost                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VoDaViMe : DataModel
    {
        public int                                      Vo                                      { get; set; }
        public int                                      VoAdditional                            { get; set; }
        public int                                      Da                                      { get; set; }
        public int                                      DaAdditional                            { get; set; }
        public int                                      Vi                                      { get; set; }
        public int                                      ViAdditional                            { get; set; }
        public int                                      Me                                      { get; set; }
        public int                                      MeAdditional                            { get; set; }
        public int                                      Cost                                    { get; set; }

        public static VoDaViMe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoDaViMe() { Pointer= p0 };

            value.Vo                                        = GetInt32(new IntPtr(p + 0x010)); // 0246654F7910 0x10 Vo                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoAdditional                              = GetInt32(new IntPtr(p + 0x014)); // 0246654F7930 0x14 VoAdditional                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Da                                        = GetInt32(new IntPtr(p + 0x018)); // 0246654F7950 0x18 Da                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DaAdditional                              = GetInt32(new IntPtr(p + 0x01C)); // 0246654F7970 0x1C DaAdditional                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Vi                                        = GetInt32(new IntPtr(p + 0x020)); // 0246654F7990 0x20 Vi                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ViAdditional                              = GetInt32(new IntPtr(p + 0x024)); // 0246654F79B0 0x24 ViAdditional                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Me                                        = GetInt32(new IntPtr(p + 0x028)); // 0246654F79D0 0x28 Me                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MeAdditional                              = GetInt32(new IntPtr(p + 0x02C)); // 0246654F79F0 0x2C MeAdditional                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 0246654F7A10 0x30 Cost                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
