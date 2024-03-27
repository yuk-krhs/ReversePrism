using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 020 Description                              000186672F10 ModelPrimitiveType string string string String
    // 028 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 ArchiveBeginDate                         0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 ArchiveEndDate                           0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 Second                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 048 RoomName                                 000186672F10 ModelPrimitiveType string string string String
    // 050 Url                                      000186672F10 ModelPrimitiveType string string string String
    // 058 PModeUrl                                 000186672F10 ModelPrimitiveType string string string String
    // 060 YUrl                                     000186672F10 ModelPrimitiveType string string string String
    // 068 CastList                                 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MstStreamProgram
    {
        public int                                      Id                                      { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Description                             { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 ArchiveBeginDate                        { get; set; }
        public DateTime                                 ArchiveEndDate                          { get; set; }
        public int                                      Second                                  { get; set; }
        public string                                   RoomName                                { get; set; }
        public string                                   Url                                     { get; set; }
        public string                                   PModeUrl                                { get; set; }
        public string                                   YUrl                                    { get; set; }
        public List<int>?                               CastList                                { get; set; }

        public static MstStreamProgram? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstStreamProgram();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004637C40 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 027004637C60 0x18 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 027004637C80 0x20 Description                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 027004637CA0 0x28 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ArchiveBeginDate                          = GetDateTime(new IntPtr(p + 0x030)); // 027004637CC0 0x30 ArchiveBeginDate            ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ArchiveEndDate                            = GetDateTime(new IntPtr(p + 0x038)); // 027004637CE0 0x38 ArchiveEndDate              ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Second                                    = GetInt32(new IntPtr(p + 0x040)); // 027004637D00 0x40 Second                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RoomName                                  = GetString(new IntPtr(p + 0x048)); // 027004637D20 0x48 RoomName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x050)); // 027004637D40 0x50 Url                         ( 000186672F10 ModelPrimitiveType string string string String )
            value.PModeUrl                                  = GetString(new IntPtr(p + 0x058)); // 027004637D60 0x58 PModeUrl                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.YUrl                                      = GetString(new IntPtr(p + 0x060)); // 027004637D80 0x60 YUrl                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.CastList                                  = GetInt32List(new IntPtr(p + 0x068)); // 027004637DA0 0x68 CastList                    ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
