using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NoteCount                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Results                                  000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer
    // 020 Perfect                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Great                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Good                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C Miss                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 GreatFast                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 GreatSlow                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 GreatReverse                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C GoodFast                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 GoodSlow                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 GoodReverse                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class JudgmentResultList
    {
        public int                                      NoteCount                               { get; set; }
        public List<JudgmentResult>?                    Results                                 { get; set; }
        public int                                      Perfect                                 { get; set; }
        public int                                      Great                                   { get; set; }
        public int                                      Good                                    { get; set; }
        public int                                      Miss                                    { get; set; }
        public int                                      GreatFast                               { get; set; }
        public int                                      GreatSlow                               { get; set; }
        public int                                      GreatReverse                            { get; set; }
        public int                                      GoodFast                                { get; set; }
        public int                                      GoodSlow                                { get; set; }
        public int                                      GoodReverse                             { get; set; }

        public static JudgmentResultList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JudgmentResultList();

            value.NoteCount                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D4F88F30 0x10 NoteCount                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Results                                   = GetEnumList<JudgmentResult>(new IntPtr(p + 0x018)); // 0270D4F88F50 0x18 Results                     ( 000185CEF1C8 ModelEnumListType List`1<JudgmentResult> List`1<JudgmentResult> List<JudgmentResult> Pointer )
            value.Perfect                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D4F88F70 0x20 Perfect                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Great                                     = GetInt32(new IntPtr(p + 0x024)); // 0270D4F88F90 0x24 Great                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Good                                      = GetInt32(new IntPtr(p + 0x028)); // 0270D4F88FB0 0x28 Good                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Miss                                      = GetInt32(new IntPtr(p + 0x02C)); // 0270D4F88FD0 0x2C Miss                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GreatFast                                 = GetInt32(new IntPtr(p + 0x030)); // 0270D4F88FF0 0x30 GreatFast                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GreatSlow                                 = GetInt32(new IntPtr(p + 0x034)); // 0270D4F89010 0x34 GreatSlow                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GreatReverse                              = GetInt32(new IntPtr(p + 0x038)); // 0270D4F89030 0x38 GreatReverse                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodFast                                  = GetInt32(new IntPtr(p + 0x03C)); // 0270D4F89050 0x3C GoodFast                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodSlow                                  = GetInt32(new IntPtr(p + 0x040)); // 0270D4F89070 0x40 GoodSlow                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodReverse                               = GetInt32(new IntPtr(p + 0x044)); // 0270D4F89090 0x44 GoodReverse                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
