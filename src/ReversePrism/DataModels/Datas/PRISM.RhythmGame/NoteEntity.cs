using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JudgeTime                                ModelPrimitiveType float float float Single
    // 014 Type                                     ModelEnumType NoteType NoteType NoteType Int32
    // 018 FlickDirection                           ModelEnumType FlickDirection FlickDirection FlickDirection Int32
    // 01C NoteLinePosition                         ModelEnumType NoteLinePosition NoteLinePosition NoteLinePosition Int32
    // 020 OriginalLanePosition                     ModelPrimitiveType int int int Int32
    // 024 Size                                     ModelPrimitiveType float float float Single
    // 028 LanePosition                             ModelPrimitiveType float float float Single
    // 02C SizeForJudge                             ModelPrimitiveType float float float Single
    // 030 LanePositionForJudge                     ModelPrimitiveType float float float Single
    public partial class NoteEntity : DataModel
    {
        public float                                    JudgeTime                               { get; set; }
        public NoteType                                 Type                                    { get; set; }
        public FlickDirection                           FlickDirection                          { get; set; }
        public NoteLinePosition                         NoteLinePosition                        { get; set; }
        public int                                      OriginalLanePosition                    { get; set; }
        public float                                    Size                                    { get; set; }
        public float                                    LanePosition                            { get; set; }
        public float                                    SizeForJudge                            { get; set; }
        public float                                    LanePositionForJudge                    { get; set; }

        public static NoteEntity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteEntity() { Pointer= p0 };

            value.JudgeTime                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 JudgeTime                   ( ModelPrimitiveType float float float Single )
            value.Type                                      = (NoteType)GetInt32(new IntPtr(p + 0x014)); // 0x14 Type                        ( ModelEnumType NoteType NoteType NoteType Int32 )
            value.FlickDirection                            = (FlickDirection)GetInt32(new IntPtr(p + 0x018)); // 0x18 FlickDirection              ( ModelEnumType FlickDirection FlickDirection FlickDirection Int32 )
            value.NoteLinePosition                          = (NoteLinePosition)GetInt32(new IntPtr(p + 0x01C)); // 0x1C NoteLinePosition            ( ModelEnumType NoteLinePosition NoteLinePosition NoteLinePosition Int32 )
            value.OriginalLanePosition                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 OriginalLanePosition        ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 Size                        ( ModelPrimitiveType float float float Single )
            value.LanePosition                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 LanePosition                ( ModelPrimitiveType float float float Single )
            value.SizeForJudge                              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C SizeForJudge                ( ModelPrimitiveType float float float Single )
            value.LanePositionForJudge                      = GetSingle(new IntPtr(p + 0x030)); // 0x30 LanePositionForJudge        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
