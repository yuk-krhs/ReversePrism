using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolId                                   ModelPrimitiveType int int int Int32
    // 014 UnitId                                   ModelPrimitiveType int int int Int32
    // 018 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 019 IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 01A IsLocked                                 ModelPrimitiveType bool bool bool Bool
    // 020 FirstLockedStory                         ModelClassType IIdolStoryStatus IIdolStoryStatus IIdolStoryStatus Pointer
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

            value.IdolId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 IdolId                      ( ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x019)); // 0x19 IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsLocked                                  = GetBool(new IntPtr(p + 0x01A)); // 0x1A IsLocked                    ( ModelPrimitiveType bool bool bool Bool )
            value.FirstLockedStory                          = GetObject<IIdolStoryStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolStoryStatus.FromPointer); // 0x20 FirstLockedStory            ( ModelClassType IIdolStoryStatus IIdolStoryStatus IIdolStoryStatus Pointer )

            return value;
        }
    }
}
