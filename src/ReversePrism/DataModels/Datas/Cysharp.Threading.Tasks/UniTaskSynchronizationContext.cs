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
    // 000 gate                                     SpinLock IL2CPP_TYPE_VALUETYPE
    // 004 dequing                                  bool IL2CPP_TYPE_BOOLEAN
    // 008 actionListCount                          int IL2CPP_TYPE_I4
    // 010 ActionList                               000185CC5138 ModelEnumListType Callback[] Callback[] List<Callback> Pointer
    // 018 WaitingListCount                         0001865F38E0 ModelPrimitiveType int int int Int32
    // 020 WaitingList                              000185CC5138 ModelEnumListType Callback[] Callback[] List<Callback> Pointer
    // 028 OpCount                                  0001865F38E0 ModelPrimitiveType int int int Int32
    public partial class UniTaskSynchronizationContext
    {
        public List<Callback>?                          ActionList                              { get; set; }
        public int                                      WaitingListCount                        { get; set; }
        public List<Callback>?                          WaitingList                             { get; set; }
        public int                                      OpCount                                 { get; set; }

        public static UniTaskSynchronizationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniTaskSynchronizationContext();

            value.ActionList                                = GetEnumList<Callback>(new IntPtr(p + 0x010)); // 027003BF0D30 0x10 ActionList                  ( 000185CC5138 ModelEnumListType Callback[] Callback[] List<Callback> Pointer )
            value.WaitingListCount                          = GetInt32(new IntPtr(p + 0x018)); // 027003BF0D50 0x18 WaitingListCount            ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.WaitingList                               = GetEnumList<Callback>(new IntPtr(p + 0x020)); // 027003BF0D70 0x20 WaitingList                 ( 000185CC5138 ModelEnumListType Callback[] Callback[] List<Callback> Pointer )
            value.OpCount                                   = GetInt32(new IntPtr(p + 0x028)); // 027003BF0D90 0x28 OpCount                     ( 0001865F38E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
