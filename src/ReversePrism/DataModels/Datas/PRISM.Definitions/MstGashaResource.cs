using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186672F10 ModelPrimitiveType string string string String
    // 018 MovieList                                000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 MovieValueList                           000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 ImageList                                000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 StepCatchphraseImage                     000186672F10 ModelPrimitiveType string string string String
    public partial class MstGashaResource
    {
        public string                                   Id                                      { get; set; }
        public List<string>?                            MovieList                               { get; set; }
        public List<string>?                            MovieValueList                          { get; set; }
        public List<string>?                            ImageList                               { get; set; }
        public string                                   StepCatchphraseImage                    { get; set; }

        public static MstGashaResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstGashaResource();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 027004667438 0x10 Id                          ( 000186672F10 ModelPrimitiveType string string string String )
            value.MovieList                                 = GetStringList(new IntPtr(p + 0x018)); // 027004667458 0x18 MovieList                   ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MovieValueList                            = GetStringList(new IntPtr(p + 0x020)); // 027004667478 0x20 MovieValueList              ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ImageList                                 = GetStringList(new IntPtr(p + 0x028)); // 027004667498 0x28 ImageList                   ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.StepCatchphraseImage                      = GetString(new IntPtr(p + 0x030)); // 0270046674B8 0x30 StepCatchphraseImage        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
