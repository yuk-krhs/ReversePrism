using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 Min                                      ModelPrimitiveType float float float Single
    // 018 Max                                      ModelPrimitiveType float float float Single
    // 01C DisplayTime                              ModelPrimitiveType float float float Single
    // 020 LinkedNotes                              ModelClassListType NoteState[] NoteState[] List<NoteState> Pointer
    public partial class SimultaneousLineState : DataModel
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
            var value   = new SimultaneousLineState() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Min                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 Min                         ( ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 Max                         ( ModelPrimitiveType float float float Single )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C DisplayTime                 ( ModelPrimitiveType float float float Single )
            value.LinkedNotes                               = GetObjectList<NoteState>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteState.FromPointer); // 0x20 LinkedNotes                 ( ModelClassListType NoteState[] NoteState[] List<NoteState> Pointer )

            return value;
        }
    }
}
