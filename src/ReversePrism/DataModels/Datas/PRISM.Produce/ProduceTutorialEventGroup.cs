using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventList                                000185CFD088 ModelClassListType List`1<ProduceTutorialEventBase> List`1<ProduceTutorialEventBase> List<ProduceTutorialEventBase> Pointer
    public partial class ProduceTutorialEventGroup
    {
        public List<ProduceTutorialEventBase>?          EventList                               { get; set; }

        public static ProduceTutorialEventGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialEventGroup();

            value.EventList                                 = GetObjectList<ProduceTutorialEventBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceTutorialEventBase.FromPointer); // 0270D5D4AD80 0x10 EventList                   ( 000185CFD088 ModelClassListType List`1<ProduceTutorialEventBase> List`1<ProduceTutorialEventBase> List<ProduceTutorialEventBase> Pointer )

            return value;
        }
    }
}
