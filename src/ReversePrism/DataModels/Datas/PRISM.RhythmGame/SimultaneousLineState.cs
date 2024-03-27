using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Min                                      000186666F40 ModelPrimitiveType float float float Single
    // 018 Max                                      000186666F40 ModelPrimitiveType float float float Single
    // 01C DisplayTime                              000186666F40 ModelPrimitiveType float float float Single
    // 020 LinkedNotes                              000185B986E0 ModelClassListType NoteState[] NoteState[] List<NoteState> Pointer
    public partial class SimultaneousLineState
    {
        public int                                      Id                                      { get; set; }
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }
        public float                                    DisplayTime                             { get; set; }
        public List<NoteState>?                         LinkedNotes                             { get; set; }

        public static SimultaneousLineState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimultaneousLineState();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D4FB3358 0x10 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Min                                       = GetSingle(new IntPtr(p + 0x014)); // 0270D4FB3378 0x14 Min                         ( 000186666F40 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x018)); // 0270D4FB3398 0x18 Max                         ( 000186666F40 ModelPrimitiveType float float float Single )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x01C)); // 0270D4FB33B8 0x1C DisplayTime                 ( 000186666F40 ModelPrimitiveType float float float Single )
            value.LinkedNotes                               = GetObjectList<NoteState>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteState.FromPointer); // 0270D4FB33D8 0x20 LinkedNotes                 ( 000185B986E0 ModelClassListType NoteState[] NoteState[] List<NoteState> Pointer )

            return value;
        }
    }
}
