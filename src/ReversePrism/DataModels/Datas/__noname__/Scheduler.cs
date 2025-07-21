using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 Scheduler IL2CPP_TYPE_CLASS
    // 010 NeedReSort                               ModelPrimitiveType bool bool bool Bool
    // 018 List                                     ModelClassListType List`1<Timer> List`1<Timer> List<Timer> Pointer
    // 020 Current_next_run                         ModelPrimitiveType long long long Int64
    // 028 Changed                                  ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    public partial class Scheduler : DataModel
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
            var value   = new Scheduler() { Pointer= p0 };

            value.NeedReSort                                = GetBool(new IntPtr(p + 0x010)); // 0x10 NeedReSort                  ( ModelPrimitiveType bool bool bool Bool )
            value.List                                      = GetObjectList<Timer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Timer.FromPointer); // 0x18 List                        ( ModelClassListType List`1<Timer> List`1<Timer> List<Timer> Pointer )
            value.Current_next_run                          = GetInt64(new IntPtr(p + 0x020)); // 0x20 Current_next_run            ( ModelPrimitiveType long long long Int64 )
            value.Changed                                   = GetObject<ManualResetEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x28 Changed                     ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )

            return value;
        }
    }
}
