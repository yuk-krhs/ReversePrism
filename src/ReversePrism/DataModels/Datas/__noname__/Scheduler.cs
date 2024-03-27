using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 Scheduler IL2CPP_TYPE_CLASS
    // 010 NeedReSort                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 List                                     000185D14E08 ModelClassListType List`1<Timer> List`1<Timer> List<Timer> Pointer
    // 020 Current_next_run                         0001865F7700 ModelPrimitiveType long long long Int64
    // 028 Changed                                  00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    public partial class Scheduler
    {
        public bool                                     NeedReSort                              { get; set; }
        public List<Timer>?                             List                                    { get; set; }
        public long                                     Current_next_run                        { get; set; }
        public ManualResetEvent?                        Changed                                 { get; set; }

        public static Scheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scheduler();

            value.NeedReSort                                = GetBool(new IntPtr(p + 0x010)); // 0270D6AEEE68 0x10 NeedReSort                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.List                                      = GetObjectList<Timer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Timer.FromPointer); // 0270D6AEEE88 0x18 List                        ( 000185D14E08 ModelClassListType List`1<Timer> List`1<Timer> List<Timer> Pointer )
            value.Current_next_run                          = GetInt64(new IntPtr(p + 0x020)); // 0270D6AEEEA8 0x20 Current_next_run            ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Changed                                   = GetObject<ManualResetEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0270D6AEEEC8 0x28 Changed                     ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )

            return value;
        }
    }
}
