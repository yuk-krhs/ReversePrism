using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InitialSize                              int IL2CPP_TYPE_I4
    // 010 Timing                                   ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 018 runningAndQueueLock                      <object> IL2CPP_TYPE_OBJECT
    // 020 arrayLock                                <object> IL2CPP_TYPE_OBJECT
    // 028 unhandledExceptionCallback               Action`1<Exception> IL2CPP_TYPE_GENERICINST
    // 030 Tail                                     ModelPrimitiveType int int int Int32
    // 034 Running                                  ModelPrimitiveType bool bool bool Bool
    // 038 LoopItems                                ModelClassListType IPlayerLoopItem[] IPlayerLoopItem[] List<IPlayerLoopItem> Pointer
    // 040 waitQueue                                MinimumQueue`1<IPlayerLoopItem> IL2CPP_TYPE_GENERICINST
    public partial class PlayerLoopRunner : DataModel
    {
        public PlayerLoopTiming                         Timing                                  { get; set; }
        public int                                      Tail                                    { get; set; }
        public bool                                     Running                                 { get; set; }
        public List<IPlayerLoopItem>?                   LoopItems                               { get; set; }

        public static PlayerLoopRunner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerLoopRunner() { Pointer= p0 };

            value.Timing                                    = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0x10 Timing                      ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.Tail                                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 Tail                        ( ModelPrimitiveType int int int Int32 )
            value.Running                                   = GetBool(new IntPtr(p + 0x034)); // 0x34 Running                     ( ModelPrimitiveType bool bool bool Bool )
            value.LoopItems                                 = GetObjectList<IPlayerLoopItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPlayerLoopItem.FromPointer); // 0x38 LoopItems                   ( ModelClassListType IPlayerLoopItem[] IPlayerLoopItem[] List<IPlayerLoopItem> Pointer )

            return value;
        }
    }
}
