using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumType ProfilerCategory ProfilerCategory ProfilerCategory Int32
    // 012 Flags                                    ModelEnumType MarkerFlags MarkerFlags MarkerFlags Int32
    // 014 DataType                                 ModelEnumType ProfilerMarkerDataType ProfilerMarkerDataType ProfilerMarkerDataType Int32
    // 015 UnitType                                 ModelEnumType ProfilerMarkerDataUnit ProfilerMarkerDataUnit ProfilerMarkerDataUnit Int32
    // 018 Reserved0                                ModelPrimitiveType int int int Int32
    // 01C NameUtf8Len                              ModelPrimitiveType int int int Int32
    // 020 nameUtf8                                 IntPtr IL2CPP_TYPE_PTR
    public partial class ProfilerRecorderDescription : DataModel
    {
        public ProfilerCategory                         Category                                { get; set; }
        public MarkerFlags                              Flags                                   { get; set; }
        public ProfilerMarkerDataType                   DataType                                { get; set; }
        public ProfilerMarkerDataUnit                   UnitType                                { get; set; }
        public int                                      Reserved0                               { get; set; }
        public int                                      NameUtf8Len                             { get; set; }

        public static ProfilerRecorderDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerRecorderDescription() { Pointer= p0 };

            value.Category                                  = (ProfilerCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelEnumType ProfilerCategory ProfilerCategory ProfilerCategory Int32 )
            value.Flags                                     = (MarkerFlags)GetInt32(new IntPtr(p + 0x012)); // 0x12 Flags                       ( ModelEnumType MarkerFlags MarkerFlags MarkerFlags Int32 )
            value.DataType                                  = (ProfilerMarkerDataType)GetInt32(new IntPtr(p + 0x014)); // 0x14 DataType                    ( ModelEnumType ProfilerMarkerDataType ProfilerMarkerDataType ProfilerMarkerDataType Int32 )
            value.UnitType                                  = (ProfilerMarkerDataUnit)GetInt32(new IntPtr(p + 0x015)); // 0x15 UnitType                    ( ModelEnumType ProfilerMarkerDataUnit ProfilerMarkerDataUnit ProfilerMarkerDataUnit Int32 )
            value.Reserved0                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 Reserved0                   ( ModelPrimitiveType int int int Int32 )
            value.NameUtf8Len                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NameUtf8Len                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
