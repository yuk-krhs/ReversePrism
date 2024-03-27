using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tag                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 Status                                   0001866722E0 ModelPrimitiveType string string string String
    // 020 AspectMode                               0001866722E0 ModelPrimitiveType string string string String
    // 028 Labels                                   000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Normalization                            0001866A92B0 ModelClassType Normalization Normalization Normalization Pointer
    // 038 AudioFormat                              0001867179C0 ModelClassType AudioFormat AudioFormat AudioFormat Pointer
    // 040 Type                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class Predictor
    {
        public string                                   Tag                                     { get; set; }
        public string                                   Status                                  { get; set; }
        public string                                   AspectMode                              { get; set; }
        public List<string>?                            Labels                                  { get; set; }
        public Normalization?                           Normalization                           { get; set; }
        public AudioFormat?                             AudioFormat                             { get; set; }
        public string                                   Type                                    { get; set; }

        public static Predictor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Predictor();

            value.Tag                                       = GetString(new IntPtr(p + 0x010)); // 0270DBDB7CA0 0x10 Tag                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Status                                    = GetString(new IntPtr(p + 0x018)); // 0270DBDB7CC0 0x18 Status                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AspectMode                                = GetString(new IntPtr(p + 0x020)); // 0270DBDB7CE0 0x20 AspectMode                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Labels                                    = GetStringList(new IntPtr(p + 0x028)); // 0270DBDB7D00 0x28 Labels                      ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Normalization                             = GetObject<Normalization>(new IntPtr(p + 0x030), ReversePrism.DataModels.Normalization.FromPointer); // 0270DBDB7D20 0x30 Normalization               ( 0001866A92B0 ModelClassType Normalization Normalization Normalization Pointer )
            value.AudioFormat                               = GetObject<AudioFormat>(new IntPtr(p + 0x038), ReversePrism.DataModels.AudioFormat.FromPointer); // 0270DBDB7D40 0x38 AudioFormat                 ( 0001867179C0 ModelClassType AudioFormat AudioFormat AudioFormat Pointer )
            value.Type                                      = GetString(new IntPtr(p + 0x040)); // 0270DBDB7D60 0x40 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
