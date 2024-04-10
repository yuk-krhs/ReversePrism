using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 Predictor                                000186774D90 ModelClassType Predictor Predictor Predictor Pointer
    // 020 Platform                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 Graph                                    0001866722E0 ModelPrimitiveType string string string String
    // 030 Format                                   0001866722E0 ModelPrimitiveType string string string String
    // 038 Flags                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Session : DataModel
    {
        public string                                   Id                                      { get; set; }
        public Predictor?                               Predictor                               { get; set; }
        public string                                   Platform                                { get; set; }
        public string                                   Graph                                   { get; set; }
        public string                                   Format                                  { get; set; }
        public int                                      Flags                                   { get; set; }

        public static Session? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Session() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 02466BE3F5D8 0x10 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Predictor                                 = GetObject<Predictor>(new IntPtr(p + 0x018), ReversePrism.DataModels.Predictor.FromPointer); // 02466BE3F5F8 0x18 Predictor                   ( 000186774D90 ModelClassType Predictor Predictor Predictor Pointer )
            value.Platform                                  = GetString(new IntPtr(p + 0x020)); // 02466BE3F618 0x20 Platform                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Graph                                     = GetString(new IntPtr(p + 0x028)); // 02466BE3F638 0x28 Graph                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Format                                    = GetString(new IntPtr(p + 0x030)); // 02466BE3F658 0x30 Format                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x038)); // 02466BE3F678 0x38 Flags                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
