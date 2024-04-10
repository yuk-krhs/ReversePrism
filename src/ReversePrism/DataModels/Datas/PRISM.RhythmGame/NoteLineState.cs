using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Head                                     000186634AA0 ModelClassType NoteState NoteState NoteState Pointer
    // 020 Tail                                     000186634AA0 ModelClassType NoteState NoteState NoteState Pointer
    // 028 Entity                                   0001866AE680 ModelClassType NoteLineEntity NoteLineEntity NoteLineEntity Pointer
    // 030 NoteLineGroup                            0001866AEB80 ModelClassType NoteLineGroup NoteLineGroup NoteLineGroup Pointer
    public partial class NoteLineState : DataModel
    {
        public int                                      Id                                      { get; set; }
        public NoteState?                               Head                                    { get; set; }
        public NoteState?                               Tail                                    { get; set; }
        public NoteLineEntity?                          Entity                                  { get; set; }
        public NoteLineGroup?                           NoteLineGroup                           { get; set; }

        public static NoteLineState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLineState() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02466500F830 0x10 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Head                                      = GetObject<NoteState>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteState.FromPointer); // 02466500F850 0x18 Head                        ( 000186634AA0 ModelClassType NoteState NoteState NoteState Pointer )
            value.Tail                                      = GetObject<NoteState>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteState.FromPointer); // 02466500F870 0x20 Tail                        ( 000186634AA0 ModelClassType NoteState NoteState NoteState Pointer )
            value.Entity                                    = GetObject<NoteLineEntity>(new IntPtr(p + 0x028), ReversePrism.DataModels.NoteLineEntity.FromPointer); // 02466500F890 0x28 Entity                      ( 0001866AE680 ModelClassType NoteLineEntity NoteLineEntity NoteLineEntity Pointer )
            value.NoteLineGroup                             = GetObject<NoteLineGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.NoteLineGroup.FromPointer); // 02466500F8B0 0x30 NoteLineGroup               ( 0001866AEB80 ModelClassType NoteLineGroup NoteLineGroup NoteLineGroup Pointer )

            return value;
        }
    }
}
