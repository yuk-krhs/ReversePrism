using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Attitude                                 ModelClassType QuaternionControl QuaternionControl QuaternionControl Pointer
    // 000 <current>k__BackingField                 AttitudeSensor IL2CPP_TYPE_CLASS
    public partial class AttitudeSensor : DataModel
    {
        public QuaternionControl?                       Attitude                                { get; set; }

        public static AttitudeSensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttitudeSensor() { Pointer= p0 };

            value.Attitude                                  = GetObject<QuaternionControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.QuaternionControl.FromPointer); // 0x170 Attitude                    ( ModelClassType QuaternionControl QuaternionControl QuaternionControl Pointer )

            return value;
        }
    }
}
