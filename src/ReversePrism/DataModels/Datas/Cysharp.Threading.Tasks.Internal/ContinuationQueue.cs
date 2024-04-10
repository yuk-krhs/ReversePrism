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
    // 010 Timing                                   000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 014 Gate                                     00018654CAA0 ModelEnumType SpinLock SpinLock SpinLock Int32
    // 018 Dequing                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C ActionListCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ActionList                               000185B6F460 ModelClassListType Action[] Action[] List<Action> Pointer
    // 028 WaitingListCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 WaitingList                              000185B6F460 ModelClassListType Action[] Action[] List<Action> Pointer
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

            value.Timing                                    = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0245A3BD8840 0x10 Timing                      ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.Gate                                      = (SpinLock)GetInt32(new IntPtr(p + 0x014)); // 0245A3BD8860 0x14 Gate                        ( 00018654CAA0 ModelEnumType SpinLock SpinLock SpinLock Int32 )
            value.Dequing                                   = GetBool(new IntPtr(p + 0x018)); // 0245A3BD8880 0x18 Dequing                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActionListCount                           = GetInt32(new IntPtr(p + 0x01C)); // 0245A3BD88A0 0x1C ActionListCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ActionList                                = GetObjectList<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0245A3BD88C0 0x20 ActionList                  ( 000185B6F460 ModelClassListType Action[] Action[] List<Action> Pointer )
            value.WaitingListCount                          = GetInt32(new IntPtr(p + 0x028)); // 0245A3BD88E0 0x28 WaitingListCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WaitingList                               = GetObjectList<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0245A3BD8900 0x30 WaitingList                 ( 000185B6F460 ModelClassListType Action[] Action[] List<Action> Pointer )

            return value;
        }
    }
}
