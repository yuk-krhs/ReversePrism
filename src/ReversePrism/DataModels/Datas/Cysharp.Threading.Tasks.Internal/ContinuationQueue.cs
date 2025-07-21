using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxArrayLength                           int IL2CPP_TYPE_I4
    // 000 InitialSize                              int IL2CPP_TYPE_I4
    // 010 Timing                                   ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 014 Gate                                     ModelEnumType SpinLock SpinLock SpinLock Int32
    // 018 Dequing                                  ModelPrimitiveType bool bool bool Bool
    // 01C ActionListCount                          ModelPrimitiveType int int int Int32
    // 020 ActionList                               ModelClassListType Action[] Action[] List<Action> Pointer
    // 028 WaitingListCount                         ModelPrimitiveType int int int Int32
    // 030 WaitingList                              ModelClassListType Action[] Action[] List<Action> Pointer
    public partial class ContinuationQueue : DataModel
    {
        public PlayerLoopTiming                         Timing                                  { get; set; }
        public SpinLock                                 Gate                                    { get; set; }
        public bool                                     Dequing                                 { get; set; }
        public int                                      ActionListCount                         { get; set; }
        public List<Action>?                            ActionList                              { get; set; }
        public int                                      WaitingListCount                        { get; set; }
        public List<Action>?                            WaitingList                             { get; set; }

        public static ContinuationQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContinuationQueue() { Pointer= p0 };

            value.Timing                                    = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0x10 Timing                      ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.Gate                                      = (SpinLock)GetInt32(new IntPtr(p + 0x014)); // 0x14 Gate                        ( ModelEnumType SpinLock SpinLock SpinLock Int32 )
            value.Dequing                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 Dequing                     ( ModelPrimitiveType bool bool bool Bool )
            value.ActionListCount                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ActionListCount             ( ModelPrimitiveType int int int Int32 )
            value.ActionList                                = GetObjectList<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 ActionList                  ( ModelClassListType Action[] Action[] List<Action> Pointer )
            value.WaitingListCount                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 WaitingListCount            ( ModelPrimitiveType int int int Int32 )
            value.WaitingList                               = GetObjectList<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0x30 WaitingList                 ( ModelClassListType Action[] Action[] List<Action> Pointer )

            return value;
        }
    }
}
