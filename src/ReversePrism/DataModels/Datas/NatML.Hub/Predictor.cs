using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tag                                      ModelPrimitiveType string string string String
    // 018 Status                                   ModelPrimitiveType string string string String
    // 020 AspectMode                               ModelPrimitiveType string string string String
    // 028 Labels                                   ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Normalization                            ModelClassType Normalization Normalization Normalization Pointer
    // 038 AudioFormat                              ModelClassType AudioFormat AudioFormat AudioFormat Pointer
    // 040 Type                                     ModelPrimitiveType string string string String
    public partial class Predictor : DataModel
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
            var value   = new Predictor() { Pointer= p0 };

            value.Tag                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Tag                         ( ModelPrimitiveType string string string String )
            value.Status                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Status                      ( ModelPrimitiveType string string string String )
            value.AspectMode                                = GetString(new IntPtr(p + 0x020)); // 0x20 AspectMode                  ( ModelPrimitiveType string string string String )
            value.Labels                                    = GetStringList(new IntPtr(p + 0x028)); // 0x28 Labels                      ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Normalization                             = GetObject<Normalization>(new IntPtr(p + 0x030), ReversePrism.DataModels.Normalization.FromPointer); // 0x30 Normalization               ( ModelClassType Normalization Normalization Normalization Pointer )
            value.AudioFormat                               = GetObject<AudioFormat>(new IntPtr(p + 0x038), ReversePrism.DataModels.AudioFormat.FromPointer); // 0x38 AudioFormat                 ( ModelClassType AudioFormat AudioFormat AudioFormat Pointer )
            value.Type                                      = GetString(new IntPtr(p + 0x040)); // 0x40 Type                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
