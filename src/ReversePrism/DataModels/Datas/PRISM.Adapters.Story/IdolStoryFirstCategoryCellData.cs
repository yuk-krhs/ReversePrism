using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 014 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 IsNew                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 019 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 01A IsLocked                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 FirstLockedStory                         000186579260 ModelClassType IIdolStoryStatus IIdolStoryStatus IIdolStoryStatus Pointer
    public partial class IdolStoryFirstCategoryCellData : DataModel
    {
        public int                                      IdolId                                  { get; set; }
        public int                                      UnitId                                  { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public bool                                     IsLocked                                { get; set; }
        public IIdolStoryStatus?                        FirstLockedStory                        { get; set; }

        public static IdolStoryFirstCategoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCellData() { Pointer= p0 };

            value.IdolId                                    = GetInt32(new IntPtr(p + 0x010)); // 024666858D38 0x10 IdolId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x014)); // 024666858D58 0x14 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x018)); // 024666858D78 0x18 IsNew                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x019)); // 024666858D98 0x19 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsLocked                                  = GetBool(new IntPtr(p + 0x01A)); // 024666858DB8 0x1A IsLocked                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.FirstLockedStory                          = GetObject<IIdolStoryStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolStoryStatus.FromPointer); // 024666858DD8 0x20 FirstLockedStory            ( 000186579260 ModelClassType IIdolStoryStatus IIdolStoryStatus IIdolStoryStatus Pointer )

            return value;
        }
    }
}
