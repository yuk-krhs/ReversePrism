using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JudgeTime                                000186666F40 ModelPrimitiveType float float float Single
    // 014 Type                                     0001866B0CD0 ModelEnumType NoteType NoteType NoteType Int32
    // 018 FlickDirection                           0001865A4200 ModelEnumType FlickDirection FlickDirection FlickDirection Int32
    // 01C NoteLinePosition                         0001866AF070 ModelEnumType NoteLinePosition NoteLinePosition NoteLinePosition Int32
    // 020 OriginalLanePosition                     0001865F4940 ModelPrimitiveType int int int Int32
    // 024 Size                                     0001866656B0 ModelPrimitiveType float float float Single
    // 028 LanePosition                             0001866656B0 ModelPrimitiveType float float float Single
    // 02C SizeForJudge                             0001866656B0 ModelPrimitiveType float float float Single
    // 030 LanePositionForJudge                     0001866656B0 ModelPrimitiveType float float float Single
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

            value.JudgeTime                                 = GetSingle(new IntPtr(p + 0x010)); // 024664FEA638 0x10 JudgeTime                   ( 000186666F40 ModelPrimitiveType float float float Single )
            value.Type                                      = (NoteType)GetInt32(new IntPtr(p + 0x014)); // 024664FEA658 0x14 Type                        ( 0001866B0CD0 ModelEnumType NoteType NoteType NoteType Int32 )
            value.FlickDirection                            = (FlickDirection)GetInt32(new IntPtr(p + 0x018)); // 024664FEA678 0x18 FlickDirection              ( 0001865A4200 ModelEnumType FlickDirection FlickDirection FlickDirection Int32 )
            value.NoteLinePosition                          = (NoteLinePosition)GetInt32(new IntPtr(p + 0x01C)); // 024664FEA698 0x1C NoteLinePosition            ( 0001866AF070 ModelEnumType NoteLinePosition NoteLinePosition NoteLinePosition Int32 )
            value.OriginalLanePosition                      = GetInt32(new IntPtr(p + 0x020)); // 024664FEA6B8 0x20 OriginalLanePosition        ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetSingle(new IntPtr(p + 0x024)); // 024664FEA6D8 0x24 Size                        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LanePosition                              = GetSingle(new IntPtr(p + 0x028)); // 024664FEA6F8 0x28 LanePosition                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SizeForJudge                              = GetSingle(new IntPtr(p + 0x02C)); // 024664FEA718 0x2C SizeForJudge                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LanePositionForJudge                      = GetSingle(new IntPtr(p + 0x030)); // 024664FEA738 0x30 LanePositionForJudge        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
