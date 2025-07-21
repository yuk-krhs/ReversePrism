using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MHistory                                 ModelEnumListType Item[] Item[] List<Item> Pointer
    // 018 MTop                                     ModelPrimitiveType int int int Int32
    // 01C MBottom                                  ModelPrimitiveType int int int Int32
    // 020 MCount                                   ModelPrimitiveType int int int Int32
    // 024 MHeadingSum                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 MWeightSum                               ModelPrimitiveType float float float Single
    // 034 MWeightTime                              ModelPrimitiveType float float float Single
    // 038 MLastGoodHeading                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 000 mDecayExponent                           float IL2CPP_TYPE_R4
    public partial class HeadingTracker : DataModel
    {
        public List<Item>?                              MHistory                                { get; set; }
        public int                                      MTop                                    { get; set; }
        public int                                      MBottom                                 { get; set; }
        public int                                      MCount                                  { get; set; }
        public Vector3                                  MHeadingSum                             { get; set; }
        public float                                    MWeightSum                              { get; set; }
        public float                                    MWeightTime                             { get; set; }
        public Vector3                                  MLastGoodHeading                        { get; set; }

        public static HeadingTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeadingTracker() { Pointer= p0 };

            value.MHistory                                  = GetEnumList<Item>(new IntPtr(p + 0x010)); // 0x10 MHistory                    ( ModelEnumListType Item[] Item[] List<Item> Pointer )
            value.MTop                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 MTop                        ( ModelPrimitiveType int int int Int32 )
            value.MBottom                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MBottom                     ( ModelPrimitiveType int int int Int32 )
            value.MCount                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 MCount                      ( ModelPrimitiveType int int int Int32 )
            value.MHeadingSum                               = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 MHeadingSum                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MWeightSum                                = GetSingle(new IntPtr(p + 0x030)); // 0x30 MWeightSum                  ( ModelPrimitiveType float float float Single )
            value.MWeightTime                               = GetSingle(new IntPtr(p + 0x034)); // 0x34 MWeightTime                 ( ModelPrimitiveType float float float Single )
            value.MLastGoodHeading                          = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 MLastGoodHeading            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
