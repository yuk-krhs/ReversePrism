using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_List                                   000185CD96C8 ModelClassListType List`1<EventCallbackFunctorBase> List`1<EventCallbackFunctorBase> List<EventCallbackFunctorBase> Pointer
    // 018 TrickleDownCallbackCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C BubbleUpCallbackCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EventCallbackList
    {
        public List<EventCallbackFunctorBase>?          M_List                                  { get; set; }
        public int                                      TrickleDownCallbackCount                { get; set; }
        public int                                      BubbleUpCallbackCount                   { get; set; }

        public static EventCallbackList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventCallbackList();

            value.M_List                                    = GetObjectList<EventCallbackFunctorBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventCallbackFunctorBase.FromPointer); // 027006767258 0x10 M_List                      ( 000185CD96C8 ModelClassListType List`1<EventCallbackFunctorBase> List`1<EventCallbackFunctorBase> List<EventCallbackFunctorBase> Pointer )
            value.TrickleDownCallbackCount                  = GetInt32(new IntPtr(p + 0x018)); // 027006767278 0x18 TrickleDownCallbackCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BubbleUpCallbackCount                     = GetInt32(new IntPtr(p + 0x01C)); // 027006767298 0x1C BubbleUpCallbackCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
