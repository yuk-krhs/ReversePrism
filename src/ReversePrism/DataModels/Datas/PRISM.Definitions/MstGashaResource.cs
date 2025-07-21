using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 LogoImage                                ModelPrimitiveType string string string String
    // 020 MovieList                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 MovieValueList                           ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 ImageList                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 StepCatchphraseImage                     ModelPrimitiveType string string string String
    public partial class MstGashaResource : DataModel
    {
        public string                                   Id                                      { get; set; }
        public string                                   LogoImage                               { get; set; }
        public List<string>?                            MovieList                               { get; set; }
        public List<string>?                            MovieValueList                          { get; set; }
        public List<string>?                            ImageList                               { get; set; }
        public string                                   StepCatchphraseImage                    { get; set; }

        public static MstGashaResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGashaResource() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.LogoImage                                 = GetString(new IntPtr(p + 0x018)); // 0x18 LogoImage                   ( ModelPrimitiveType string string string String )
            value.MovieList                                 = GetStringList(new IntPtr(p + 0x020)); // 0x20 MovieList                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MovieValueList                            = GetStringList(new IntPtr(p + 0x028)); // 0x28 MovieValueList              ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ImageList                                 = GetStringList(new IntPtr(p + 0x030)); // 0x30 ImageList                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.StepCatchphraseImage                      = GetString(new IntPtr(p + 0x038)); // 0x38 StepCatchphraseImage        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
