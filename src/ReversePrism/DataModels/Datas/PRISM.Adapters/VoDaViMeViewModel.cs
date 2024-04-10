using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vo                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 VoAdditional                             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Da                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 01C DaAdditional                             0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Vi                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 024 ViAdditional                             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 Me                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 02C MeAdditional                             0001865F4260 ModelPrimitiveType int int int Int32
    // 030 Cost                                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class VoDaViMeViewModel : DataModel
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

        public static VoDaViMeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoDaViMeViewModel() { Pointer= p0 };

            value.Vo                                        = GetInt32(new IntPtr(p + 0x010)); // 024665F318C0 0x10 Vo                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.VoAdditional                              = GetInt32(new IntPtr(p + 0x014)); // 024665F318E0 0x14 VoAdditional                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Da                                        = GetInt32(new IntPtr(p + 0x018)); // 024665F31900 0x18 Da                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.DaAdditional                              = GetInt32(new IntPtr(p + 0x01C)); // 024665F31920 0x1C DaAdditional                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Vi                                        = GetInt32(new IntPtr(p + 0x020)); // 024665F31940 0x20 Vi                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ViAdditional                              = GetInt32(new IntPtr(p + 0x024)); // 024665F31960 0x24 ViAdditional                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Me                                        = GetInt32(new IntPtr(p + 0x028)); // 024665F31980 0x28 Me                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MeAdditional                              = GetInt32(new IntPtr(p + 0x02C)); // 024665F319A0 0x2C MeAdditional                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 024665F319C0 0x30 Cost                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
