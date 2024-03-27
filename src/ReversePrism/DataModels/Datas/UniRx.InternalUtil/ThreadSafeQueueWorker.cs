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
    // 010 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 018 Dequing                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C ActionListCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 actionList                               Action`1<<object>>[] IL2CPP_TYPE_SZARRAY
    // 028 actionStates                             <object>[] IL2CPP_TYPE_SZARRAY
    // 030 WaitingListCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 waitingList                              Action`1<<object>>[] IL2CPP_TYPE_SZARRAY
    // 040 waitingStates                            <object>[] IL2CPP_TYPE_SZARRAY
    public partial class ThreadSafeQueueWorker
    {
        public bool                                     Dequing                                 { get; set; }
        public int                                      ActionListCount                         { get; set; }
        public int                                      WaitingListCount                        { get; set; }

        public static ThreadSafeQueueWorker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadSafeQueueWorker();

            value.Dequing                                   = GetBool(new IntPtr(p + 0x018)); // 027003C22230 0x18 Dequing                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActionListCount                           = GetInt32(new IntPtr(p + 0x01C)); // 027003C22250 0x1C ActionListCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WaitingListCount                          = GetInt32(new IntPtr(p + 0x030)); // 027003C222B0 0x30 WaitingListCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
