using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimelineController                       ModelClassType TimelineController TimelineController TimelineController Pointer
    // 018 OffsetTime                               ModelPrimitiveType float float float Single
    // 01C SoundTimeOffset                          ModelPrimitiveType float float float Single
    // 020 InitializeTask                           ModelEnumType UniTask UniTask UniTask Int32
    public partial class LiveProgressManagerTimelineExtension : DataModel
    {
        public TimelineController?                      TimelineController                      { get; set; }
        public float                                    OffsetTime                              { get; set; }
        public float                                    SoundTimeOffset                         { get; set; }
        public UniTask                                  InitializeTask                          { get; set; }

        public static LiveProgressManagerTimelineExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveProgressManagerTimelineExtension() { Pointer= p0 };

            value.TimelineController                        = GetObject<TimelineController>(new IntPtr(p + 0x010), ReversePrism.DataModels.TimelineController.FromPointer); // 0x10 TimelineController          ( ModelClassType TimelineController TimelineController TimelineController Pointer )
            value.OffsetTime                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 OffsetTime                  ( ModelPrimitiveType float float float Single )
            value.SoundTimeOffset                           = GetSingle(new IntPtr(p + 0x01C)); // 0x1C SoundTimeOffset             ( ModelPrimitiveType float float float Single )
            value.InitializeTask                            = (UniTask)GetInt32(new IntPtr(p + 0x020)); // 0x20 InitializeTask              ( ModelEnumType UniTask UniTask UniTask Int32 )

            return value;
        }
    }
}
